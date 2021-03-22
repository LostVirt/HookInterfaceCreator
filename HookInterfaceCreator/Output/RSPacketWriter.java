package api.utilities.internal;


public interface RSPacketWriter {
    RSPacketBit getBit();
    RSIterableNodeDeque getBitNodes();
    RSIsaac getIsaac();
    RSPacket getPacket();
    RSServerProt getServerPacket0();
    int getServerPacket0Length();
    RSAbstractSocket getSocket0();
    boolean get__q();
    RSServerProt get__a();
    RSServerProt get__b();
    RSServerProt get__w();
    int get__d();
    int get__l();
    int get__s();
}
