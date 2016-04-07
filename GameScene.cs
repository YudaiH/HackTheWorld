﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static HackTheWorld.Constants;

namespace HackTheWorld
{
    class GameScene : Scene
    {
        Image _img;
        public override void Cleanup()
        {
        }

        public override void Startup()
        {
            _img = System.Drawing.Image.FromFile(@"image\masato.jpg");
        }

        public override void Update()
        {
            if (pressedKeys.Contains(Keys.X))
            {
                Scene.Pop();
            }
            
            GraphicsContext.Clear(Color.White);
            GraphicsContext.DrawImage(_img, 0, 0);

        }
    }
}
