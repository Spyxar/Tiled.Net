using System.Xml.Serialization;
using TiledNet.Models;

namespace TiledNet;

/// <summary>
/// Tasked with parsing a TMX file
/// </summary>
public class MapParser
{
    /// <summary>
    /// Loads and returns a <see cref="TiledMap"/> instance
    /// </summary>
    /// <param name="path">The path where the TMX file can be found</param>
    /// <returns>A <see cref="TiledMap"/> parsed from the given path</returns>
    public static TiledMap LoadMapFromTmx(string path)
    {
        TiledMap instance;
        using (TextReader reader = new StreamReader(path))
        {
            XmlSerializer serializer = new(typeof(TiledMap));
            instance = (TiledMap)serializer.Deserialize(reader);
        }
        return instance;
    }
}