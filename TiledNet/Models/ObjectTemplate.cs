using System.Xml.Serialization;
using TiledNet.Models.Layers;

namespace TiledNet.Models;

[XmlRoot("template")]
public class ObjectTemplate
{
    [XmlElement("tileset")]
    public List<Tileset> Tilesets = [];

    [XmlElement("object")]
    public ObjectLayerObject LayerObject;

    public ObjectTemplate() { }

    public ObjectTemplate(List<Tileset> tilesets, ObjectLayerObject layerObject)
    {
        Tilesets = tilesets;
        LayerObject = layerObject;
    }
}