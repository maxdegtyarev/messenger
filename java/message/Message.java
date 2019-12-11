package message;

public final class Message {
    public String mSender;
    public String mText;
    public int mReceiver;

    public Message(String mSender, String mText, int mReceiver) {
        this.mSender = mSender;
        this.mText = mText;
        this.mReceiver = mReceiver;
    }


}
