/*
	Триггер создания уведомления сообщения
*/
CREATE OR REPLACE FUNCTION writeMsgNotification() RETURNS trigger as $writeNotification$
	DECLARE
		receiver INTEGER;
		sender INTEGER;
		senderName varchar;
		senderSurname varchar;
	BEGIN
		receiver := NEW.mReceiver;
		sender := NEW.mSender;
		
		if accountExists(receiver) and accountExists(sender) then
			SELECT accName, accSurname INTO senderName, senderSurname FROM account WHERE accId = sender;
			
			INSERT INTO notification(notReceiver, notText, notSeen) VALUES (receiver, concat('Вам пришло сообщение от: ', senderName, ' ' , senderSurname), False);
			
		end if;
		
		RETURN NULL;
		
	END;
	$writeNotification$ LANGUAGE plpgsql;
	
	
CREATE TRIGGER writeNotification AFTER INSERT ON msg_p FOR ROW EXECUTE FUNCTION writeMsgNotification();


CREATE OR REPLACE FUNCTION writeBaseRole() RETURNS trigger as $writeBaseRole$
	DECLARE
		id INTEGER;
	BEGIN
		id = NEW.accId;
		
		if accountExists(id) then
			INSERT INTO role(roleAccount, roleType, roleComment) VALUES (id, 0, 'Обычный пользователь');
		end if;
		
		RETURN NULL;
		
	END;
	$writeBaseRole$ LANGUAGE plpgsql;
	
CREATE TRIGGER writeBaseRole AFTER INSERT ON account FOR ROW EXECUTE FUNCTION writeBaseRole();