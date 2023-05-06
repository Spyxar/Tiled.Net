using System.Xml.Serialization;
using TiledNet.Enums;
using TiledNet.Exceptions;

namespace TiledNet.Models.Layers;

/// <summary>
/// Represents the data tag inside of a <see cref="TileLayer"/>
/// </summary>
public class TileLayerData
{
    [XmlAttribute("encoding")]
    public DataEncodingType DataEncodingType;

    [XmlAttribute("compression")]
    public DataCompressionType DataCompressionType;

    [XmlText]
    public string RawTileData;

    [XmlElement("chunk")]
    public TileLayerDataChunk[] Chunks;

    [XmlElement("tile")]
    public TileLayerDataTile[] Tiles;

    public int[] ConvertRawTileData()
    {
        if (DataEncodingType == DataEncodingType.Csv)
        {
            return RawTileData.Split(",").Select(x => int.Parse(x.ToString())).ToArray();
        }
        else if (DataEncodingType == DataEncodingType.Base64)
        {
            byte[] rawData = Convert.FromBase64String(RawTileData);
            if (DataCompressionType == DataCompressionType.GZip)
            {
                rawData = DecompressionUtils.DecompressGZip(rawData);
            }
            else if (DataCompressionType == DataCompressionType.ZLib)
            {
                rawData = DecompressionUtils.DecompressZLib(rawData);
            }
            //ToDo: Support ztsd
            else if (DataCompressionType == DataCompressionType.ZStandard)
            {
                throw new NotImplementedException();
            }
            int[] ints = new int[rawData.Length / 4];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = BitConverter.ToInt32(rawData, i * 4);
            }
            return ints;
        }
        throw new UnknownDataEncodingException();
    }
}

public class TileLayerDataChunk
{
    [XmlAttribute("x")]
    public int X;
    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("width")]
    public int Width;
    [XmlAttribute("height")]
    public int Height;

    [XmlElement("tile")]
    public TileLayerDataTile[] Tiles;
}

/// <summary>
/// Not to be confused with <see cref="TilesetTile"/>, this object represents a single tile on a tile layer
/// </summary>
public class TileLayerDataTile
{
    [XmlAttribute("gid")]
    public int Gid;
}