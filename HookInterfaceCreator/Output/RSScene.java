package api.utilities.internal;


public interface RSScene {
    void setDestinationX(int var1);
    void setDestinationY(int var1);
    void setWalking();

    int getMinPlane();
    int getPlanes();
    RSScenery[] getTempScenery();
    int getTempSceneryCount();
    int[][][] getTileHeights();
    RSTile[][][] getTiles();
    int getXSize();
    int getYSize();
    int[][] get__bq();
    int[][] get__bx();
    int[][][] get__l();
}
