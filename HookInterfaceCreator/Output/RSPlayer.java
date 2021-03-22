package api.utilities.internal;


public interface RSPlayer extends cv {
    String[] getActions();
    int getAnimationCycleEnd();
    int getAnimationCycleStart();
    RSPlayerAppearance getAppearance();
    int getCombatLevel();
    int getHeadIconPk();
    int getHeadIconPrayer();
    int getIndex();
    RSTriBool getIsFriend();
    boolean getIsHidden();
    RSTriBool getIsInClanChat();
    boolean getIsUnanimated();
    RSModel getModel0();
    int getPlane();
    int getSkillLevel();
    int getTeam();
    int getTileHeight();
    int getTileHeight2();
    int getTileX();
    int getTileY();
    RSUsername getUsername();
    boolean get__ay();
    int get__b();
    int get__f();
    int get__g();
    int get__i();
    int get__w();
    int get__x();
}
