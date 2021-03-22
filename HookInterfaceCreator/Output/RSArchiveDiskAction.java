package api.utilities.internal;


public interface RSArchiveDiskAction extends ga {
    RSArchive getArchive();
    RSArchiveDisk getArchiveDisk();
    byte[] getData();
    int getType();
}
