package api.utilities.internal;


public interface RSIterableNodeHashTable {
    RSNode[] getBuckets();
    RSNode getCurrent();
    RSNode getCurrentGet();
    int getIndex();
    int getSize();
}
