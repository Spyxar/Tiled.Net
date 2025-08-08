using TiledNet.Enums;
using TiledNet.Models;
using TiledNet.Models.Layers;

namespace TiledNet.Builders;

public class TiledMapBuilder
{
    private readonly TiledMap _map = new();

    public TiledMapBuilder SetVersion(string version)
    {
        _map.Version = version;
        return this;
    }

    public TiledMapBuilder SetTiledVersion(string tiledVersion)
    {
        _map.TiledVersion = tiledVersion;
        return this;
    }

    public TiledMapBuilder SetClass(string @class)
    {
        _map.Class = @class;
        return this;
    }

    public TiledMapBuilder SetMapOrientation(MapOrientation mapOrientation)
    {
        _map.Orientation = mapOrientation;
        return this;
    }

    public TiledMapBuilder SetRenderOrder(RenderOrder renderOrder)
    {
        _map.RenderOrder = renderOrder;
        return this;
    }

    public TiledMapBuilder SetCompressionLevel(int compressionLevel)
    {
        _map.CompressionLevel = compressionLevel;
        return this;
    }

    public TiledMapBuilder SetDimensions(int width, int height)
    {
        _map.Width = width;
        _map.Height = height;
        return this;
    }

    public TiledMapBuilder SetTileDimensions(int width, int height)
    {
        _map.TileWidth = width;
        _map.TileHeight = height;
        return this;
    }

    public TiledMapBuilder SetHexSideLength(int hexSideLength)
    {
        _map.HexSideLength = hexSideLength;
        return this;
    }

    public TiledMapBuilder SetStaggerAxis(StaggerAxis staggerAxis)
    {
        _map.StaggerAxis = staggerAxis;
        return this;
    }

    public TiledMapBuilder SetStaggerIndex(StaggerIndex staggerIndex)
    {
        _map.StaggerIndex = staggerIndex;
        return this;
    }

    public TiledMapBuilder SetParallaxOrigin(int originX, int originY)
    {
        _map.ParallaxOriginX = originX;
        _map.ParallaxOriginY = originY;
        return this;
    }

    public TiledMapBuilder SetBackgroundColor(string backgroundColor)
    {
        _map.BackgroundColor = backgroundColor;
        return this;
    }

    public TiledMapBuilder SetNextLayerId(int nextLayerId)
    {
        _map.NextLayerId = nextLayerId;
        return this;
    }

    public TiledMapBuilder SetNextObjectId(int nextObjectId)
    {
        _map.NextObjectId = nextObjectId;
        return this;
    }

    public TiledMapBuilder SetInfinite(bool infinite)
    {
        _map.Infinite = infinite;
        return this;
    }

    public TiledMapBuilder SetTileset(Tileset tileset)
    {
        return SetTilesets(new() { tileset });
    }

    public TiledMapBuilder SetTilesets(List<Tileset> tilesets)
    {
        _map.Tilesets = tilesets;
        return this;
    }

    public TiledMapBuilder AddTileset(Tileset tileset)
    {
        _map.Tilesets.Add(tileset);
        return this;
    }

    public TiledMapBuilder SetTileLayer(TileLayer tileLayer)
    {
        return SetTileLayers(new() { tileLayer });
    }

    public TiledMapBuilder SetTileLayers(List<TileLayer> tileLayers)
    {
        _map.TileLayers = tileLayers;
        return this;
    }

    public TiledMapBuilder AddTileLayer(TileLayer tileLayer)
    {
        _map.TileLayers.Add(tileLayer);
        return this;
    }
    public TiledMapBuilder SetObjectLayer(ObjectLayer objectLayer)
    {
        return SetObjectLayers(new() { objectLayer });
    }

    public TiledMapBuilder SetObjectLayers(List<ObjectLayer> objectLayers)
    {
        _map.ObjectLayers = objectLayers;
        return this;
    }

    public TiledMapBuilder AddObjectLayer(ObjectLayer objectLayer)
    {
        _map.ObjectLayers.Add(objectLayer);
        return this;
    }

    public TiledMap Build()
    {
        return _map;
    }
}