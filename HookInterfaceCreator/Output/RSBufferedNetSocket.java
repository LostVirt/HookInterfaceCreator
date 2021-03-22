package api.utilities.internal;


public interface RSBufferedNetSocket extends ls {
    RSBufferedSink getSink();
    Socket getSocket();
    RSBufferedSource getSource();
}
