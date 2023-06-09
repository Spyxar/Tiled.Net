﻿using TiledNet.Enums;
using TiledNet.Models;

namespace TiledNetTests;

public class MapTest
{
    /// <summary>
    /// Tests the attributes of a map tag, in a realistic scenario generated by Tiled
    /// </summary>
    [Test]
    public void TestLegitMapAttributes()
    {
        TiledMap map = MapStringParser.LoadMapFromString("""
        <map version="1.10" tiledversion="1.10.1" orientation="orthogonal" renderorder="right-down"
            width="8" height="8" tilewidth="16" tileheight="16"
            infinite="0" backgroundcolor="#2f9eff" nextlayerid="8" nextobjectid="4">
        </map>
        """);
        Assert.Multiple(() =>
        {
            Assert.That(map.Version, Is.EqualTo("1.10"));
            Assert.That(map.TiledVersion, Is.EqualTo("1.10.1"));
            Assert.That(map.Orientation, Is.EqualTo(MapOrientation.Orthogonal));
            Assert.That(map.RenderOrder, Is.EqualTo(RenderOrder.RightDown));
            Assert.That(map.Width, Is.EqualTo(8));
            Assert.That(map.Height, Is.EqualTo(8));
            Assert.That(map.TileWidth, Is.EqualTo(16));
            Assert.That(map.TileHeight, Is.EqualTo(16));
            Assert.That(map.Infinite, Is.EqualTo(false));
            Assert.That(map.BackgroundColor, Is.EqualTo("#2f9eff"));
            Assert.That(map.NextLayerId, Is.EqualTo(8));
            Assert.That(map.NextObjectId, Is.EqualTo(4));
        });
    }

    /// <summary>
    /// Tests all attributes that a map could ever have, this is a theoretical scenario
    /// </summary>
    [Test]
    public void TestAllPossibleMapAttributes()
    {
        TiledMap map = MapStringParser.LoadMapFromString("""
        <map version="1.10" tiledversion="1.10.1" class="testclass" orientation="orthogonal" renderorder="right-down"
            width="8" height="8" tilewidth="16" tileheight="16"
            hexsidelength="4" staggeraxis="y" staggerindex="odd"
            parallaxoriginx="50" parallaxoriginy="55" backgroundcolor="#2f9eff"
            infinite="0" nextlayerid="8" nextobjectid="4">
        </map>
        """);
        Assert.Multiple(() =>
        {
            Assert.That(map.Version, Is.EqualTo("1.10"));
            Assert.That(map.TiledVersion, Is.EqualTo("1.10.1"));
            Assert.That(map.Class, Is.EqualTo("testclass"));
            Assert.That(map.Orientation, Is.EqualTo(MapOrientation.Orthogonal));
            Assert.That(map.RenderOrder, Is.EqualTo(RenderOrder.RightDown));
            Assert.That(map.CompressionLevel, Is.EqualTo(-1));
            Assert.That(map.Width, Is.EqualTo(8));
            Assert.That(map.Height, Is.EqualTo(8));
            Assert.That(map.TileWidth, Is.EqualTo(16));
            Assert.That(map.TileHeight, Is.EqualTo(16));
            Assert.That(map.HexSideLength, Is.EqualTo(4));
            Assert.That(map.StaggerAxis, Is.EqualTo(StaggerAxis.Y));
            Assert.That(map.StaggerIndex, Is.EqualTo(StaggerIndex.Odd));
            Assert.That(map.ParallaxOriginX, Is.EqualTo(50));
            Assert.That(map.ParallaxOriginY, Is.EqualTo(55));
            Assert.That(map.BackgroundColor, Is.EqualTo("#2f9eff"));
            Assert.That(map.NextLayerId, Is.EqualTo(8));
            Assert.That(map.NextObjectId, Is.EqualTo(4));
            Assert.That(map.Infinite, Is.EqualTo(false));
        });
    }

    /// <summary>
    /// Simple test that tests the number of elements inside a map tag, mainly to make sure both annotation types work
    /// </summary>
    [Test]
    public void TestNumberOfMapElements()
    {
        TiledMap map = MapStringParser.LoadMapFromString("""
        <map>
            <tileset></tileset>
            <tileset/>
            <layer></layer>
            <layer/>
            <objectgroup></objectgroup>
            <objectgroup/>
            <imagelayer></imagelayer>
            <imagelayer/>
            <group></group>
            <group/>
        </map>
        """);
        Assert.Multiple(() =>
        {
            Assert.That(map.Tilesets.Count, Is.EqualTo(2));
            Assert.That(map.TileLayers.Count, Is.EqualTo(2));
            Assert.That(map.ObjectLayers.Count, Is.EqualTo(2));
            Assert.That(map.ImageLayers.Count, Is.EqualTo(2));
            Assert.That(map.GroupLayers.Count, Is.EqualTo(2));
        });
    }
}