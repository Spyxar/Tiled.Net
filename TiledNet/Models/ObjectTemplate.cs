using System.Xml.Serialization;
using TiledNet.Models.Layers;

namespace TiledNet.Models;

[XmlRoot("template")]
public class ObjectTemplate
{
    [XmlElement("tileset")]
    public Tileset[] Tilesets;

    [XmlElement("object")]
    public ObjectLayerObject LayerObject;
}