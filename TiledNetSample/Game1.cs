using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TiledNet;
using TiledNet.Models;
using TiledNet.Models.Layers;

namespace MonoTesting;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
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
        _map = MapParser.LoadMapFromTmx("ExampleMap.xml");

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