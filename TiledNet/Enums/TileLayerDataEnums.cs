using System.Xml.Serialization;

namespace TiledNet.Enums;

public enum DataEncodingType
{
    [XmlEnum("base64")]
    Base64,
    [XmlEnum("csv")]
    Csv
}

public enum DataCompressionType
{
    Undefined,
    [XmlEnum("gzip")]
    GZip,
    [XmlEnum("zlib")]
    ZLib,
    [XmlEnum("zstd")]
    ZStandard
}