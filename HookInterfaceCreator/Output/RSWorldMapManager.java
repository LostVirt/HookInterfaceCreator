package api.utilities.internal;


public interface RSWorldMapManager {
    HashMap getFonts();
    HashMap getIcons();
    boolean getIsLoaded0();
    boolean getLoadStarted();
    RSWorldMapAreaData getMapAreaData();
    RSIndexedSprite[] getMapSceneSprites();
    RSSprite getOverviewSprite();
    RSWorldMapRegion[][] getRegions();
    int get__a();
    int get__b();
    int get__k();
    int get__w();
    HashMap get__z();
    RSAbstractArchive get__l();
    RSAbstractArchive get__q();
    int get__i();
}
