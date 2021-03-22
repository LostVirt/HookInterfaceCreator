package api.utilities.internal;


public interface RSSprite extends RSRasterizer2D {
    int getHeight();
    int[] getPixels();
    int getSubHeight();
    int getSubWidth();
    int getWidth();
    int getXOffset();
    int getYOffset();
}
