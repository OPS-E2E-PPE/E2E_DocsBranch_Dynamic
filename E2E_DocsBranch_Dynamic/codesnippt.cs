public class FileLogger : BaseLogger
{
    internal static Oid ConvertAlgorithm(EncryptionAlgorithm algorithm)
    {
         switch (algorithm)
         {
             case EncryptionAlgorithm.RC2:
                 return new Oid("RC2");
             case EncryptionAlgorithm.RC4:
                 return new Oid("RC4");
             case EncryptionAlgorithm.Des:
                 return new Oid("DES");
             case EncryptionAlgorithm.TripleDes:
                 return new Oid("3DES");
         }

         throw new SecurityException("The specified algorithm is not supported.");
    }
}
