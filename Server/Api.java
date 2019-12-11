import account.Account;
import chat.ChatCreateRequest;
import chat.SuccessJsonResponce;
import com.google.gson.Gson;
import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpServer;
import contact.Contact;
import message.Message;

import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.InetSocketAddress;
import java.nio.charset.Charset;
import java.sql.*;
import java.util.Properties;
import java.util.Random;

public final class Api {

    private String serverHost = "localhost";
    private int serverPort = 3000;

    private HttpServer server;

    private Properties properties = new Properties();
    private Gson jsonParser = new Gson();


    private String databaseName = "msgr";
    private String userName = "postgres";
    private String password = "qwerty";

    private String connectionUrl = "jdbc:postgresql://localhost/%s?user=%s&password=%s";
    private String connectionString = new String();

    Connection connection = null;

    public Api() {

        connectionString = String.format(connectionUrl, databaseName, userName, password);

        try {
            connection = DriverManager.getConnection(connectionString);
        } catch (SQLException exception) {
            exception.printStackTrace();
        }

        init();

    }

    private void init() {
        try {
            server = HttpServer.create(new InetSocketAddress(serverHost, serverPort), 0);
            server.createContext("/account/add", new insertAccount());
            server.createContext("/account/auth", new authAccount());
            server.createContext("/account/check", new checkHash());
            server.createContext("/account/list", new getUserList());
            server.createContext("/account/contact/add", new createContact());
            server.createContext("/account/contact/list", new getContactList());
            server.createContext("/account/contact/activelist", new getActivePrivateMessageList());
            server.createContext("/account/notification/list", new getAvailableNotificationList());
            server.createContext("/account/update", new updateNameSurname());

            server.createContext("/message/add", new writePrivateMessage());
            server.createContext("/message/list", new getPrivateMessageList());
            server.createContext("/message/unread", new getUnreadPrivateMessageList());

            server.createContext("/admin/unlogall", new unlogAll());
            server.createContext("/admin/notify/add", new createNotify());
            server.createContext("/admin/ban", new banAccount());

        } catch (IOException exception) {
            exception.printStackTrace();
        }
    }

    public void startApi() {
        server.start();
    }

    private String toJson(HttpExchange httpExchange) throws IOException {
        StringBuilder body = new StringBuilder();
        try {
            InputStreamReader reader = new InputStreamReader(httpExchange.getRequestBody());
            char[] buffer = new char[256];
            int read;
            while ((read = reader.read(buffer)) != -1) {
                body.append(buffer, 0, read);
            }
        } catch (IOException exception) {
            exception.printStackTrace();
        }

        return body.toString();
    }

    private boolean checkMethod(HttpExchange exchange, String method) {
        return exchange.getRequestMethod().equals(method);
    }

    private String generateRandomString(int lenght) {
        byte[] array = new byte[lenght];
        new Random().nextBytes(array);
        String result = new String(array, Charset.forName("UTF-8"));
        return result;

    }

    /*
            Регистрация аккаунта
     */
    private class insertAccount implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select regAccount('%s','%s','%s','%s', '%s', False)", account.accLogin,
                            account.accName, account.accSurname, account.accBirth, account.accPassword));

                    resultSet.next();

                    String result = resultSet.getString(1);
                    result = String.format("{\"id\" : %s}", result);

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);


                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-2, "\"User is already exists\"").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    /*
        Авторизация аккаунта
     */
    private class authAccount implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();


                    ResultSet resultSet = statement.executeQuery(String.format("Select authAccount('%s', '%s', %s)",
                            account.accLogin, account.accPassword, (account.accId == 1)));

                    resultSet.next();

                    String result = resultSet.getString(1);

                    result = new SuccessJsonResponce(0, result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-3, "\"This user does not exists\"").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    /*
        Создание чата
     */
    private class createChat implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                ChatCreateRequest request = jsonParser.fromJson(jsonInputString, ChatCreateRequest.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select createChat('%s', %s, '%s')",
                            request.chName, request.chPrivate, request.accHash));

                    resultSet.next();

                    String result = resultSet.getString(1);
                    result = String.format("{\"chatid\" : \"%s\"}", result);
                    result = new SuccessJsonResponce(0, result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-4, "\"Uncorrect hash or chat also exists\"").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    /*
        Проверка хеша
     */
    private class checkHash implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select checkHash('%s')", account.accHash));

                    resultSet.next();

                    String result = resultSet.getString(1);

                    if (result.equals("t"))
                        result = "true";
                    else
                        result = "false";

                    result = String.format("{\"exists\" : %s}", result);
                    result = new SuccessJsonResponce(0,result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-5, "{\"exists\": false}").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    /*
        Возвращает список пользователей
     */
    private class getUserList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Account account = jsonParser.fromJson(jsonInputString, Account.class);
                System.out.println(account);
                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getAccountList('%s', %s)", account.accHash, account.accId <= 0 ? 20 : account.accId));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"accId\": -1,\n" +
                            "            \"accName\": \"\",\n" +
                            "            \"accSurname\": \"\",\n" +
                            "            \"accBirth\": \"\"\n" +
                            "        }");

                    while (resultSet.next()) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    builder.append("]");

                    String result = builder.toString();

                    result = String.format("%s", result);
                    result = new SuccessJsonResponce(0, result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-5, "{\"message\": \"error\"}").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }


    /*
        Добалвяет пользователя в список контактов
     */
    private class createContact implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Contact contact = jsonParser.fromJson(jsonInputString, Contact.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select addContact(%s, '%s');", contact.conTo, contact.conFrom));

                    resultSet.next();
                    String result = resultSet.getString(1);


                    result = new SuccessJsonResponce(0, result).toString();

                    System.out.println(result);
                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-6, "{\"message\": \"Can not create a new contact\"}").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class getContactList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Contact contact = jsonParser.fromJson(jsonInputString, Contact.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getContactList('%s');", contact.conFrom));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"accId\": -1,\n" +
                            "            \"accName\": \"\",\n" +
                            "            \"accSurname\": \"\",\n" +
                            "            \"accBirth\": \"\"\n" +
                            "        }");

                    while (resultSet.next()) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    builder.append("]");

                    String result = builder.toString();

                    result = new SuccessJsonResponce(0, result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);

                    writer.write(result);

                } catch (SQLException exception) {
                    String message = new FailResponce(-6, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, message.getBytes().length);
                    writer.write(message);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class writePrivateMessage implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Message message = jsonParser.fromJson(jsonInputString, Message.class);
                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select writePrivateMessage(%s, '%s', '%s')", message.mReceiver, message.mText, message.mSender));

                    resultSet.next();

                    String result = resultSet.getString(1);
                    result = String.format("%s", result);

                    result = new SuccessJsonResponce(0, result).toString();
                    httpExchange.sendResponseHeaders(200, result.getBytes().length);
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-7, "{\"message\": \"Uncorrect params\"}").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class getPrivateMessageList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {

                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);
                Message message = jsonParser.fromJson(jsonInputString, Message.class);
                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getPrivateMessageList(%s, '%s')", message.mReceiver, message.mSender));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"mSender\": -1,\n" +
                            "            \"mReceiver\": \"\",\n" +
                            "            \"mText\": \"\"\n" +
                            "        }");

                    while (resultSet.next()) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    StringBuilder append = builder.append("]");

                    String result = builder.toString();

                    result = new SuccessJsonResponce(0, result).toString();
                    httpExchange.sendResponseHeaders(200, result.getBytes().length);
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-8, "{\"message\": \"Uncorrect params\"}").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class getActivePrivateMessageList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Message message = jsonParser.fromJson(jsonInputString, Message.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getActivePrivateMessageList('%s')", message.mSender));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"mSender\": -1\n," +
                            "            \"mReceiver\": \"\",\n" +
                            "            \"mSenderName\": \"\",\n" +
                            "            \"mSenderSurname\": \"\",\n" +
                            "            \"mReceiverName\": \"\",\n" +
                            "            \"mReceiverSurname\": \"\"\n" +
                            "        }");

                    while ( resultSet.next() ) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    builder.append("]");

                    String result = builder.toString();

                    result = new SuccessJsonResponce(0, result).toString();
                    httpExchange.sendResponseHeaders(200, result.getBytes().length);
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-9, "{\"message\": \"Uncorrect params\"}").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class getUnreadPrivateMessageList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Message message = jsonParser.fromJson(jsonInputString, Message.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getUnreadPrivateMessageList(%s, '%s')", message.mReceiver, message.mSender));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"mSender\": -1,\n" +
                            "            \"mReceiver\": \"\",\n" +
                            "            \"mText\": \"\"\n" +
                            "        }");

                    while (resultSet.next()) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    StringBuilder append = builder.append("]");

                    String result = builder.toString();

                    result = new SuccessJsonResponce(0, result).toString();
                    httpExchange.sendResponseHeaders(200, result.getBytes().length);
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-10, "{\"message\": \"Uncorrect params\"}").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class getAvailableNotificationList implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select getAvailableNotifications('%s')", account.accHash));

                    StringBuilder builder = new StringBuilder("[ {\n" +
                            "            \"notReceiver\": -1,\n" +
                            "            \"notText\": \"\"\n" +
                            "        }");

                    while (resultSet.next()) {
                        builder.append(",").append(resultSet.getString(1));
                    }

                    StringBuilder append = builder.append("]");

                    String result = builder.toString();

                    result = new SuccessJsonResponce(0, result).toString();

                    httpExchange.sendResponseHeaders(200, result.getBytes().length);
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-11, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class unlogAll implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select unlogAll('%s')", account.accHash));

                    resultSet.next();

                    String result = new SuccessJsonResponce(0,resultSet.getString(1).equals("t")).toString();
                    httpExchange.sendResponseHeaders(200, result.length());
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-12, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class createNotify implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select sendNotification(%s, '%s', '%s')", account.accId, account.accName, account.accHash));

                    resultSet.next();

                    String result = new SuccessJsonResponce(0,resultSet.getString(1).equals("t")).toString();
                    httpExchange.sendResponseHeaders(200, result.length());
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-13, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class banAccount implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select blockAccount(%s, %s, '%s')", account.accId, account.accName.equals("ban"), account.accHash));

                    resultSet.next();

                    String result = new SuccessJsonResponce(0,resultSet.getString(1).equals("t")).toString();
                    httpExchange.sendResponseHeaders(200, result.length());
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-14, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }

    private class updateNameSurname implements HttpHandler {
        @Override
        public void handle(HttpExchange httpExchange) throws IOException {
            if (checkMethod(httpExchange, "POST")) {
                OutputStreamWriter writer = new OutputStreamWriter(httpExchange.getResponseBody());
                String jsonInputString = toJson(httpExchange);

                Account account = jsonParser.fromJson(jsonInputString, Account.class);

                try {
                    Statement statement = connection.createStatement();
                    ResultSet resultSet = statement.executeQuery(String.format("Select updateAccount('%s', '%s', '%s')", account.accName, account.accSurname, account.accHash));

                    resultSet.next();

                    String result = new SuccessJsonResponce(0,resultSet.getString(1).equals("t")).toString();
                    httpExchange.sendResponseHeaders(200, result.length());
                    writer.write(result);

                } catch (SQLException exception) {
                    String responce = new FailResponce(-15, "\"Uncorrect hash\"").toString();
                    httpExchange.sendResponseHeaders(202, responce.getBytes().length);
                    writer.write(responce);
                    exception.printStackTrace();

                } finally {
                    writer.close();
                    httpExchange.close();
                }

            } else {
                httpExchange.sendResponseHeaders(405, -1);
            }
        }
    }



}
