import requests as req
import json


# Код не масштабируемый
class Admin:
    def __init__(self, clientaddr):
        self.clientaddr = clientaddr
        self.login = ""
        self.password = ""
        self.acchash = ""
        self.accname = ""
        self.accsurname = ""

    def splitinput(self):
        return input().split()

    def start(self):
        while (True):
            print('Здравствуйте! Добро пожаловать в панель уравления maxogram!')
            print('Для авторизации напишите /auth <login> <password>')
            params = self.splitinput();
            if len(params) < 3:
                print('Вы не указали все необходимые параметры')
            else:
                if (params[0] == '/auth'):
                    self.login, self.password = params[1], params[2]
                    break
        self.auth()

    def auth(self):
        jsonReq = {
            'accId': 1,
            'accLogin': self.login,
            'accPassword': self.password
        }
        try:
            res = req.post('{0}/account/auth'.format(self.clientaddr), data=json.dumps(jsonReq))
        except ConnectionRefusedError:
            print('Ошибка подключения к сети')

        result = json.loads(res.text)

        if (result.get('id') == 0):
            self.acchash = result.get('message').get('accHash')
            self.accname = result.get('message').get('accName')
            self.accsurname = result.get('message').get('accSurname')

            print('Успешная авторизация')
            print('Вы авторизованы как: {0}'.format(self.accname + " " + self.accsurname))
            self.wait_a_command()
        else:
            print('Неверный логин или пароль (или) у вас нет прав администратора')

    def wait_a_command(self):
        print('Ожидается команда. Список всех команд: /help')
        while (True):
            command = self.splitinput()

            if (len(command) > 0):
                ucommand = command[0]
                if (ucommand == '/help'):
                    print('Список допустимых команд:',
                          '__Команды получения информации:',
                          '/help - помощь',
                          '/userlist <how_many> - список пользователей с их полной информацией, задаётся количество',
                          '__Команды взаимодействия с системой:',
                          '/ban <userid> - заблокировать пользователя',
                          '/pardon <userid> - разблокировать пользователя',
                          '/notify <userid> <text> - отправить уведомление лично пользователю',
                          '/unlog_all - разлогинить всех пользователей из системы',
                          sep='\n'
                          )
                elif (ucommand == '/unlog_all'):
                    jsonReq = {
                        'accHash': self.acchash
                    }

                    res = req.post('{0}/admin/unlogall'.format(self.clientaddr), data=json.dumps(jsonReq))
                    result = json.loads(res.text)

                    if result.get('id') == 0:
                        print('Успешно разлогинены все пользователи')
                    else:
                        print('Сервер вернул ошибку')

                elif (ucommand == '/userlist'):
                    if len(command) == 2:
                        jsonReq = {
                            'accHash': self.acchash,
                            'accId': (command[1])
                        }

                        res = req.post('{0}/account/list'.format(self.clientaddr), data=json.dumps(jsonReq))
                        result = json.loads(res.text)

                        if (result.get('id') == 0):
                            print('Список пользователей:\n')
                            for account in result.get('message'):
                                if (account.get('accId') != -1):
                                    print("id: {0}, Имя: {1}, Фамилия: {2}, Дата рождения: {3}".format(
                                        account.get('accId'),
                                        account.get('accName'),
                                        account.get('accSurname'),
                                        account.get('accBirth')
                                    ))
                    else:
                        print('Некорректно задана команда')
                elif (ucommand == '/notify'):
                    if (len(command) > 3):
                        string = ""
                        for k in range(2, len(command)):
                            string += " " + command[k]

                        jsonReq = {
                            'accName': string,
                            'accHash': self.acchash,
                            'accId': command[1]
                        }

                        res = req.post('{0}/admin/notify/add'.format(self.clientaddr), json.dumps(jsonReq))
                        responce = json.loads(res.text)

                        if (responce.get('id') == 0):
                            print('Уведомление успешно отправлено')
                        else:
                            print('Уведомление не отправлено')

                elif (ucommand == '/ban'):
                    if (len(command) == 2):
                        jsonReq = {
                            'accHash': self.acchash,
                            'accId': command[1],
                            'accName': 'ban'
                        }

                        res = req.post('{0}/admin/ban'.format(self.clientaddr), json.dumps(jsonReq))
                        responce = json.loads(res.text)

                        if (responce.get('id') == 0):
                            print('Пользователь заблокирован')
                        else:
                            print('Операция не удалась')

                elif (ucommand == '/pardon'):
                    if (len(command) == 2):
                        jsonReq = {
                            'accHash': self.acchash,
                            'accId': command[1],
                            'accName': 'pardon'
                        }

                        res = req.post('{0}/admin/ban'.format(self.clientaddr), json.dumps(jsonReq))
                        responce = json.loads(res.text)

                        if (responce.get('id') == 0):
                            print('Пользователь разблокирован')
                        else:
                            print('Операция не удалась')
                else:
                    print('Неопознанная команда. Введите /help для просмотра списка команд')


# Базовая точка входа
if __name__ == "__main__":
    admin = Admin("http://localhost:3000")
    admin.start();
