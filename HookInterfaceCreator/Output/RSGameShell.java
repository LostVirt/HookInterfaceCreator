package api.utilities.internal;


public interface RSGameShell extends Applet {
    Canvas getCanvas();
    long getCanvasSetTimeMs();
    int getCanvasX();
    int getCanvasY();
    Clipboard getClipboard();
    int getContentHeight();
    int getContentHeight0();
    int getContentWidth();
    int getContentWidth0();
    EventQueue getEventQueue();
    Frame getFrame();
    boolean getHasErrored();
    boolean getIsCanvasInvalid();
    int getMaxCanvasHeight();
    int getMaxCanvasWidth();
    RSMouseWheelHandler getMouseWheelHandler();
    long getStopTimeMs();
    boolean get__al();
    boolean get__ak();
}
