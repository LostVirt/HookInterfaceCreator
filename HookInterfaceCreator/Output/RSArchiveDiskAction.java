package api.utilities.internal;


public interface RSArchiveDiskAction extends RSNode {
    RSArchive getArchive();
    RSArchiveDisk getArchiveDisk();
    byte[] getData();
    int getType();
}
