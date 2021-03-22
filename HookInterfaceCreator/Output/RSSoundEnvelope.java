package api.utilities.internal;


public interface RSSoundEnvelope {
    int getAmplitude();
    int[] getDurations();
    int getEnd();
    int getForm();
    int getMax();
    int getPhaseIndex();
    int[] getPhases();
    int getSegments();
    int getStart();
    int getStep();
    int getTicks();
}
