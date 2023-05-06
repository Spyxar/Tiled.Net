using System.Xml;
using System.Xml.Serialization;
using TiledNet.Enums;
using TiledNet.Models.Layers;

namespace TiledNet.Models;

/// <summary>
/// Represents a Map, this holds basically all the data you will ever need
/// </summary>
[XmlRoot("map")]
public class TiledMap : PropertyHolder
{
    [XmlAttribute("version")]
    public string Version;
    [XmlAttribute("tiledversion")]
    public string TiledVersion;

    [XmlAttribute("class")]
    public string Class;

    [XmlAttribute("orientation")]
    public MapOrientation Orientation;

    [XmlAttribute("renderorder")]
    public RenderOrder RenderOrder;

    [XmlAttribute("compressionlevel")]
    public int CompressionLevel = -1;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    [XmlAttribute("tilewidth")]
    public int TileWidth;
    [XmlAttribute("tileheight")]
    public int TileHeight;

    [XmlAttribute("hexsidelength")]
    public int HexSideLength;

    [XmlAttribute("staggeraxis")]
    public StaggerAxis StaggerAxis;
    [XmlAttribute("staggerindex")]
    public StaggerIndex StaggerIndex;

    [XmlAttribute("parallaxoriginx")]
    public int ParallaxOriginX;
    [XmlAttribute("parallaxoriginy")]
    public int ParallaxOriginY;

    [XmlAttribute("backgroundcolor")]
    public string BackgroundColor;

    [XmlAttribute("nextlayerid")]
    public int NextLayerId;
    [XmlAttribute("nextobjectid")]
    public int NextObjectId;

    [XmlAttribute("infinite")]
    public bool Infinite;

    [XmlElement("tileset")]
    public Tileset[] Tilesets;

    [XmlElement("layer")]
    public TileLayer[] TileLayers;
    [XmlElement("objectgroup")]
    public ObjectLayer[] ObjectLayers;
    [XmlElement("imagelayer")]
    public ImageLayer[] ImageLayers;
    [XmlElement("group")]
    public GroupLayer[] GroupLayers;

    public Tileset GetTilesetByTileGid(int gid)
    {
        if (Tilesets == null)
        {
            return null;
        }
        if (gid == 0)
        {
            return null;
        }

        int tilesLooped = 0;
        foreach (Tileset tileset in Tilesets)
        {
            if (tilesLooped + tileset.TileCount >= gid)
            {
                return tileset;
            }
            tilesLooped += tileset.TileCount;
        }
        return null;
    }

    public TileImageRectangle GetTileImage(int gid)
    {
        if (Tilesets == null)
        {
            return TileImageRectangle.Empty;
        }
        if (gid == 0)
        {
            return TileImageRectangle.Empty;
        }

        int tilesLooped = 0;
        foreach (Tileset tileset in Tilesets)
        {
            if (tilesLooped + tileset.TileCount >= gid)
            {
                int tilePosInThisTileset = tilesLooped == 0 ? gid - 1 : (gid - 1) % tilesLooped;
                int tileX = tilePosInThisTileset % tileset.Columns * tileset.TileWidth;
                int tileY = tilePosInThisTileset / tileset.Columns * tileset.TileHeight;
                return new TileImageRectangle(tileset, tileX, tileY, tileset.TileWidth, tileset.TileHeight);
            }
            tilesLooped += tileset.TileCount;
        }
        return TileImageRectangle.Empty;
    }
}