using System.Xml.Serialization;

namespace TiledNet.Models;

public class TileAnimation
{
    [XmlElement("frame")]
    public List<TileAnimationFrame> AnimationFrames = new();

    public TileAnimation() { }

    public TileAnimation(List<TileAnimationFrame> animationFrames)
    {
        AnimationFrames = animationFrames;
    }
}

public class TileAnimationFrame
{
    [XmlAttribute("tileid")]
    public int TileId;

    [XmlAttribute("duration")]
    public int FrameDuration;

    public TileAnimationFrame() { }

    public TileAnimationFrame(int tileId, int frameDuration)
    {
        TileId = tileId;
        FrameDuration = frameDuration;
    }
}