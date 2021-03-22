package api.utilities.internal;


public interface RSUrlRequester {
    boolean getIsClosed();
    Queue getRequests();
    Thread getThread();
}
