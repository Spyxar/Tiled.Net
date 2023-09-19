using TiledNet.Enums;
using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class ObjectLayerBuilder
{
    private readonly ObjectLayer _objectLayer = new();

    public ObjectLayerBuilder SetId(int id)
    {
        _objectLayer.Id = id;
        return this;
    }

    public ObjectLayerBuilder SetName(string name)
    {
        _objectLayer.Name = name;
        return this;
    }

    public ObjectLayerBuilder SetClass(string @class)
    {
        _objectLayer.Class = @class;
        return this;
    }

    public ObjectLayerBuilder SetColor(string color)
    {
        _objectLayer.Color = color;
        return this;
    }

    public ObjectLayerBuilder SetPosition(int x, int y)
    {
        _objectLayer.X = x;
        _objectLayer.Y = y;
        return this;
    }

    public ObjectLayerBuilder SetDimensions(int width, int height)
    {
        _objectLayer.Width = width;
        _objectLayer.Height = height;
        return this;
    }

    public ObjectLayerBuilder SetOpacity(float opacity)
    {
        _objectLayer.Opacity = opacity;
        return this;
    }

    public ObjectLayerBuilder SetVisible(bool visible)
    {
        _objectLayer.Visible = visible;
        return this;
    }

    public ObjectLayerBuilder SetTintColor(string tintColor)
    {
        _objectLayer.TintColor = tintColor;
        return this;
    }

    public ObjectLayerBuilder SetOffset(int offsetX, int offsetY)
    {
        _objectLayer.OffsetX = offsetX;
        _objectLayer.OffsetY = offsetY;
        return this;
    }

    public ObjectLayerBuilder SetParallax(int parallaxX, int parallaxY)
    {
        _objectLayer.ParallaxX = parallaxX;
        _objectLayer.ParallaxY = parallaxY;
        return this;
    }

    public ObjectLayerBuilder SetDrawOrder(DrawOrder drawOrder)
    {
        _objectLayer.DrawOrder = drawOrder;
        return this;
    }

    public ObjectLayerBuilder SetObject(ObjectLayerObject @object)
    {
        return SetObjects(new() { @object });
    }

    public ObjectLayerBuilder SetObjects(List<ObjectLayerObject> @object)
    {
        _objectLayer.Objects = @object;
        return this;
    }

    public ObjectLayerBuilder AddObject(ObjectLayerObject @object)
    {
        _objectLayer.Objects.Add(@object);
        return this;
    }

    public ObjectLayer Build()
    {
        return _objectLayer;
    }
}