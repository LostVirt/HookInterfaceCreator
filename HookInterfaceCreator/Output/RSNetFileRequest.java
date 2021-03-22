package api.utilities.internal;


public interface RSNetFileRequest extends gj {
    RSArchive getArchive();
    int getCrc();
    byte getPadding();
}
