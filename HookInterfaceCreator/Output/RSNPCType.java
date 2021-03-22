package api.utilities.internal;


public interface RSNPCType extends RSDualNode {
    int getAmbient();
    int getCombatLevel();
    int getContrast();
    boolean getDrawMapDot();
    int[] getHead();
    int getHeadIconPrayer();
    int getId();
    boolean getIsFollower();
    boolean getIsInteractable();
    int[] getModels();
    String getName();
    String[] getOp();
    RSIterableNodeHashTable getParams();
    int getReadyanim();
    short[] getRecol_d();
    short[] getRecol_s();
    int getResizeh();
    int getResizev();
    short[] getRetex_d();
    short[] getRetex_s();
    int getSize();
    int getTransformVarbit();
    int getTransformVarp();
    int[] getTransforms();
    int getTurnleftanim();
    int getTurnrightanim();
    int getWalkanim();
    int getWalkbackanim();
    int getWalkleftanim();
    int getWalkrightanim();
    boolean get__ax();
    boolean get__j();
    int get__ae();
}
