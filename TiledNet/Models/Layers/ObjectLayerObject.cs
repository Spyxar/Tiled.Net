using System.Xml.Serialization;

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

    //ToDo: https://doc.mapeditor.org/en/stable/reference/tmx-map-format/#tmx-objectgroup
    //Polygon, Polyline, Text
}

public class EllipseObject { }

public class PointObject { }