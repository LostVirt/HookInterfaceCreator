package api.utilities.internal;


public interface RSDemotingHashTable {
    int getCapacity();
    RSIterableNodeHashTable getHashTable();
    RSIterableDualNodeQueue getQueue();
    int getRemaining();
}
