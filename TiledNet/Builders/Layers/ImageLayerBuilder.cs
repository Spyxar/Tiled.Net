using TiledNet.Models;
using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class ImageLayerBuilder
{
    private readonly ImageLayer _imageLayer = new();

    public ImageLayerBuilder SetId(int id)
    {
        _imageLayer.Id = id;
        return this;
    }

    public ImageLayerBuilder SetName(string name)
    {
        _imageLayer.Name = name;
        return this;
    }

    public ImageLayerBuilder SetClass(string @class)
    {
        _imageLayer.Class = @class;
        return this;
    }

    public ImageLayerBuilder SetOffset(int offsetX, int offsetY)
    {
        _imageLayer.OffsetX = offsetX;
        _imageLayer.OffsetY = offsetY;
        return this;
    }

    public ImageLayerBuilder SetParallax(int parallaxX, int parallaxY)
    {
        _imageLayer.ParallaxX = parallaxX;
        _imageLayer.ParallaxY = parallaxY;
        return this;
    }

    public ImageLayerBuilder SetPosition(int x, int y)
    {
        _imageLayer.X = x;
        _imageLayer.Y = y;
        return this;
    }

    public ImageLayerBuilder SetOpacity(float opacity)
    {
        _imageLayer.Opacity = opacity;
        return this;
    }

    public ImageLayerBuilder SetVisible(bool visible)
    {
        _imageLayer.Visible = visible;
        return this;
    }

    public ImageLayerBuilder SetTintColor(string tintColor)
    {
        _imageLayer.TintColor = tintColor;
        return this;
    }

    public ImageLayerBuilder SetRepeatX(bool repeatX)
    {
        _imageLayer.RepeatX = repeatX;
        return this;
    }

    public ImageLayerBuilder SetRepeatY(bool repeatY)
    {
        _imageLayer.RepeatY = repeatY;
        return this;
    }

    public ImageLayerBuilder SetImage(TiledImage image)
    {
        _imageLayer.Image = image;
        return this;
    }

    public ImageLayer Build()
    {
        return _imageLayer;
    }
}