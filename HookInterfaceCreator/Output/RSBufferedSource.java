package api.utilities.internal;


public interface RSBufferedSource {
    byte[] getBuffer();
    int getCapacity();
    IOException getException();
    InputStream getInputStream();
    int getLimit();
    int getPosition();
    Thread getThread();
}
