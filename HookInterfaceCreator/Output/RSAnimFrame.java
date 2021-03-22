package api.utilities.internal;


public interface RSAnimFrame {
    RSAnimBase getBase();
    int getTransformCount();
    int[] getTransforms();
    boolean getTransparency();
    int[] getXs();
    int[] getYs();
    int[] getZs();
}
