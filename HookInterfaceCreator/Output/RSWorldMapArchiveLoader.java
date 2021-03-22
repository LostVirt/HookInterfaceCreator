package api.utilities.internal;


public interface RSWorldMapArchiveLoader {
    RSAbstractArchive getArchive();
    String getCacheName();
    boolean getIsLoaded0();
    int getPercentLoaded0();
}
