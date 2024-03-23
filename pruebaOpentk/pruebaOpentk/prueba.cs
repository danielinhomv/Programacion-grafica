using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

class TrapezoidWindow : GameWindow
{
    public TrapezoidWindow() : base(800, 600, GraphicsMode.Default, "Trapezoid 3D")
    {
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        GL.ClearColor(Color4.White);

        GL.Enable(EnableCap.DepthTest);
        GL.DepthFunc(DepthFunction.Less);

        GL.MatrixMode(MatrixMode.Projection);
        Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 0.1f, 100.0f);
        GL.LoadMatrix(ref perspective);
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        GL.MatrixMode(MatrixMode.Modelview);
        Matrix4 view = Matrix4.LookAt(new Vector3(0,-3,6), Vector3.Zero, Vector3.UnitY);
        GL.LoadMatrix(ref view);

        // Dibujar el trapecio
        GL.Begin(PrimitiveType.Quads);

        GL.Color3(0.5f, 0.5f, 0.5f); // Color gris (plomo)

        GL.Vertex3(-0.7f, 0.1f, -0.1f);  // Esquina inferior izquierda
        GL.Vertex3(0.7f, 0.1f, -0.1f); // Esquina inferior derecha
        GL.Vertex3(0.7f, 0.1f, 0.1f);  // Esquina superior derecha
        GL.Vertex3(-0.7f, 0.1f, 0.1f);   // Esquina superior izquierda


        GL.Color3(0.5f, 0.5f, 0.5f); // Color gris (plomo)

        GL.Vertex3(-0.7f, -1f, -0.1f); // Esquina inferior izquierda
        GL.Vertex3(-0.2f, -1f, -0.1f);  // Esquina inferior derecha
        GL.Vertex3(-0.2f, -1f, 0.1f);   // Esquina superior derecha
        GL.Vertex3(-0.7f, -1f, 0.1f);  // Esquina superior izquierda

        GL.Color3(0.0f, 0.0f, 0.0f);

        GL.Vertex3(-0.2f, -1f, 0.1f);  // Esquina superior izquierda
        GL.Vertex3(0.1f, -1f, 0.1f);   // Esquina superior derecha
        GL.Vertex3(0.1f, -1.1f, -0.1f);  // Esquina inferior derecha
        GL.Vertex3(-0.2f, -1.1f, -0.1f); // Esquina inferior izquierda

        GL.Color3(0.5f, 0.5f, 0.5f); // Color gris (plomo)

        GL.Vertex3(0.1f, -1f, -0.1f); // Esquina inferior izquierda
        GL.Vertex3(0.7f, -1f, -0.1f);  // Esquina inferior derecha
        GL.Vertex3(0.7f, -1f, 0.1f);   // Esquina superior derecha
        GL.Vertex3(0.1f, -1f, 0.1f);  // Esquina superior izquierda

        GL.Color3(0.5f, 0.5f, 0.5f); // Color gris (plomo)
        // Lateral derecho de la caja
        GL.Vertex3(0.7f, -1f, -0.1f); // Esquina inferior derecha
        GL.Vertex3(0.7f, -1f, 0.1f);  // Esquina superior derecha
        GL.Vertex3(0.7f, -1f, 0.1f);   // Esquina superior izquierda
        GL.Vertex3(0.7f, -1f, -0.1f);  // Esquina inferior izquierda

        // Lateral izquierdo de la caja
        GL.Color3(0.5f, 0.5f, 0.5f); // Color gris (plomo)

        GL.Vertex3(0.7f, -1f, -0.1f); // Esquina inferior derecha
        GL.Vertex3(0.7f, -1f, 0.1f);  // Esquina superior derecha
        GL.Vertex3(0.7f, 0.1f, 0.1f);   // Esquina superior izquierda
        GL.Vertex3(0.7f, 0.1f, -0.1f);  // Esquina inferior izquierda
                                        //GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

        // Lateral derecho de la caja
        GL.Vertex3(-0.7f, 0.1f, -0.1f);  // Esquina inferior derecha
        GL.Vertex3(-0.7f, 0.1f, 0.1f);   // Esquina superior derecha  
        GL.Vertex3(-0.7f, -1f, 0.1f); // Esquina superior izquierda
        GL.Vertex3(-0.7f, -1f, -0.1f); // Esquina inferior izquierda


        //frontal 
        GL.Color3(0.0f, 0.0f, 0.0f);
        
        GL.Vertex3(-0.7f, -1f, -0.1f);
        GL.Vertex3(0.7f, -1f, -0.1f); 
        GL.Vertex3(0.7f, 0.1f, -0.1f);
        GL.Vertex3(-0.7f, 0.1f, -0.1f); 







        GL.End();

        SwapBuffers();
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (var window = new TrapezoidWindow())
        {
            window.Run(60.0);
        }
    }
}
