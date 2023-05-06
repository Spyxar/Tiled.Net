using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum MapOrientation
{
    [XmlEnum("orthogonal")]
    Orthogonal,
    [XmlEnum("isometric")]
    Isometric,
    [XmlEnum("staggered")]
    Staggered,
    [XmlEnum("hexagonal")]
    Hexagonal
}

public enum RenderOrder
{
    [XmlEnum("right-down")]
    RightDown,
    [XmlEnum("right-up")]
    RightUp,
    [XmlEnum("left-down")]
    LeftDown,
    [XmlEnum("left-up")]
    LeftUp
}

public enum StaggerAxis
{
    [XmlEnum("x")]
    X,
    [XmlEnum("y")]
    Y
}

public enum StaggerIndex
{
    [XmlEnum("even")]
    Even,
    [XmlEnum("odd")]
    Odd
}