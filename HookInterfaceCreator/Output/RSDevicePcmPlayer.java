package api.utilities.internal;


public interface RSDevicePcmPlayer extends dh {
    byte[] getByteSamples();
    int getCapacity2();
    AudioFormat getFormat();
    SourceDataLine getLine();
}
