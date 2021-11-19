using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace In_Lec
{
    public partial class Form1 : Form
    {
        Bitmap off;

        _3D_Model Cube = new _3D_Model();
        _3D_Model Cube1 = new _3D_Model();
        _3D_Model Cube2 = new _3D_Model();
        _3D_Model Cube3 = new _3D_Model();

        int ctTick = 0;
        int f = 0;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
   
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    //Cube.RotX(1);
                    break;
                case Keys.Y:
                    //Cube.RotY(1);
                    break;
                case Keys.Z:
                    //Cube.RotZ(1);
                    break;

                case Keys.Right:
                    //Cube.TransX(5);
                    break;
                case Keys.Left:
                    //Cube.TransX(-5);
                    break;

                case Keys.Up:
                    //Cube.TransZ(5);
                    break;
                case Keys.Down:
                    //Cube.TransZ(-5);
                    break;

                case Keys.Space:
                    
                    _3D_Point p1 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[0].i]);
                    _3D_Point p2 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[0].j]);

                    if (ctTick == 13 )
                    {
                        f = 1;       
                    }
                    if (ctTick == 0)
                    {
                        f = 0;
                    }

                    if (f == 0)
                    {
                        Transformation.RotateArbitrary(Cube1.L_3D_Pts, p1, p2, -5);
                        Transformation.RotateArbitrary(Cube.L_3D_Pts, p1, p2, -5);
                        ctTick++;
                    }

                    if (f == 1)
                    {
                        Transformation.RotateArbitrary(Cube1.L_3D_Pts, p1, p2, 5);
                        Transformation.RotateArbitrary(Cube.L_3D_Pts, p1, p2, 5);
                        ctTick--;
                    }



                  //  _3D_Point p3 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[1].i]);
                  //  _3D_Point p4 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[1].j]);
                  //  Transformation.RotateArbitrary(Cube1.L_3D_Pts, p3, p4, -5);

                 //  p1 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[1].i]);
                 //  p2 = new _3D_Point(Cube1.L_3D_Pts[Cube1.L_Edges[1].j]);
                 //  Transformation.RotateArbitrary(Cube1.L_3D_Pts,p1,p2,-5);
                    break;
            }

            DrawDubble(this.CreateGraphics());
        }

        void CreateCube(_3D_Model M , float XS , float YS , float ZS)
        {
            float[] vert = 
                            { 
                                   200,300,300, //0
                                    235,340,350, //1
                                    123,340,350, //2
                                    105,300,300, //3
                                    200,200,300, //4
                                    235,240,350, //5
                                    123,240,350, //6
                                    105,200,300  //7                            
                            };

            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j]+XS, vert[j + 1]+YS, vert[j + 2]+ZS);
                j += 3;
                M.AddPoint(pnn);
            }

            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Yellow, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Red); //cl[i % 4]);

                j += 2;
            }
        }

        void CreateCube1(_3D_Model M, float XS, float YS, float ZS)
        {
            float[] vert = 
                            { 
                                    300,300,300, //0
                                    350,340,350, //1
                                    234,340,350, //2
                                    200,300,300, //3
                                    300,200,300, //4
                                    350,240,350, //5
                                    234,240,350, //6
                                    200,200,300  //7                          
                            };

            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }

            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Yellow, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Red); //cl[i % 4]);

                j += 2;
            }
        }

        void CreateCube2(_3D_Model M, float XS, float YS, float ZS)
        {
            float[] vert = 
                            { 
                                   400,300,300, //0
                                    465,340,350, //1
                                    350,340,350, //2
                                    300,300,300, //3
                                    400,200,300, //4
                                    465,240,350, //5
                                    350,240,350, //6
                                    300,200,300  //7                            
                            };

            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }

            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Yellow, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Red); //cl[i % 4]);

                j += 2;
            }
        }

        void CreateCube3(_3D_Model M, float XS, float YS, float ZS)
        {
            float[] vert = 
                            { 
                                    500,300,300, //0
                                    583,340,350, //1
                                    466,340,350, //2
                                    400,300,300, //3
                                    500,200,300, //4
                                    583,240,350, //5
                                    466,240,350, //6
                                    400,200,300  //7                           
                            };

            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }

            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Yellow, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Red); //cl[i % 4]);

                j += 2;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width , this.ClientSize.Height);
            CreateCube(Cube , 0,0,0);
            CreateCube1(Cube1, 0, 0, 0);
            CreateCube2(Cube2, 0, 0, 0);
            CreateCube3(Cube3, 0, 0, 0);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubble(e.Graphics);
        }

        void DrawScene(Graphics g)
        {
            g.Clear(Color.White);
            
            Cube.DrawYourSelf(g);
            Cube1.DrawYourSelf(g);
            Cube2.DrawYourSelf(g);
            Cube3.DrawYourSelf(g);
        }

        void DrawDubble(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
