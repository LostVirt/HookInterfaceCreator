package api.utilities.internal;


public interface RSClientError extends RuntimeException {
    Throwable getCause();
    String getMessage();
}
