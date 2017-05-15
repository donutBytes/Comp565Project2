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
        public Vector3 position;
        public bool tagged;

        public TreasureNode(Vector3 position, bool tagged)
        {
            this.position = position;
            this.tagged = tagged;
        }
    }

    public class TreasureChest : Model3D
    {
        private TreasureNode treasureNode;

        protected Vector3 position;

        protected Object3D treasureObject = null;
        
        //private bool tagged = false;

        public TreasureChest(Stage theStage, string label, string meshFile, Vector3 position)
            : base(theStage, label, meshFile)
        { 
            isCollidable = false;

            //Create Treasures at all locations
            this.treasureNode = new TreasureNode(position, false);

            //Position
            this.position = position;
            //this.tagged = false;
            treasureObject = addObject(
                position,
                new Vector3(0,1,0), 
                .79f
            );
        }

        public Object3D TreasureObject
        {
            get { return this.treasureObject; }
        }

        public TreasureNode getTreasureNode
        {
            get { return this.treasureNode; }
        }

        public Vector3 Position
        {
            get { return this.position; }
        }

        public bool Tagged
        {
            get { return this.treasureNode.tagged; }
            set { this.treasureNode.tagged = true; }

        }
    }

}
