using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class ObjectLayerObjectBuilder
{
    private readonly ObjectLayerObject _object = new();

    public ObjectLayerObjectBuilder SetId(int id)
    {
        _object.Id = id;
        return this;
    }

    public ObjectLayerObjectBuilder SetName(string name)
    {
        _object.Name = name;
        return this;
    }

    public ObjectLayerObjectBuilder SetType(string type)
    {
        _object.Type = type;
        return this;
    }

    public ObjectLayerObjectBuilder SetPosition(int x, int y)
    {
        _object.X = x;
        _object.Y = y;
        return this;
    }

    public ObjectLayerObjectBuilder SetDimensions(int width, int height)
    {
        _object.Width = width;
        _object.Height = height;
        return this;
    }

    public ObjectLayerObjectBuilder SetRotation(float rotation)
    {
        _object.Rotation = rotation;
        return this;
    }
    
    public ObjectLayerObjectBuilder SetGid(int gid)
    {
        _object.Gid = gid;
        return this;
    }

    public ObjectLayerObjectBuilder SetVisible(bool visible)
    {
        _object.Visible = visible;
        return this;
    }

    public ObjectLayerObjectBuilder SetTemplate(string template)
    {
        _object.Template = template;
        return this;
    }
    
    public ObjectLayerObjectBuilder SetEllipse()
    {
        _object.Ellipse = new EllipseObject();
        return this;
    }

    public ObjectLayerObjectBuilder SetPoint()
    {
        _object.Point = new PointObject();
        return this;
    }

    public ObjectLayerObjectBuilder SetText(TextObject text)
    {
        _object.Text = text;
        return this;
    }

    public ObjectLayerObject Build()
    {
        return _object;
    }
}