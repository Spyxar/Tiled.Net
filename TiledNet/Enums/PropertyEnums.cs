using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum PropertyType
{
    [XmlEnum("string")]
    String,
    [XmlEnum("int")]
    Int,
    [XmlEnum("float")]
    Float,
    [XmlEnum("bool")]
    Bool,
    [XmlEnum("color")]
    Color,
    [XmlEnum("file")]
    File,
    [XmlEnum("object")]
    Object,
    [XmlEnum("class")]
    Class
}