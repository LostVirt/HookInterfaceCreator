package api.utilities.internal;


public interface RSMessage extends gj {
    int getCount();
    int getCycle();
    RSTriBool getIsFromFriend0();
    RSTriBool getIsFromIgnored0();
    String getPrefix();
    String getSender();
    RSUsername getSenderUsername();
    String getText();
    int getType();
}
