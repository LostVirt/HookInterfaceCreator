package api.utilities.internal;


public interface RSMusicPatchPcmStream extends dw {
    RSPcmStreamMixer getMixer();
    RSNodeDeque getQueue();
    RSMidiPcmStream getSuperStream();
}
