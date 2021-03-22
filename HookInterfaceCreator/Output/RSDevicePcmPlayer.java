package api.utilities.internal;


public interface RSDevicePcmPlayer extends RSPcmPlayer {
    byte[] getByteSamples();
    int getCapacity2();
    AudioFormat getFormat();
    SourceDataLine getLine();
}
