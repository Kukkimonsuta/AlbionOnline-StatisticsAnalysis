using System.IO.Compression;
using System.Security.Cryptography;

namespace StatisticAnalysisTool.Extractor.IO;

public class BinFileStream : Stream
{
    private static readonly byte[] s_key = { 48, 239, 114, 71, 66, 242, 4, 50 };
    private static readonly byte[] s_iv = { 14, 166, 220, 137, 219, 237, 220, 79 };

    private ICryptoTransform _decryptor;
    private Stream _inputCryptoStream;
    private Stream _inputGZipStream;

    public BinFileStream(string path)
        : this(File.OpenRead(path))
    {
    }
    public BinFileStream(Stream inputStream, bool leaveOpen = false)
    {
        using var des = DES.Create();
        des.Key = s_key;
        des.IV = s_iv;
        des.Mode = CipherMode.CBC;

        _decryptor = des.CreateDecryptor();

        _inputCryptoStream = new CryptoStream(inputStream, _decryptor, CryptoStreamMode.Read, leaveOpen);
        _inputGZipStream = new GZipStream(_inputCryptoStream, CompressionMode.Decompress);
    }

    #region Stream

    public override void Flush()
    {
        _inputGZipStream.Flush();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        return _inputGZipStream.Read(buffer, offset, count);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        return _inputGZipStream.Seek(offset, origin);
    }

    public override void SetLength(long value)
    {
        _inputGZipStream.SetLength(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        _inputGZipStream.Write(buffer, offset, count);
    }

    public override bool CanRead => _inputGZipStream.CanRead;

    public override bool CanSeek => _inputGZipStream.CanSeek;

    public override bool CanWrite => _inputGZipStream.CanWrite;

    public override long Length => _inputGZipStream.Length;

    public override long Position
    {
        get => _inputGZipStream.Position;
        set => _inputGZipStream.Position = value;
    }

    #endregion

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_inputGZipStream != null)
            {
                _inputGZipStream.Dispose();
                _inputGZipStream = null!;
            }
            if (_inputCryptoStream != null)
            {
                _inputCryptoStream.Dispose();
                _inputCryptoStream = null!;
            }
            if (_decryptor != null)
            {
                _decryptor.Dispose();
                _decryptor = null!;
            }
        }

        base.Dispose(disposing);
    }
}
