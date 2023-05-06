using System.Xml.Serialization;
using TiledNet.Enums;

namespace TiledNet.Models;

/// <summary>
/// Generic property that can be used in any class inheriting <see cref="PropertyHolder"/>
/// </summary>
public class Property
{
    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("type")]
    public PropertyType Type;

    [XmlAttribute("propertytype")]
    public string PropertyType;

    [XmlAttribute("value")]
    public string Value;
}