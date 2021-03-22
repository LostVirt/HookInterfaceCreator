package api.utilities.internal;


public interface RSVorbisSample extends RSNode {
    byte[][] getAudioBlocks();
    int getEnd();
    int getSampleCount();
    int getSampleRate();
    byte[] getSamples();
    int getStart();
    boolean get__h();
    boolean get__p();
    float[] get__g();
    int get__ak();
    int get__at();
    int get__t();
    int get__u();
}
