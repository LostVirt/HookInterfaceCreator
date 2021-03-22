package api.utilities.internal;


public interface RSEvictingDualNodeHashTable {
    int getCapacity();
    RSIterableDualNodeQueue getDeque();
    RSIterableNodeHashTable getHashTable();
    int getRemainingCapacity();
    RSDualNode get__n();
}
