package api.utilities.internal;


public interface RSAnimBase extends RSNode {
    int getId();
    int getTransformCount();
    int[][] getTransformLabels();
    int[] getTransformTypes();
}
