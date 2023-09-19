using TiledNet.Models;
using TiledNet.Models.Layers;

namespace TiledNet.Builders;

public class TilesetTileBuilder
{
    private readonly TilesetTile _tile = new();

    public TilesetTileBuilder SetId(int id)
    {
        _tile.Id = id;
        return this;
    }

    public TilesetTileBuilder SetClass(string @class)
    {
        _tile.Class = @class;
        return this;
    }

    public TilesetTileBuilder SetProbability(string probability)
    {
        _tile.Probability = probability;
        return this;
    }

    public TilesetTileBuilder SetPosition(int x, int y)
    {
        _tile.X = x;
        _tile.Y = y;
        return this;
    }

    public TilesetTileBuilder SetDimensions(int width, int height)
    {
        _tile.Width = width;
        _tile.Height = height;
        return this;
    }

    public TilesetTileBuilder SetImage(TiledImage image)
    {
        _tile.Image = image;
        return this;
    }

    public TilesetTileBuilder SetObjectGroup(ObjectLayer objectLayer)
    {
        _tile.ObjectGroup = objectLayer;
        return this;
    }

    public TilesetTileBuilder SetAnimation(TileAnimation animation)
    {
        _tile.Animation = animation;
        return this;
    }

    public TilesetTile Build()
    {
        return _tile;
    }
}