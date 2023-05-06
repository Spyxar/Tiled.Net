using System.Xml.Serialization;
using TiledNet.Models.Layers;

namespace TiledNet.Models;

/// <summary>
/// Represents a tile inside of a <see cref="Tileset"/>
/// </summary>
public class TilesetTile : PropertyHolder
{
    [XmlAttribute("id")]
    public int Id;

    [XmlAttribute("type")]
    public string Class;

    [XmlAttribute("probability")]
    public string Probability;

    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    [XmlElement("image")]
    public TiledImage Image;

    [XmlElement("objectgroup")]
    public ObjectLayer ObjectGroup;

    [XmlElement("animation")]
    public TileAnimation Animation;
}