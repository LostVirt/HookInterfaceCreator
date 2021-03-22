package api.utilities.internal;


public interface RSNodeDeque {
    default RSNode[] getNodes() {
        ArrayList<RSNode> list = new ArrayList();
        RSNode iter = this.getSentinel();
        while(true) {
            RSNode previous = iter.getPrevious();
            if (previous == this.getSentinel()) {
                return (RSNode[])list.toArray(new RSNode[0]);
            }
            iter = previous;
            list.add(previous);
        }
    }

    RSNode getCurrent();
    RSNode getSentinel();
}
