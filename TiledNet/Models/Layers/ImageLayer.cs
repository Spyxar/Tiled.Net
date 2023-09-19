using System.Xml.Serialization;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents a layer made up of a single image
/// </summary>
public class ImageLayer : PropertyHolder
{
    [XmlAttribute("id")]
    public int Id;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("class")]
    public string Class;

    [XmlAttribute("offsetx")]
    public int OffsetX;
    [XmlAttribute("offsety")]
    public int OffsetY;

    [XmlAttribute("parallaxx")]
    public int ParallaxX = 1;
    [XmlAttribute("parallaxy")]
    public int ParallaxY = 1;

    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("opacity")]
    public float Opacity = 1;

    [XmlAttribute("visible")]
    public bool Visible = true;

    [XmlAttribute("tintcolor")]
    public string TintColor;

    [XmlAttribute("repeatx")]
    public bool RepeatX;
    [XmlAttribute("repeaty")]
    public bool RepeatY;

    [XmlElement("image")]
    public TiledImage Image;
}