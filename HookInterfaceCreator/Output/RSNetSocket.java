package api.utilities.internal;


public interface RSNetSocket extends ls {
    byte[] getArray();
    boolean getExceptionWriting();
    InputStream getInputStream();
    boolean getIsClosed();
    OutputStream getOutputStream();
    Socket getSocket();
    RSTask getTask();
    RSTaskHandler getTaskHandler();
    int get__e();
    int get__q();
    int get__b();
    int get__s();
}
