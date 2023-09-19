using TiledNet.Enums;
using TiledNet.Models;

namespace TiledNet.Builders;

public class TilesetBuilder
{
    private readonly Tileset _tileset = new();

    public TilesetBuilder SetFirstGid(int gid)
    {
        _tileset.FirstGid = gid;
        return this;
    }

    public TilesetBuilder SetSource(string source)
    {
        _tileset.Source = source;
        return this;
    }

    public TilesetBuilder SetName(string name)
    {
        _tileset.Name = name;
        return this;
    }

    public TilesetBuilder SetClass(string @class)
    {
        _tileset.Class = @class;
        return this;
    }

    public TilesetBuilder SetTileDimensions(int tileWidth, int tileHeight)
    {
        _tileset.TileWidth = tileWidth;
        _tileset.TileHeight = tileHeight;
        return this;
    }

    public TilesetBuilder SetSpacing(int spacing)
    {
        _tileset.Spacing = spacing;
        return this;
    }

    public TilesetBuilder SetMargin(int margin)
    {
        _tileset.Margin = margin;
        return this;
    }

    public TilesetBuilder SetTileCount(int tileCount)
    {
        _tileset.TileCount = tileCount;
        return this;
    }

    public TilesetBuilder SetColumns(int columns)
    {
        _tileset.Columns = columns;
        return this;
    }

    public TilesetBuilder SetObjectAlignment(TilesetObjectAlignment alignment)
    {
        _tileset.ObjectAlignment = alignment;
        return this;
    }

    public TilesetBuilder SetTileRenderSize(TileRenderSize tileRenderSize)
    {
        _tileset.TileRenderSize = tileRenderSize;
        return this;
    }

    public TilesetBuilder SetTilesetFillMode(TilesetFillMode tilesetFillMode)
    {
        _tileset.TilesetFillMode = tilesetFillMode;
        return this;
    }

    public TilesetBuilder SetTiledImage(TiledImage image)
    {
        _tileset.Image = image;
        return this;
    }

    public TilesetBuilder SetTileOffset(TilesetTileOffset offset)
    {
        _tileset.TileOffset = offset;
        return this;
    }

    public TilesetBuilder SetTilesetGrid(TilesetGrid grid)
    {
        _tileset.Grid = grid;
        return this;
    }

    public TilesetBuilder SetTile(TilesetTile tile)
    {
        return SetTiles(new() { tile });
    }

    public TilesetBuilder SetTiles(List<TilesetTile> tiles)
    {
        _tileset.Tiles = tiles;
        return this;
    }

    public TilesetBuilder AddTile(TilesetTile tile)
    {
        _tileset.Tiles.Add(tile);
        return this;
    }

    public Tileset Build()
    {
        return _tileset;
    }
}