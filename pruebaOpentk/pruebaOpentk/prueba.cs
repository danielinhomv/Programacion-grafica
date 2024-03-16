using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace pruebaOpentk
{
    class prueba
    {
        static void Main(string[] args)
        {
            using (var game = new GameWindow())
            {
                game.Load += (sender, e) =>
                {
                    GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
                };

                game.Resize += (sender, e) =>
                {
                    GL.Viewport(0, 0, game.Width, game.Height);
                };

                game.RenderFrame += (sender, e) =>
                {
                    GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                    // Aquí va tu código de renderizado

                    game.SwapBuffers();
                };

                game.Run(60.0);
            }
        }
    }
}
