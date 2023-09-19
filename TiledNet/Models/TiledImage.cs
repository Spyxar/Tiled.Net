using System.Xml.Serialization;

namespace TiledNet.Models;

/// <summary>
/// Represents an image
/// </summary>
public class TiledImage
{
    [XmlAttribute("format")]
    public string Format;

    [XmlAttribute("source")]
    public string Source;

    [XmlAttribute("trans")]
    public string TransparentColor;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    public TiledImage() { }

    public TiledImage(string format, string source, string transparentColor, int width, int height)
    {
        Format = format;
        Source = source;
        TransparentColor = transparentColor;
        Width = width;
        Height = height;
    }
}