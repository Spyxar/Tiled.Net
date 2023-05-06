using System.IO.Compression;

namespace TiledNet;

public class DecompressionUtils
{
    public static byte[] DecompressGZip(byte[] gzip)
    {
        using GZipStream stream = new(new MemoryStream(gzip), CompressionMode.Decompress);

        const int size = 4096;
        byte[] buffer = new byte[size];

        using MemoryStream memory = new();

        int count = 0;
        do
        {
            count = stream.Read(buffer, 0, size);
            if (count > 0)
            {
                memory.Write(buffer, 0, count);
            }
        }
        while (count > 0);
        return memory.ToArray();
    }

    public static byte[] DecompressZLib(byte[] zlib)
    {
        using ZLibStream stream = new(new MemoryStream(zlib), CompressionMode.Decompress);

        const int size = 4096;
        byte[] buffer = new byte[size];

        using MemoryStream memory = new();

        int count = 0;
        do
        {
            count = stream.Read(buffer, 0, size);
            if (count > 0)
            {
                memory.Write(buffer, 0, count);
            }
        }
        while (count > 0);
        return memory.ToArray();
    }
}