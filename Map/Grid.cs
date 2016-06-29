using Golf.GameObjects;
using Golf.GameObjects.Tiles;
using Golf.Globals;
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
        public List<GameObject> gameObjects = new List<GameObject>();

        public void CreateGrid()
        {
            StreamReader sr = new StreamReader(@"Level1.txt");
            List<string> stringList = new List<string>();
            while (!sr.EndOfStream)
            {
                stringList.Add(sr.ReadLine());
            }
            grid = new Tile[40, 24];
            for (int i = 0; i < 24; i++)
            {
                var line = stringList[i];               
                for (int k = 0; k < 40 && k < line.Length; k++)
                {
                    switch (line[k])
                    {
                        case 'G':
                            grid[k, i] = new GreenTile(TextureLibrary.green, new Vector2(k*GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            gameObjects.Add(grid[k, i]);
                            break;
                        case 'F':
                            grid[k, i] = new FairwayTile(TextureLibrary.fairway, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            gameObjects.Add(grid[k, i]);
                            break;
                        case 'R':
                            grid[k, i] = new RoughTile(TextureLibrary.rough, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            gameObjects.Add(grid[k, i]);
                            break;
                        case 'C':
                            grid[k, i] = new CupTile(TextureLibrary.cup, new Vector2(k * GlobalValues.TILE_SIZE, i * GlobalValues.TILE_SIZE));
                            gameObjects.Add(grid[k, i]);
                            break;
                    }
                }
            }
        }
    }
}
