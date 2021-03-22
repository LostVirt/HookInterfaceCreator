package api.utilities.internal;


public interface RSVarcs {
    boolean[] getIntsPersistence();
    long getLastWriteTimeMs();
    Map getMap();
    String[] getStrings();
    boolean getUnwrittenChanges();
}
