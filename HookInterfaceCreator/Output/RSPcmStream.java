package api.utilities.internal;


public interface RSPcmStream extends RSNode {
    boolean getActive();
    RSPcmStream getAfter();
    RSAbstractSound getSound();
    int get__f();
}
