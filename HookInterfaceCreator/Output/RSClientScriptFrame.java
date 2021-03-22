package api.utilities.internal;


public interface RSClientScriptFrame {
    int[] getIntLocals();
    int getPc();
    RSClientScript getScript();
    String[] getStringLocals();
}
