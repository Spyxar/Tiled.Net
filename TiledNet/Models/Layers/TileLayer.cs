using System.Xml.Serialization;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents a layer consisting of tiles
/// </summary>
public class TileLayer : PropertyHolder
{
    [XmlAttribute("id")]
    public int Id;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("class")]
    public string Class;

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

    [XmlElement("data")]
    public TileLayerData Data;
}