public final class FailResponce {
    public int id;
    public String message;

    public FailResponce(int id, String message) {
        this.id = id;
        this.message = message;
    }

    @Override
    public String toString() {
        return "{" +
                "\"id\" :" + id + 
                ",\n\"message\" :" + message  +
                '}';
    }

}
