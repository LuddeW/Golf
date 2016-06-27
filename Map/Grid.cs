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

        public void CreateGridFactory()
        {
            StreamReader sr = new StreamReader(@"Level1.txt");
            List<string> stringList = new List<string>();
            while (!sr.EndOfStream)
            {
                stringList.Add(sr.ReadLine());
            }
            grid = new Tile[(int)GlobalValues.HOLE_LENGTH / GlobalValues.TILE_SIZE, (int)GlobalValues.HOLE_HEIGHT / GlobalValues.TILE_SIZE];
            for (int i = 0; i < GlobalValues.HOLE_LENGTH / GlobalValues.TILE_SIZE; i++)
            {
                for (int k = 0; k < GlobalValues.HOLE_HEIGHT / GlobalValues.TILE_SIZE; k++)
                {
                    switch (stringList[i][k])
                    {
                        case 'G':
                            grid[k, i] = new GreenTile(TextureLibrary.green, new Vector2(i, k));
                            gameObjects.Add(grid[i, k]);
                            break;
                        case 'F':
                            grid[k, i] = new FairwayTile(TextureLibrary.fairway, new Vector2(i, k));
                            gameObjects.Add(grid[i, k]);
                            break;
                        case 'R':
                            grid[k, i] = new RoughTile(TextureLibrary.rough, new Vector2(i, k));
                            gameObjects.Add(grid[i, k]);
                            break;
                        case 'C':
                            grid[k, i] = new CupTile(TextureLibrary.cup, new Vector2(i, k));
                            gameObjects.Add(grid[i, k]);
                            break;
                    }
                }
            }
        }
    }
}
