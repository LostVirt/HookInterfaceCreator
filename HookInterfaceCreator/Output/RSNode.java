package api.utilities.internal;


public interface RSNode {
    long getKey();
    RSNode getNext();
    RSNode getPrevious();
}
