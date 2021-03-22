package api.utilities.internal;


public interface RSUserList {
    RSUser[] getArray();
    int getCapacity();
    Comparator getComparator();
    HashMap getPreviousUsernamesMap();
    int getSize0();
    HashMap getUsernamesMap();
}
