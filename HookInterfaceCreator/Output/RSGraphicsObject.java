package api.utilities.internal;


public interface RSGraphicsObject extends RSEntity {
    int getCycleStart();
    int getFrame();
    int getFrameCycle();
    int getHeight();
    int getId();
    boolean getIsFinished();
    int getPlane();
    RSSeqType getSeqType();
    int getX();
    int getY();
}
