package api.utilities.internal;


public interface RSPcmPlayer {
    int getCapacity();
    int getFrequency();
    int getNextPosition();
    long getRetryTimeMs();
    int[] getSamples();
    RSPcmStream getStream0();
    long getTimeMs();
    boolean get__j();
    RSPcmStream[] get__ak();
    RSPcmStream[] get__at();
    int get__aq();
    int get__i();
    int get__m();
    int get__p();
    int get__u();
    long get__o();
}
