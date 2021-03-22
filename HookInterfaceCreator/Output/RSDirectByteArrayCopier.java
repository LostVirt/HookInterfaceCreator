package api.utilities.internal;


public interface RSDirectByteArrayCopier extends RSAbstractByteArrayCopier {
    ByteBuffer getDirectBuffer();
}
