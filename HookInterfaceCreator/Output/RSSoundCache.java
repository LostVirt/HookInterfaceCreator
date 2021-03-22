package api.utilities.internal;


public interface RSSoundCache {
    RSNodeHashTable getRawSounds();
    RSAbstractArchive getSoundEffectIndex();
    RSAbstractArchive getVorbisSampleIndex();
    RSNodeHashTable getVorbisSamples();
}
