using System.Xml.Serialization;

namespace TiledNet.Models;

/// <summary>
/// If inherited the child class supports custom properties
/// </summary>
public abstract class PropertyHolder
{
    [XmlArray("properties")]
    [XmlArrayItem("property")]
    public Property[] Properties;

    /// <summary>
    /// Gets a property as a string, if you need a different type either use <see cref="GetProperty{T}(string)"/> or cast the return value
    /// </summary>
    /// <param name="name">The name of the property</param>
    /// <returns>The property that matches <paramref name="name"/></returns>
    public string GetProperty(string name)
    {
        return Properties.First(p => p.Name == name).Value;
    }

    /// <summary>
    /// Gets a property as type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The type of the property</typeparam>
    /// <param name="name">The name of the property</param>
    /// <returns>The property that matches <paramref name="name"/> as type <typeparamref name="T"/></returns>
    public T GetProperty<T>(string name)
    {
        string value = GetProperty(name);
        return (T)Convert.ChangeType(value, typeof(T));
    }

    /// <summary>
    /// Gets all properties
    /// </summary>
    /// <returns>A Dictionary containing all properties, the key is the property name, the value the property value</returns>
    public Dictionary<string, string> GetAllProperties()
    {
        return Properties.ToDictionary(p => p.Name, p => p.Value);
    }
}