using System.Xml.Serialization;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents a Group Layer, can contain any amount of any layer
/// </summary>
public class GroupLayer : PropertyHolder
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

    [XmlAttribute("opacity")]
    public float Opacity = 1;

    [XmlAttribute("visible")]
    public bool Visible = true;

    [XmlAttribute("tintcolor")]
    public string TintColor;

    [XmlElement("layer")]
    public List<TileLayer> TileLayers = [];
    [XmlElement("objectgroup")]
    public List<ObjectLayer> ObjectLayers = [];
    [XmlElement("imagelayer")]
    public List<ImageLayer> ImageLayers = [];
    [XmlElement("group")]
    public List<GroupLayer> GroupLayers = [];
}