package api.utilities.internal;


public interface RSPcmStreamMixer extends RSPcmStream {
    RSNodeDeque getSubStreams();
    int get__c();
    int get__d();
    RSNodeDeque get__v();
}
