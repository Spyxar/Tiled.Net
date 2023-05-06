using System.Xml.Serialization;
using TiledNet.Enums;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents an object layer, can contain any amount of <see cref="ObjectLayerObject"/>
/// </summary>
public class ObjectLayer : PropertyHolder
{
    [XmlAttribute("id")]
    public int Id;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("class")]
    public string Class;

    [XmlAttribute("color")]
    public string Color;

    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    [XmlAttribute("opacity")]
    public float Opacity = 1;

    [XmlAttribute("visible")]
    public bool Visible = true;

    [XmlAttribute("tintcolor")]
    public string TintColor;

    [XmlAttribute("offsetx")]
    public int OffsetX;
    [XmlAttribute("offsety")]
    public int OffsetY;

    [XmlAttribute("parallaxx")]
    public int ParallaxX = 1;
    [XmlAttribute("parallaxy")]
    public int ParallaxY = 1;

    [XmlAttribute("draworder")]
    public DrawOrder DrawOrder;

    [XmlElement("object")]
    public ObjectLayerObject[] Objects;
}