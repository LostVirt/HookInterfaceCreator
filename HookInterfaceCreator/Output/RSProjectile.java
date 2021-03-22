package api.utilities.internal;


public interface RSProjectile extends em {
    double getAccelerationZ();
    int getCycleEnd();
    int getCycleStart();
    int getFrame();
    int getFrameCycle();
    int getId();
    int getInt3();
    int getInt4();
    int getInt5();
    boolean getIsMoving();
    int getPitch();
    int getPlane();
    RSSeqType getSeqType();
    int getSourceX();
    int getSourceY();
    int getSourceZ();
    double getSpeed();
    double getSpeedX();
    double getSpeedY();
    double getSpeedZ();
    int getTargetIndex();
    double getX();
    double getY();
    int getYaw();
    double getZ();
}
