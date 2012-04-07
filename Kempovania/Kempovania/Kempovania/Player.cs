using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Kempovania
{
    class Player
    {

        //Animation representing the player
        public Texture2D playerTexture;

        //Position of the Player relative to the upper left side of the screen
        public Vector2 postion;

        //State of the player 
        public bool active;

        //Health of Player
        public int health;

        //Width of Player
        public int width
        {
            get { return playerTexture.Width; }
        }

        // @get
        // returns Hieght of playerTexture
        public int height
        {
            get { return playerTexture.Height; }
        }


        public void Initialize(Texture2D texture, Vector2 pos)
        {
            playerTexture = texture;
            //Set the starting position of the player around the middle of the screen and to the back
            postion = pos;

            //Set the player to be active
            active = true;

            //Set the player health
            health = 100;


        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spritebacth)
        {
            spritebacth.Draw(playerTexture, postion, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

        }



    }
}
