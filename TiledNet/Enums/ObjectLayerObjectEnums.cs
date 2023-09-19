using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum HorizontalAlignment
{
    [XmlEnum("left")]
    Left,
    [XmlEnum("center")]
    Center,
    [XmlEnum("right")]
    Right,
    [XmlEnum("justify")]
    Justify
}

public enum VerticalAlignment
{
    [XmlEnum("top")]
    Top,
    [XmlEnum("center")]
    Center,
    [XmlEnum("bottom")]
    Bottom
}