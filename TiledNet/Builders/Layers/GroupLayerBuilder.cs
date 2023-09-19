using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class GroupLayerBuilder
{
    private readonly GroupLayer _groupLayer = new();

    public GroupLayerBuilder SetId(int id)
    {
        _groupLayer.Id = id;
        return this;
    }

    public GroupLayerBuilder SetName(string name)
    {
        _groupLayer.Name = name;
        return this;
    }

    public GroupLayerBuilder SetClass(string @class)
    {
        _groupLayer.Class = @class;
        return this;
    }

    public GroupLayerBuilder SetOffset(int offsetX, int offsetY)
    {
        _groupLayer.OffsetX = offsetX;
        _groupLayer.OffsetY = offsetY;
        return this;
    }

    public GroupLayerBuilder SetParallax(int parallaxX, int parallaxY)
    {
        _groupLayer.ParallaxX = parallaxX;
        _groupLayer.ParallaxY = parallaxY;
        return this;
    }

    public GroupLayerBuilder SetOpacity(float opacity)
    {
        _groupLayer.Opacity = opacity;
        return this;
    }

    public GroupLayerBuilder SetVisible(bool visible)
    {
        _groupLayer.Visible = visible;
        return this;
    }

    public GroupLayerBuilder SetTintColor(string tintColor)
    {
        _groupLayer.TintColor = tintColor;
        return this;
    }

    public GroupLayerBuilder SetTileLayer(TileLayer tileLayer)
    {
        return SetTileLayers(new() { tileLayer });
    }

    public GroupLayerBuilder SetTileLayers(List<TileLayer> tileLayers)
    {
        _groupLayer.TileLayers = tileLayers;
        return this;
    }

    public GroupLayerBuilder AddTileLayer(TileLayer tileLayer)
    {
        _groupLayer.TileLayers.Add(tileLayer);
        return this;
    }

    public GroupLayerBuilder SetObjectLayer(ObjectLayer objectLayer)
    {
        return SetObjectLayers(new() { objectLayer });
    }

    public GroupLayerBuilder SetObjectLayers(List<ObjectLayer> objectLayers)
    {
        _groupLayer.ObjectLayers = objectLayers;
        return this;
    }

    public GroupLayerBuilder AddObjectLayer(ObjectLayer objectLayer)
    {
        _groupLayer.ObjectLayers.Add(objectLayer);
        return this;
    }

    public GroupLayerBuilder SetImageLayer(ImageLayer imageLayer)
    {
        return SetImageLayers(new() { imageLayer });
    }

    public GroupLayerBuilder SetImageLayers(List<ImageLayer> imageLayers)
    {
        _groupLayer.ImageLayers = imageLayers;
        return this;
    }

    public GroupLayerBuilder AddImageLayer(ImageLayer imageLayer)
    {
        _groupLayer.ImageLayers.Add(imageLayer);
        return this;
    }

    public GroupLayerBuilder SetGroupLayer(GroupLayer groupLayer)
    {
        return SetGroupLayers(new() { groupLayer });
    }

    public GroupLayerBuilder SetGroupLayers(List<GroupLayer> groupLayers)
    {
        _groupLayer.GroupLayers = groupLayers;
        return this;
    }

    public GroupLayerBuilder AddGroupLayer(GroupLayer groupLayer)
    {
        _groupLayer.GroupLayers.Add(groupLayer);
        return this;
    }

    public GroupLayer Build()
    {
        return _groupLayer;
    }
}