package account;/*
    2019, Maxim Degtyarev
    The essence of user
 */

public final class Account {
    public String accLogin;
    public int accId;
    public String accName;
    public String accSurname;
    public String accBirth;
    public String accPassword;
    public String accHash;

    public Account() {
        accId = -1;
    }

    public Account(String accLogin, String accName, String accSurname, String accBirth, String accPassword, String accHash) {
        this.accName = accName;
        this.accSurname = accSurname;
        this.accBirth = accBirth;
        this.accPassword = accPassword;
        this.accHash = accHash;
        this.accLogin = accLogin;
    }

    public boolean isEmpty() {
        return (accId == -1);
    }
}
