using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum DrawOrder
{
    [XmlEnum("topdown")]
    TopDown,
    [XmlEnum("index")]
    Index
}