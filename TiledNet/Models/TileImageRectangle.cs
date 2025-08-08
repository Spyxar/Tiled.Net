namespace TiledNet.Models;

/// <summary>
/// A rectangle object representing the source rectangle of a tile on an image
/// </summary>
public class TileImageRectangle(Tileset tileset, int x, int y, int width, int height)
{
    public static readonly TileImageRectangle Empty = new(null, 0, 0, 0, 0);

    public Tileset Tileset { get; set; } = tileset;

    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public int Width { get; set; } = width;
    public int Height { get; set; } = height;
}