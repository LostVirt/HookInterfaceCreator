package api.utilities.internal;


public interface RSTextureProvider {
    RSAbstractArchive getArchive();
    double getBrightness0();
    int getCapacity();
    RSNodeDeque getDeque();
    int getRemaining();
    int getTextureSize();
    RSTexture[] getTextures();
}
