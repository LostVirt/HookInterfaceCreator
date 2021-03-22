package api.utilities.internal;


public interface RSMusicTrack extends RSNode {
    byte[] getMidi();
    RSNodeHashTable getTable();
}
