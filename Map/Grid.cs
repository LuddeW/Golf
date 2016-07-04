using Golf.GameObjects;
using Golf.GameObjects.Tiles;
using Golf.Globals;
using Golf.Managers;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Golf.Map
{
    class Grid
    {
        public Tile[,] grid;
        public List<Tile> tiles = new List<Tile>();
        public List<Ball> balls = new List<Ball>();
        public Vector2 ballStartPos;

        public void CreateGrid()
        {
            StreamReader sr = new StreamReader(@"Level1.txt");
            List<string> stringList = new List<string>();
            while (!sr.EndOfStream)
            {
                stringList.Add(sr.ReadLine());
            }
            grid = new Tile[GlobalValues.HOLE_LENGTH / GlobalValues.TILE_SIZE, GlobalValues.HOLE_HEIGHT / GlobalValues.TILE_SIZE];
            for (int i = 0; i < GlobalValues.HOLE_HEIGHT / GlobalValues.TILE_SIZE; i++)
            {
                var line = stringList[i];               
                for (int k = 0; k < GlobalValues.HOLE_LENGTH / GlobalValues.TILE_SIZE && k < line.Length; k++)
                {
                    switch (line[k])
                    {
                        case 'G':
                            grid[k, i] = new GreenTile(TextureLibrary.green, new Vector2(k*GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'F':
                            grid[k, i] = new FairwayTile(TextureLibrary.fairway, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'R':
                            grid[k, i] = new RoughTile(TextureLibrary.rough, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'C':
                            grid[k, i] = new CupTile(TextureLibrary.cup, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'B':
                            grid[k, i] = new BunkerTile(TextureLibrary.bunker, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'S':
                            grid[k, i] = new StoneTile(TextureLibrary.stone, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'W':
                            grid[k, i] = new WaterTile(TextureLibrary.water, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'M':
                            grid[k, i] = new MudTile(TextureLibrary.mud, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'P':
                            grid[k, i] = new FlagStickTile(TextureLibrary.flagpost, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'Q':
                            grid[k, i] = new FlagTile(TextureLibrary.flag, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            tiles.Add(grid[k, i]);
                            break;
                        case 'X':
                            ballStartPos = new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE);
                            break;
                    }
                }
            }
        }
    }
}
