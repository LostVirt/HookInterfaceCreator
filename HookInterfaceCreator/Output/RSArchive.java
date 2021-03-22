package api.utilities.internal;


public interface RSArchive extends RSAbstractArchive {
    RSArchiveDisk getArchiveDisk();
    int getIndex();
    int getIndexCrc();
    int getIndexVersion();
    RSArchiveDisk getMasterDisk();
    boolean[] getValidGroups();
    boolean get__ay();
    int get__aq();
    boolean get__j();
}
