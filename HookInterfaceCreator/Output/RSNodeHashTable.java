package api.utilities.internal;


public interface RSNodeHashTable {
    RSNode[] getBuckets();
    RSNode getCurrent();
    RSNode getCurrentGet();
    int getIndex();
    int getSize();
}
