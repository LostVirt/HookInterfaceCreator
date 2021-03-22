package api.utilities.internal;


public interface RSModel extends em {
    int getBottomY();
    int getBoundsType();
    int getDiameter();
    byte[] getFaceAlphas();
    int[] getFaceColors1();
    int[] getFaceColors2();
    int[] getFaceColors3();
    int[][] getFaceLabelsAlpha();
    short[] getFaceTextures();
    int[] getIndices1();
    int[] getIndices2();
    int[] getIndices3();
    int getIndicesCount();
    boolean getIsSingleTile();
    int getRadius();
    int[][] getVertexLabels();
    int getVerticesCount();
    int[] getVerticesX();
    int[] getVerticesY();
    int[] getVerticesZ();
    int getXMid();
    int getXMidOffset();
    int getXzRadius();
    int getYMid();
    int getYMidOffset();
    int getZMid();
    int getZMidOffset();
    byte get__u();
    byte[] get__f();
    byte[] get__i();
    int get__t();
    int[] get__m();
    int[] get__p();
    int[] get__r();
}
