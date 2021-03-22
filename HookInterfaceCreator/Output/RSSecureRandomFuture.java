package api.utilities.internal;


public interface RSSecureRandomFuture {
    ExecutorService getExecutor();
    Future getFuture();
}
