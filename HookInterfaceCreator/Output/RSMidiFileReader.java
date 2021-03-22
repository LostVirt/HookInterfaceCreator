package api.utilities.internal;


public interface RSMidiFileReader {
    int getDivision();
    RSPacket getPacket();
    int[] getTrackLengths();
    int[] getTrackPositions();
    int[] getTrackStarts();
    int get__z();
    int[] get__h();
    long get__q();
}
