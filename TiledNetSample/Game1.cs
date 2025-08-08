using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TiledNet;
using TiledNet.Builders;
using TiledNet.Builders.Layers;
using TiledNet.Enums;
using TiledNet.Models;
using TiledNet.Models.Layers;

namespace TiledNetSample;

public class Game1 : Game
{
    private readonly GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        IsMouseVisible = true;
        Content.RootDirectory = "Content";
    }

    TiledMap _map;

    protected override void Initialize()
    {
        //You can either load a map from file, or create your own programmatically
        _map = MapParser.LoadMapFromTmx("ExampleMap.xml");

        _map = new TiledMapBuilder()
            .AddTileset(new TilesetBuilder().SetFirstGid(5).SetTileDimensions(16, 16).SetName("A").SetTileCount(4).SetColumns(2).SetTiledImage(new TiledImage("", "ExtraColorTiles.png", "", 32, 32)).Build())
            .AddTileset(new TilesetBuilder().SetFirstGid(11).SetTileDimensions(16, 16).SetName("test").SetTileCount(4).SetColumns(2).SetTiledImage(new TiledImage("", "BaseColorTiles.png", "", 32, 32)).Build())
            .AddTileLayer(new TileLayerBuilder()
                .SetDimensions(8, 8)
                .SetTileLayerData(new TileLayerDataBuilder()
                    .SetDataEncodingType(DataEncodingType.Csv)
                    .SetRawTileData("1,2,3,4,5,6,7,8,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3")
                    .Build())
                .Build())
            .Build();

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Gray);

        _spriteBatch.Begin();

        foreach (TileLayer tileLayer in _map.TileLayers)
        {
            int[] tileGids = tileLayer.Data.ConvertRawTileData();
            for (int i = 0; i < tileGids.Length; i++)
            {
                int tileGid = tileGids[i];
                if (tileGid == 0)
                {
                    continue;
                }

                TileImageRectangle tileImage = _map.GetTileImage(tileGid);
                Rectangle sourceRectangle = new(tileImage.X, tileImage.Y, tileImage.Width, tileImage.Height);

                int tileX = (i % tileLayer.Width) * tileImage.Width;
                int tileY = (i / tileLayer.Height) * tileImage.Height;
                Vector2 position = new(tileX, tileY);

                _spriteBatch.Draw(Content.Load<Texture2D>($"{tileImage.Tileset.Image.Source.Replace(".png", "")}"), position, sourceRectangle, Color.White);
            }
        }

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}