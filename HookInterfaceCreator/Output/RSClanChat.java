package api.utilities.internal;


public interface RSClanChat extends RSUserList {
    RSUsernamed getLocalUser();
    RSLoginType getLoginType();
    byte getMinKick();
    String getName();
    String getOwner();
    int getRank();
    int get__w();
}
