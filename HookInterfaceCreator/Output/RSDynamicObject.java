package api.utilities.internal;


public interface RSDynamicObject extends RSEntity {
    int getCycleStart();
    int getFrame();
    int getId();
    int getOrientation();
    int getPlane();
    RSSeqType getSeqType();
    int getType();
    int getX();
    int getY();
}
