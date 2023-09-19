using TiledNet.Enums;
using TiledNet.Models.Layers;

namespace TiledNet.Builders.Layers;

public class TileLayerDataBuilder
{
    private readonly TileLayerData _tileLayerData = new();

    public TileLayerDataBuilder SetDataEncodingType(DataEncodingType dataEncodingType)
    {
        _tileLayerData.DataEncodingType = dataEncodingType;
        return this;
    }

    public TileLayerDataBuilder SetCompressionType(DataCompressionType dataCompressionType)
    {
        _tileLayerData.DataCompressionType = dataCompressionType;
        return this;
    }

    public TileLayerDataBuilder SetRawTileData(string rawTileData)
    {
        _tileLayerData.RawTileData = rawTileData;
        return this;
    }

    public TileLayerDataBuilder SetChunk(TileLayerDataChunk chunk)
    {
        return SetChunks(new() { chunk });
    }

    public TileLayerDataBuilder SetChunks(List<TileLayerDataChunk> chunks)
    {
        _tileLayerData.Chunks = chunks;
        return this;
    }

    public TileLayerDataBuilder AddChunk(TileLayerDataChunk chunk)
    {
        _tileLayerData.Chunks.Add(chunk);
        return this;
    }

    public TileLayerDataBuilder SetTile(TileLayerDataTile tile)
    {
        return SetTiles(new() { tile });
    }

    public TileLayerDataBuilder SetTiles(List<TileLayerDataTile> tiles)
    {
        _tileLayerData.Tiles = tiles;
        return this;
    }

    public TileLayerDataBuilder AddTile(TileLayerDataTile tile)
    {
        _tileLayerData.Tiles.Add(tile);
        return this;
    }

    public TileLayerData Build()
    {
        return _tileLayerData;
    }
}