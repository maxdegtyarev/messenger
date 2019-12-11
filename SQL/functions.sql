CREATE OR REPLACE FUNCTION regAccount(Login VARCHAR(30), Name VARCHAR(30),
	Surname VARCHAR(30),
	Birth DATE,
	Password VARCHAR(50),
	Blocked BOOLEAN = FALSE)
	RETURNS INTEGER AS $$
	DECLARE numOfDublicates INTEGER;
	DECLARE accId_ret INTEGER;
	BEGIN
	
		SELECT COUNT(accId) Into numOfDublicates FROM account WHERE accLogin = Login;
		
		if (numOfDublicates > 0) then
			RAISE EXCEPTION 'This user is ready exists';
		end if;
		
		
		INSERT INTO account(accLogin, accName, accSurname, accBirth, accPassword, accBlocked) 
		VALUES (Login, Name, Surname, Birth, md5(Password), Blocked);
		
		SELECT (accId) INTO accId_ret FROM account WHERE (accLogin = Login);
		
		RETURN accId_ret;
			
	END;
	
	$$ LANGUAGE plpgsql
	

CREATE OR REPLACE FUNCTION authAccount(Login VARCHAR(30),
	Password VARCHAR(50), Admin BOOLEAN =False)
	RETURNS JSON AS $$
	DECLARE respHash VARCHAR(180);
	DECLARE accId_r INTEGER;
	DECLARE isAdmin SMALLINT;
	BEGIN
		SELECT accId Into accId_r FROM account WHERE (accLogin = Login) 
						AND (accPassword = md5(Password));
						
		if (COUNT(accId_r) != 1) then
			RAISE EXCEPTION 'This user is not exists';
		end if;
		
		--Теперь смотрим на админку
		
		if (Admin) then
			SELECT roleType INTO isAdmin FROM role WHERE roleAccount = accId_r;
			if (isAdmin != 1) then
				RAISE EXCEPTION 'This user is not admin';
			end if;
		end if;
		
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		UPDATE account SET accHash = md5(random_text(30)) WHERE accId = accId_r;
		
		RETURN (SELECT json_build_object('accId', accId, 'accName' , accName, 'accSurname', accSurname, 'accBlocked', accBlocked, 'accHash', accHash) FROM account WHERE accId = accId_r);				
	END;
	
	$$ LANGUAGE plpgsql


CREATE OR REPLACE FUNCTION updateAccount(Name VARCHAR(30),
	Surname VARCHAR(30),
	Hash VARCHAR(160) = '')
	RETURNS BOOLEAN AS $$
	DECLARE accId_ret INTEGER;
	BEGIN


		if checkHash(Hash) then
		
			SELECT (accId) INTO accId_ret FROM account WHERE accHash = Hash;

			UPDATE account SET accName = Name, accSurname = Surname
			WHERE accId = accId_ret;

			RETURN True;
		else
			raise exception 'Uncorrect hash';
		end if;
			
	END;
	
	$$ LANGUAGE plpgsql


CREATE OR REPLACE FUNCTION writeMessage(Chat INT, Message VARCHAR(800), Hash VARCHAR(160))
	RETURNS BOOLEAN 
	AS $$
	DECLARE accId_ret INTEGER;
	DECLARE chatId_ret INTEGER;
	
	BEGIN
	
		SELECT (accId) INTO accId_ret FROM account WHERE accHash = Hash;
		
		if count(accId_ret) = 0 then
			raise exception 'Uncorrect hash';
		end if;
		
		SELECT inChat into chatId_ret FROM inchat WHERE inUser = accId_ret AND inChat = Chat;
		
		if count(chatId_ret) = 0 then
			raise exception 'This user is not member of this chat';
		end if;
		
	
		INSERT INTO msg(mChat, mAuthor, mText) VALUES (chatId_ret, accId_ret, Message);
		
		return True;
	END;
	
	$$ LANGUAGE plpgsql

CREATE OR REPLACE FUNCTION checkHash(Hash VARCHAR(160)
	)
	RETURNS BOOLEAN AS $$
	DECLARE accHash_c INTEGER;
	BEGIN
	
		SELECT COUNT(accId) Into accHash_c FROM account WHERE accHash = Hash;
		
		if (accHash_c = 1) then
			return TRUE;
		else
			return FALSE;
		end if;
		
			
	END;
	
	$$ LANGUAGE plpgsql


CREATE OR REPLACE FUNCTION getAccountList(Hash VARCHAR(160), HowMany INTEGER=20
	)
	RETURNS TABLE (
		field JSON
		) AS $$
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		
		if (HowMany < 1) then
			raise exception 'List of user can not be less than 1';
		else
			RETURN QUERY (SELECT json_build_object('accId', accId, 'accName', accName, 'accSurname', accSurname, 'accBirth', accBirth
										) FROM account WHERE accHash != Hash LIMIT HowMany);	
		end if;
					
	END;
	
	$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION addContact(WhoId INT, Hash VARCHAR(160)
	)
	RETURNS JSON AS $$
	DECLARE accId_ret INT;
	DECLARE accId_f_ret INT;
	DECLARE addit INT;
	
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		SELECT accId INTO accId_ret FROM account WHERE accHash = Hash;
		SELECT accId INTO accId_f_ret FROM account WHERE accId = WhoId;
		
		if count(accId_ret) = 0 or count(accId_f_ret) = 0 then
			raise exception 'User is not found';
		end if;
		
		--Теперь если пользователь уже добавлял в контакты человека, то осуществим его удаление
		
		SELECT count(conFrom) INTO addit FROM contact WHERE conFrom = accId_ret AND conTo = accId_f_ret;
		
		if addit > 0 then
			DELETE FROM contact WHERE conFrom = accId_ret AND conTo = accId_f_ret;
			RETURN null;
		else
			INSERT INTO contact(conFrom, conTo) VALUES (accId_ret, accId_f_ret);
			RETURN (SELECT json_build_object('conFrom', conFrom, 'conTo', conTo) 
					FROM contact WHERE conFrom = accId_ret GROUP BY conFrom, conTo HAVING (conTo = accId_f_ret));
		end if;

		
		
	END;
	
	$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION getContactList(Hash VARCHAR(160)
	)
	RETURNS TABLE (
	data JSON) AS $$
	DECLARE accId_ret INT;
	BEGIN
	
		SELECT accId INTO accId_ret FROM account WHERE accHash = Hash;
		
		if count(accId_ret) = 0 then
			raise exception 'Invalid hash';
		end if;
		
		if count(accId_ret) > 1 then
			raise exception 'Have more 1? OMG';
		end if;
		
		RETURN QUERY (SELECT json_build_object('accId', accId, 'accName', accName, 'accSurname', accSurname, 'accBirth', accBirth) 
				FROM contact, account WHERE conFrom = accId_ret GROUP BY accId, accName, accSurname, conTo HAVING accId = conTo);
		
	END;
	$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION accountExists(id INT)
RETURNS BOOLEAN AS $$
		DECLARE accId_ret INT;
		BEGIN
		
			SELECT accId INTO accId_ret FROM account WHERE accId = id;
			
			if count(accId_ret) = 0 then
				return false;
			else
				return true;
			end if;
	END;
	
	$$ LANGUAGE plpgsql

/*
	Отправляет сообщение пользователю
*/
CREATE OR REPLACE FUNCTION writePrivateMessage(receiver INT, message VARCHAR(90), hash VARCHAR(160))
	RETURNS INTEGER AS $$
	DECLARE accId_ret INTEGER;
	BEGIN
	
		--Проверяем хеш
		if checkHash(hash) and accountExists(receiver) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = hash;
			
			INSERT INTO msg_p(mSender, mReceiver, mText, mSeen, mDate) VALUES 
						(accId_ret, receiver, message, false, NOW()::timestamp);
				
			accId_ret := currval('msg_p_mid_seq');
			return accId_ret;
		else
			raise exception 'Uncorrect hash or receiver id';
		end if;
			
		return accId_ret;
		
	END;
	$$ LANGUAGE plpgsql
/*
	Возвращает сообщения
	UPD: Sort Feature
*/
CREATE OR REPLACE FUNCTION getPrivateMessageList(with_account INT,
									  hash VARCHAR(160))
	RETURNS TABLE (
		data JSON)
		AS $$
	DECLARE accId_ret INTEGER;
	BEGIN
	
		--Проверяем хеш и существование ресивера
		if checkHash(hash) and accountExists(with_account) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = hash;
			
			UPDATE msg_p SET mSeen = true WHERE mSender = with_account AND mReceiver = accId_ret;
			
			RETURN QUERY (SELECT json_build_object('mId', mId, 'mSender', mSender, 'mReceiver', mReceiver, 'mText', mText, 'mDate', mDate)
						 FROM msg_p WHERE (mSender = with_account AND mReceiver = accId_ret) OR (mSender = accId_ret and mReceiver = with_account) ORDER BY mId);
						 

		else
			raise exception 'Uncorrect hash or receiver id';
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql

/*
	Возвращает аккаунты, с которыми пользователь ведёт диалог
*/
CREATE OR REPLACE FUNCTION getActivePrivateMessageList(hash VARCHAR(160))
	RETURNS TABLE (
		data JSON)  
		AS $$
	DECLARE accId_ret INTEGER;
	BEGIN
	
		--Проверяем хеш и существование ресивера
		if checkHash(hash) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = hash;
			RETURN QUERY (SELECT json_build_object('mSender', mSender, 'mReceiver', mReceiver, 'mSenderName', mSenderName, 'mSenderSurname', mSenderSurname, 'mReceiverName', mReceiverName, 'mReceiverSurname', mReceiverSurname)
						 FROM (SELECT a.mSender mSender,
							a.mReceiver mReceiver,
						    a.accName mReceiverName,
						    a.accSurname mReceiverSurname,
						    b.accName mSenderName,
						    b.accSurname mSenderSurname 
					FROM
						(SELECT DISTINCT mSender, mReceiver, accName, accSurname FROM account, msg_p
								WHERE mSender = accId_ret or mReceiver=accId_ret GROUP BY mSender, mReceiver, accName, accSurname, accId HAVING accId=mReceiver) as a INNER JOIN
						(SELECT DISTINCT mSender, mReceiver, accName, accSurname FROM account, msg_p
								WHERE mSender = accId_ret or mReceiver=accId_ret GROUP BY mSender, mReceiver, accName, accSurname, accId HAVING accId=mSender) as b ON (a.mSender = b.mSender) and (a.mReceiver=b.mReceiver)) as foo);
		else
			raise exception 'Uncorrect hash';
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql
	
CREATE OR REPLACE FUNCTION random_text(length INTEGER)
    RETURNS TEXT
    LANGUAGE PLPGSQL
    AS $$
    DECLARE
        possible_chars TEXT := '0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ';
        output TEXT := '';
        i INT4;
        pos INT4;
    BEGIN

        FOR i IN 1..length LOOP
            pos := floor(random() * 20);
            output := output || substr(possible_chars, pos, 1);
        END LOOP;

        RETURN output;
    END;
    $$;
	
CREATE OR REPLACE FUNCTION getUnreadPrivateMessageList(sender INT,
								  hash VARCHAR(160))
RETURNS TABLE (
	data JSON)
	AS $$
	DECLARE accId_ret INTEGER;
	BEGIN
	
		--Проверяем хеш и существование ресивера
		if checkHash(hash) and accountExists(sender) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = hash;
			
			--Берём непрочитанные сообщения, 
			RETURN QUERY (SELECT json_build_object('mSender', mSender, 'mReceiver', mReceiver, 'mText', mText) FROM msg_p WHERE mSender=sender
																				AND mReceiver=accId_ret AND mSeen = false);
			
			UPDATE msg_p SET mSeen = true WHERE mSender=sender and mReceiver=accId_ret;
		else
			raise exception 'Uncorrect hash';
		end if;
		
	END;

$$ LANGUAGE plpgsql

CREATE OR REPLACE FUNCTION getAvailableNotifications(hash VARCHAR(160)) 
	RETURNS TABLE (
		data JSON)  
		AS $$
	DECLARE accId_ret INTEGER;
	BEGIN
	
		--Проверяем хеш
		if checkHash(hash) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = hash;
			RETURN QUERY SELECT json_build_object('notReceiver', notReceiver, 'notText', notText) 
				FROM (SELECT notId, notReceiver, notText FROM notification WHERE notReceiver = accId_ret AND notSeen = False ORDER BY notId) as foo;
				
			UPDATE notification SET notSeen = True WHERE notReceiver = accId_ret;
			
		else
			raise exception 'Uncorrect hash';
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql
	
CREATE OR REPLACE FUNCTION unlogAll(Hash VARCHAR(160)
	)
	RETURNS BOOLEAN AS $$
	DECLARE accId_ret INT;
	
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		if checkHash(Hash) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = Hash;
			
			if isAdmin(accId_ret) then
				UPDATE account SET accHash = '' where accId != accId_ret;
				return true;
			else
				raise exception 'This user is not admin';
			end if;
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql;
	
	
CREATE OR REPLACE FUNCTION isAdmin(Id INTEGER
	)
	RETURNS BOOLEAN AS $$
	DECLARE role_d INT;
	
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		if accountExists(Id) then
			SELECT roleType into role_d FROM role WHERE roleAccount = Id;
			if (role_d = 1) then 
				return true;
			else
				return false;
				
			end if;
		else
			RAISE EXCEPTION 'Account is not exists';
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION blockAccount(Id INTEGER, Action BOOLEAN=False, Hash VARCHAR(160)=''
	)
	RETURNS BOOLEAN AS $$
	DECLARE accId_ret INT;
	
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		if checkHash(Hash) and accountExists(Id) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = Hash;
			
			if isAdmin(accId_ret) then
				UPDATE account SET accBlocked=Action WHERE accId = Id;
				return true;
			else
				return false;
			end if;
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql;
	
CREATE OR REPLACE FUNCTION sendNotification(Id INTEGER, Text VARCHAR(90), Hash VARCHAR(160)=''
	)
	RETURNS BOOLEAN AS $$
	DECLARE accId_ret INT;
	
	BEGIN
		/*
			Если пользователь найден, генерируем хеш авторизации, возвращаем его.					
		*/
		if checkHash(Hash) and accountExists(Id) then
			SELECT accId INTO accId_ret FROM account WHERE accHash = Hash;
			
			if isAdmin(accId_ret) then
				INSERT INTO notification(notReceiver, notText, notSeen) VALUES(Id, Text, False);
				return true;
			else
				raise exception 'This user is not admin';
			end if;
		else
			raise exception 'Uncorrect hash or user does not exists';
		end if;
		
	END;
	
	$$ LANGUAGE plpgsql;