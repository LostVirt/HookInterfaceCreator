package api.utilities.internal;


public interface RSTile extends ga {
    boolean getDrawPrimary();
    boolean getDrawScenery();
    int getDrawSceneryEdges();
    boolean getDrawSecondary();
    RSFloorDecoration getFloorDecoration();
    RSTile getLinkedBelowTile();
    int getMinPlane();
    RSTileModel getModel();
    RSObjStack getObjStack();
    int getOriginalPlane();
    RSTilePaint getPaint();
    int getPlane();
    RSScenery[] getScenery();
    int getSceneryCount();
    int getSceneryEdgeMask();
    int[] getSceneryEdgeMasks();
    RSWall getWall();
    RSWallDecoration getWallDecoration();
    int getX();
    int getY();
    int get__p();
    int get__t();
    int get__u();
}
