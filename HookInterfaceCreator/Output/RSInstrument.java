package api.utilities.internal;


public interface RSInstrument {
    int getDelayDecay();
    int getDelayTime();
    int getDuration();
    RSAudioFilter getFilter();
    int getOffset();
    int[] getOscillatorDelays();
    int[] getOscillatorPitch();
    int[] getOscillatorVolume();
    RSSoundEnvelope get__c();
    RSSoundEnvelope get__d();
    RSSoundEnvelope get__e();
    RSSoundEnvelope get__h();
    RSSoundEnvelope get__k();
    RSSoundEnvelope get__n();
    RSSoundEnvelope get__v();
    RSSoundEnvelope get__y();
    RSSoundEnvelope get__z();
}
