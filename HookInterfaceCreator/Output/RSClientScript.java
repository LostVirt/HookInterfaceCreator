package api.utilities.internal;


public interface RSClientScript extends gj {
    int getIntArgumentCount();
    int[] getIntOperands();
    int getLocalIntCount();
    int getLocalStringCount();
    int[] getOpcodes();
    int getStringArgumentCount();
    String[] getStringOperands();
    RSIterableNodeHashTable[] getSwitches();
}
