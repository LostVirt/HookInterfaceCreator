package api.utilities.internal;


public interface RSBufferedNetSocket extends RSAbstractSocket {
    RSBufferedSink getSink();
    Socket getSocket();
    RSBufferedSource getSource();
}
