using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class TileLayerBuilder
{
    private readonly TileLayer _tileLayer = new();

    public TileLayerBuilder SetId(int id)
    {
        _tileLayer.Id = id;
        return this;
    }

    public TileLayerBuilder SetName(string name)
    {
        _tileLayer.Name = name;
        return this;
    }

    public TileLayerBuilder SetClass(string @class)
    {
        _tileLayer.Class = @class;
        return this;
    }

    public TileLayerBuilder SetPosition(int x, int y)
    {
        _tileLayer.X = x;
        _tileLayer.Y = y;
        return this;
    }

    public TileLayerBuilder SetDimensions(int width, int height)
    {
        _tileLayer.Width = width;
        _tileLayer.Height = height;
        return this;
    }

    public TileLayerBuilder SetOpacity(float opacity)
    {
        _tileLayer.Opacity = opacity;
        return this;
    }

    public TileLayerBuilder SetVisible(bool visible)
    {
        _tileLayer.Visible = visible;
        return this;
    }

    public TileLayerBuilder SetTintColor(string tintColor)
    {
        _tileLayer.TintColor = tintColor;
        return this;
    }

    public TileLayerBuilder SetOffset(int offsetX, int offsetY)
    {
        _tileLayer.OffsetX = offsetX;
        _tileLayer.OffsetY = offsetY;
        return this;
    }

    public TileLayerBuilder SetParallax(int parallaxX, int parallaxY)
    {
        _tileLayer.ParallaxX = parallaxX;
        _tileLayer.ParallaxY = parallaxY;
        return this;
    }

    public TileLayerBuilder SetTileLayerData(TileLayerData data)
    {
        _tileLayer.Data = data;
        return this;
    }

    public TileLayer Build()
    {
        return _tileLayer;
    }
}