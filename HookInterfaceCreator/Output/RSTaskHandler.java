package api.utilities.internal;


public interface RSTaskHandler {
    RSTask getCurrent();
    boolean getIsClosed();
    RSTask getTask0();
    Thread getThread();
}
