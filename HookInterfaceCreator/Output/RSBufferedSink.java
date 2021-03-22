package api.utilities.internal;


public interface RSBufferedSink {
    byte[] getBuffer();
    int getCapacity();
    IOException getException();
    boolean getIsClosed0();
    int getLimit();
    OutputStream getOutputStream();
    int getPosition();
    Thread getThread();
}
