package api.utilities.internal;


public interface RSArchiveDisk {
    int getArchive();
    RSBufferedFile getDatFile();
    RSBufferedFile getIdxFile();
    int getMaxEntrySize();
}
