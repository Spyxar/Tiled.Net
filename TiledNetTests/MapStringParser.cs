using System.Xml.Serialization;
using TiledNet.Models;

namespace TiledNetTests;

public class MapStringParser
{
    /// <summary>
    /// Loads a <see cref="TiledMap"/> instance from the given string
    /// </summary>
    /// <param name="src">The string to parse the map from</param>
    /// <returns>The parsed TiledMap</returns>
    public static TiledMap LoadMapFromString(string src)
    {
        TextReader reader = new StringReader(src);

        TiledMap instance;
        XmlSerializer serializer = new(typeof(TiledMap));
        instance = (TiledMap)serializer.Deserialize(reader);
        return instance;
    }
}