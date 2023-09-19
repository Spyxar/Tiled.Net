using System.Xml.Serialization;
using TiledNet.Enums;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents a single object inside of an <see cref="ObjectLayer"/>
/// </summary>
public class ObjectLayerObject : PropertyHolder
{
    [XmlAttribute("id")]
    public int Id;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("type")]
    public string Type;

    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    [XmlAttribute("rotation")]
    public float Rotation;

    [XmlAttribute("gid")]
    public int Gid;

    [XmlAttribute("visible")]
    public bool Visible;

    [XmlAttribute("template")]
    public string Template;

    [XmlElement("ellipse")]
    public EllipseObject Ellipse;

    [XmlElement("point")]
    public PointObject Point;

    [XmlElement("text")]
    public TextObject Text;

    //ToDo: https://doc.mapeditor.org/en/stable/reference/tmx-map-format/#tmx-objectgroup
    //Polygon, Polyline
    //Don't forget to edit the builder
}

public class EllipseObject { }

public class PointObject { }

public class TextObject
{
    [XmlAttribute("fontfamily")]
    public string FontFamily;

    [XmlAttribute("pixelsize")]
    public int PixelSize;

    [XmlAttribute("wrap")]
    public bool WordWrapping;

    [XmlAttribute("color")]
    public string Color;

    [XmlAttribute("bold")]
    public bool Bold;
    [XmlAttribute("italic")]
    public bool Italic;
    [XmlAttribute("underline")]
    public bool Underline;
    [XmlAttribute("strikeout")]
    public bool Strikeout;

    [XmlAttribute("kerning")]
    public bool Kerning;

    [XmlAttribute("halign")]
    public HorizontalAlignment HorizontalAlignment;
    [XmlAttribute("valign")]
    public VerticalAlignment VerticalAlignment;

    [XmlText]
    public string Text;
}