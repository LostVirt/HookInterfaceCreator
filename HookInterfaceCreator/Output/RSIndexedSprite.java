package api.utilities.internal;


public interface RSIndexedSprite extends RSRasterizer2D {
    int getHeight();
    int[] getPalette();
    byte[] getPixels();
    int getSubHeight();
    int getSubWidth();
    int getWidth();
    int getXOffset();
    int getYOffset();
}
