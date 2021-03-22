package api.utilities.internal;


public interface RSVorbisFloor {
    int[] getClassDimensions();
    int[] getClassMasterbooks();
    int[] getClassSubClasses();
    int getMultiplier();
    int[] getPartitionClassList();
    int[][] getSubclassBooks();
    int[] getXList();
}
