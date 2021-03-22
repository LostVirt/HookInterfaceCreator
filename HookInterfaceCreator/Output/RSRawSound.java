package api.utilities.internal;


public interface RSRawSound extends RSAbstractSound {
    int getEnd();
    int getSampleRate();
    byte[] getSamples();
    int getStart();
    boolean get__y();
}
