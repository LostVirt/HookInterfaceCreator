package api.utilities.internal;


public interface RSTask {
    int getIntArgument();
    RSTask getNext();
    Object getObjectArgument();
    Object getResult();
    int getStatus();
    int getType();
}
