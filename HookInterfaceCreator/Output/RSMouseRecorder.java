package api.utilities.internal;


public interface RSMouseRecorder {
    int getIndex();
    boolean getIsRunning();
    Object getLock();
    long[] getMillis();
    int[] getXs();
    int[] getYs();
}
