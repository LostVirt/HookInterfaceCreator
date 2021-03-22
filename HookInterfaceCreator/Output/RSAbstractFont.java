package api.utilities.internal;


public interface RSAbstractFont extends RSRasterizer2D {
    int[] getAdvances();
    int getAscent();
    int[] getHeights();
    byte[] getKerning();
    int[] getLeftBearings();
    int getMaxAscent();
    int getMaxDescent();
    byte[][] getPixels();
    int[] getTopBearings();
    int[] getWidths();
}
