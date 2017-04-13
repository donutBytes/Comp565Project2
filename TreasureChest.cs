#region Using Statements
using System;
using System.IO;  // needed for trace()'s fout
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

namespace AGMGSKv8
{
    public struct TreasureNode
    {
        public float x;
        public float z;
        public bool tagged;

        public TreasureNode(float x, float z, bool tagged)
        {
            this.x = x;
            this.z = z;
            this.tagged = tagged;
        }
    }

    public class TreasureChest : Model3D
    {
        private TreasureNode[] treasureNode;

        public TreasureChest(Stage theStage, string label, string meshFile)
            : base(theStage, label, meshFile)
        { initTreasureChest(); }


        public void initTreasureChest()
        {
            isCollidable = true;

            //Treasure locations
            int[,] treasure = {
                {400,430},
                {810,800},
                {710,720},
                {547,553},
            };

            //Create Treasures at all locations
            this.treasureNode = new TreasureNode[treasure.GetLength(0)];
            int x, z;

            for (int i = 0; i < treasure.GetLength(0); i++)
            {
                //Positions
                x = treasure[i, 0];
                z = treasure[i, 1];

                this.treasureNode[i].x = x;
                this.treasureNode[i].z = z;
                this.treasureNode[i].tagged = false;

                addObject(new Vector3(x * stage.Spacing, stage.Terrain.surfaceHeight(x, z), z * stage.Spacing),
                        new Vector3(0, 1, 0),
                        0.0f,
                        new Vector3(1, 1, 1));
            }
        }

        public TreasureNode[] getTreasureNode
        {
            get { return this.treasureNode; }
        }
    }

}
