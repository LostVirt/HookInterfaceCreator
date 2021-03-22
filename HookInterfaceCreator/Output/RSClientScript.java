package api.utilities.internal;


public interface RSClientScript extends RSDualNode {
    int getIntArgumentCount();
    int[] getIntOperands();
    int getLocalIntCount();
    int getLocalStringCount();
    int[] getOpcodes();
    int getStringArgumentCount();
    String[] getStringOperands();
    RSIterableNodeHashTable[] getSwitches();
}
