using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace sigma_graphcs
{
    class Program : GameWindow
    {
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadMatrix(ref projection);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(-0.1f, -0.1f);
            GL.Vertex2(0.1f, -0.1f);
            GL.Vertex2(0.1f, 0.1f);
            GL.Vertex2(-0.1f, 0.1f);
            GL.End();

            SwapBuffers();
        }
        static void Main(string[] args)
        {
            new Program().Run();
        }
    }

}