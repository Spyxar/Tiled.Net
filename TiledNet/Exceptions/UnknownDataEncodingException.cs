namespace TiledNet.Exceptions;

[Serializable]
public class UnknownDataEncodingException : Exception
{
    public UnknownDataEncodingException() { }

    public UnknownDataEncodingException(string message)
        : base(message) { }

    public UnknownDataEncodingException(string message, Exception inner)
        : base(message, inner) { }
}