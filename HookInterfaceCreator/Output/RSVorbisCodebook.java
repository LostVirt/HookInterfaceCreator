package api.utilities.internal;


public interface RSVorbisCodebook {
    int getDimensions();
    int getEntries();
    int[] getLengths();
    float[][] getMultiplicands();
    int[] getMults();
    int[] get__h();
}
