package api.utilities.internal;


public interface RSUnlitModel extends RSEntity {
    byte[] getFaceAlphas();
    short[] getFaceColors();
    int getFaceCount();
    int[][] getFaceLabelsAlpha();
    RSFaceNormal[] getFaceNormals();
    short[] getFaceTextures();
    int[] getIndices1();
    int[] getIndices2();
    int[] getIndices3();
    boolean getIsBoundsCalculated();
    int[][] getVertexLabels();
    int getVerticesCount();
    int[] getVerticesX();
    int[] getVerticesY();
    int[] getVerticesZ();
    byte get__k();
    byte[] get__b();
    byte[] get__l();
    byte[] get__q();
    byte[] get__x();
    RSVertexNormal[] get__ay();
    RSVertexNormal[] get__j();
    int get__ac();
    int get__ak();
    int get__aq();
    int get__at();
    int get__ax();
    int get__i();
    int[] get__p();
    int[] get__t();
    short[] get__f();
    short[] get__g();
    short[] get__u();
    short get__ag();
    short get__am();
}
