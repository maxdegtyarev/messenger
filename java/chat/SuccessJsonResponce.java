package chat;

import com.google.gson.Gson;


public final class SuccessJsonResponce {
    public int id;
    public Object message;
    public String jsonMessage;

    public SuccessJsonResponce(int id, Object message) {
        this.id = id;
        this.message = message;

        Gson jsonParser = new Gson();
        jsonMessage = jsonParser.toJson(message, message.getClass());
    }

    public SuccessJsonResponce(int id, String message) {
        this.id = id;
        this.jsonMessage = message;

    }

    @Override
    public String toString() {
        return "{" +
                "\"id\" :" + id  +
                ",\n\"message\" :" + jsonMessage +
                "}";
    }
}
