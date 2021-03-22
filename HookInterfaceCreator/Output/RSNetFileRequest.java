package api.utilities.internal;


public interface RSNetFileRequest extends RSDualNode {
    RSArchive getArchive();
    int getCrc();
    byte getPadding();
}
