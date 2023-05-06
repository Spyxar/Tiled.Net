using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum TilesetObjectAlignment
{
    [XmlEnum("unspecified")]
    Unspecified,

    [XmlEnum("topleft")]
    TopLeft,
    [XmlEnum("top")]
    Top,
    [XmlEnum("topright")]
    TopRight,

    [XmlEnum("left")]
    Left,
    [XmlEnum("center")]
    Center,
    [XmlEnum("right")]
    Right,

    [XmlEnum("bottomleft")]
    BottomLeft,
    [XmlEnum("bottom")]
    Bottom,
    [XmlEnum("bottomright")]
    BottomRight,
}

public enum TileRenderSize
{
    [XmlEnum("tile")]
    Tile,
    [XmlEnum("grid")]
    Grid
}

public enum TilesetFillMode
{
    [XmlEnum("stretch")]
    Stretch,
    [XmlEnum("preserve-aspect-fit")]
    PreserveAspectFit
}