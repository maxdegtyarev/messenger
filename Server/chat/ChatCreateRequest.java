package chat;

public final class ChatCreateRequest {

    public String accHash;
    public String chName;
    public String chPrivate;

    public ChatCreateRequest(String accHash, String chName, String chPrivate) {
        this.accHash = accHash;
        this.chName = chName;
        this.chPrivate = chPrivate;
    }


    @Override
    public String toString() {
        return "ChatCreateRequest{" +
                "accHash='" + accHash + '\'' +
                ", chName='" + chName + '\'' +
                ", chPrivate='" + chPrivate + '\'' +
                '}';
    }
}
