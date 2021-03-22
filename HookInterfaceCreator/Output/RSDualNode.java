package api.utilities.internal;


public interface RSDualNode extends RSNode {
    long getKeyDual();
    RSDualNode getNextDual();
    RSDualNode getPreviousDual();
}
