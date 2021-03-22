package api.utilities.internal;


public interface RSAccessFile {
    long getCapacity();
    RandomAccessFile getFile();
    long getIndex();
}
