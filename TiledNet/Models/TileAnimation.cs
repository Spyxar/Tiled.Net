using System.Xml.Serialization;

namespace TiledNet.Models;

public class TileAnimation
{
    [XmlElement("frame")]
    public TileAnimationFrame[] AnimationFrames;
}

public class TileAnimationFrame
{
    [XmlAttribute("tileid")]
    public int TileId;

    [XmlAttribute("duration")]
    public int FrameDuration;
}