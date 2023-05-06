namespace TiledNet.Models;

/// <summary>
/// A rectangle object representing the source rectangle of a tile on an image
/// </summary>
public class TileImageRectangle
{
    public static readonly TileImageRectangle Empty = new(null, 0, 0, 0, 0);

    public TileImageRectangle(Tileset tileset, int x, int y, int width, int height)
    {
        Tileset = tileset;
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public Tileset Tileset { get; set; }

    public int X { get; set; }
    public int Y { get; set; }

    public int Width { get; set; }
    public int Height { get; set; }
}