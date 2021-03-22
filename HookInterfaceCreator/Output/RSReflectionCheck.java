package api.utilities.internal;


public interface RSReflectionCheck extends RSNode {
    byte[][][] getArguments();
    int[] getCreationErrors();
    Field[] getFields();
    int getId();
    int[] getIntReplaceValues();
    Method[] getMethods();
    int[] getOperations();
    int getSize();
}
