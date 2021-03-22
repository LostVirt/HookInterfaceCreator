package api.utilities.internal;


public interface RSMusicPatchPcmStream extends RSPcmStream {
    RSPcmStreamMixer getMixer();
    RSNodeDeque getQueue();
    RSMidiPcmStream getSuperStream();
}
