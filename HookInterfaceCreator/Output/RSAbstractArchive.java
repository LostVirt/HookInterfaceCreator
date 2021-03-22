package api.utilities.internal;


public interface RSAbstractArchive {
    int[] getFileCounts();
    int[][] getFileIds();
    RSIntHashTable[] getFileNameHashTables();
    int[][] getFileNameHashes();
    Object[][] getFiles();
    int getGroupCount();
    int[] getGroupCrcs();
    int[] getGroupIds();
    RSIntHashTable getGroupNameHashTable();
    int[] getGroupNameHashes();
    int[] getGroupVersions();
    Object[] getGroups();
    int getHash();
    boolean getReleaseGroups();
    boolean getShallowFiles();
}
