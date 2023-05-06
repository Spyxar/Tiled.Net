using TiledNet.Enums;
using TiledNet.Models;
using TiledNet.Models.Layers;

namespace TiledNetTests;

public class LayerDataTests
{
    /// <summary>
    /// Tests a legit scenario of layer data formatted with base64 and compressed with GZip
    /// </summary>
    [Test]
    public void TestLegitBase64GZipCompressedData()
    {
        TiledMap map = MapStringParser.LoadMapFromString("""
        <map>
            <layer id="2" name="Tile Layer 1" width="8" height="8">
                <data encoding="base64" compression="gzip">
                    H4sIAAAAAAAACmNkYGBgAmJmIGYBYlYgZgNidiDmgIoPZwwAqcpv/AABAAA=
                </data>
            </layer>
        </map>
        """);
        foreach (TileLayer tileLayer in map.TileLayers)
        {
            Assert.Multiple(() =>
            {
                Assert.That(tileLayer.Data.DataEncodingType, Is.EqualTo(DataEncodingType.Base64));
                Assert.That(tileLayer.Data.DataCompressionType, Is.EqualTo(DataCompressionType.GZip));
                Assert.That(tileLayer.Data.ConvertRawTileData(), Has.Length.EqualTo(64));
                CollectionAssert.IsSubsetOf(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, tileLayer.Data.ConvertRawTileData());
            });
        }
    }

    /// <summary>
    /// Tests a legit scenario of layer data formatted with base64 and compressed with ZLib
    /// </summary>
    [Test]
    public void TestLegitBase64ZLibCompressedData()
    {
        TiledMap map = MapStringParser.LoadMapFromString("""
        <map>
            <layer id="2" name="Tile Layer 1" width="8" height="8">
                <data encoding="base64" compression="zlib">
                    eJxjZGBgYAJiZiBmAWJWIGYDYnYg5oCKD2cMAG0wAM0=
                </data>
            </layer>
        </map>
        """);
        foreach (TileLayer tileLayer in map.TileLayers)
        {
            Assert.Multiple(() =>
            {
                Assert.That(tileLayer.Data.DataEncodingType, Is.EqualTo(DataEncodingType.Base64));
                Assert.That(tileLayer.Data.DataCompressionType, Is.EqualTo(DataCompressionType.ZLib));
                Assert.That(tileLayer.Data.ConvertRawTileData(), Has.Length.EqualTo(64));
                CollectionAssert.IsSubsetOf(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, tileLayer.Data.ConvertRawTileData());
            });
        }
    }
}