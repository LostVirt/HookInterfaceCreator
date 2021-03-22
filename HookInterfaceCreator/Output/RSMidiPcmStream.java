package api.utilities.internal;


public interface RSMidiPcmStream extends RSPcmStream {
    RSMidiFileReader getMidiFile();
    RSNodeHashTable getMusicPatches();
    RSMusicPatchPcmStream getPatchStream();
    int getTrack();
    int getTrackLength();
    boolean get__ag();
    RSMusicPatchNode[][] get__ay();
    RSMusicPatchNode[][] get__j();
    int get__d();
    int get__v();
    int[] get__b();
    int[] get__c();
    int[] get__e();
    int[] get__h();
    int[] get__l();
    int[] get__m();
    int[] get__o();
    int[] get__p();
    int[] get__q();
    int[] get__r();
    int[] get__s();
    int[] get__t();
    int[] get__u();
    int[] get__y();
    int[] get__z();
    long get__aq();
    long get__at();
}
