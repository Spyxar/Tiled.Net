using System.Xml.Serialization;
using TiledNet.Enums;

namespace TiledNet.Models;

public class Tileset : PropertyHolder
{
    [XmlAttribute("firstgid")]
    public int FirstGid;

    [XmlAttribute("source")]
    public string Source;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("class")]
    public string Class;

    [XmlAttribute("tilewidth")]
    public int TileWidth;
    [XmlAttribute("tileheight")]
    public int TileHeight;

    [XmlAttribute("spacing")]
    public int Spacing;
    [XmlAttribute("margin")]
    public int Margin;

    [XmlAttribute("tilecount")]
    public int TileCount;
    [XmlAttribute("columns")]
    public int Columns;

    [XmlAttribute("objectalignment")]
    public TilesetObjectAlignment ObjectAlignment;

    [XmlAttribute("tilerendersize")]
    public TileRenderSize TileRenderSize;

    [XmlAttribute("fillmode")]
    public TilesetFillMode TilesetFillMode;

    [XmlElement("image")]
    public TiledImage Image;

    [XmlElement("tileoffset")]
    public TilesetTileOffset TileOffset;

    [XmlElement("grid")]
    public TilesetGrid Grid;

    //ToDo: https://doc.mapeditor.org/en/stable/reference/tmx-map-format/#tmx-tileset
    //Terraintypes, wangsets, transformations (wangsets replaced terraintypes)
    //Remember to update the builder when this gets implemented

    [XmlElement("tile")]
    public List<TilesetTile> Tiles = new();
}

public class TilesetTileOffset
{
    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    public TilesetTileOffset() { }

    public TilesetTileOffset(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class TilesetGrid
{
    [XmlAttribute("orientation")]
    public TilesetGridOrientation Orientation;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    public TilesetGrid() { }

    public TilesetGrid(TilesetGridOrientation orientation, int width, int height)
    {
        Orientation = orientation;
        Width = width;
        Height = height;
    }

    public enum TilesetGridOrientation
    {
        [XmlEnum("orthogonal")]
        Orthogonal,
        [XmlEnum("isometric")]
        Isometric
    }
}