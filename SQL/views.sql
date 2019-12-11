CREATE OR REPLACE VIEW contactStats as
SELECT '' Статистика ,accId id, accName Имя, accSurname Фамилия, COUNT(conFrom) Контактов FROM account left join 
contact on conFrom = accId GROUP BY accName, accSurname, accId;

CREATE OR REPLACE VIEW messageStats as
SELECT '' Статистика ,accId id, accName Имя, accSurname Фамилия, COUNT(mId) Сообщений FROM account left join 
msg_p on mReceiver = accId or mSender=accId GROUP BY accName, accSurname, accId;

CREATE OR REPLACE VIEW notifyStats as
SELECT '' Статистика ,accId id, accName Имя, accSurname Фамилия, COUNT(notId) ВхУведомлений FROM account left join 
notification on notReceiver = accId GROUP BY accName, accSurname, accId