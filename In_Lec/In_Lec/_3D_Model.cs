using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace In_Lec
{
    class _3D_Model
    {
       public List<_3D_Point> L_3D_Pts = new List<_3D_Point>();
       public List<Edge> L_Edges = new List<Edge>();

        public void AddPoint(_3D_Point pnn)
        {
            L_3D_Pts.Add(pnn);
        }

        public void AddEdge(int i , int j , Color cl)
        {
            Edge pnn = new Edge(i, j);
            pnn.cl = cl;
            L_Edges.Add(pnn);
        }

        public void DrawYourSelf(Graphics g)
        {
            Font FF = new Font("System", 10);
            float XB = 500;
            float YB = 0;
            for (int k = 0; k < L_Edges.Count; k++)
            {
                int i = L_Edges[k].i;
                int j = L_Edges[k].j;

                _3D_Point pi = L_3D_Pts[i];
                _3D_Point pj = L_3D_Pts[j];

                float d = 500;

                Pen Pn = new Pen(L_Edges[k].cl, 2);

                g.DrawLine(Pn, 
                                pi.X * (d / pi.Z) , 
                                pi.Y * (d / pi.Z) , 
                                pj.X * (d / pj.Z) , 
                                pj.Y * (d / pj.Z) );


            }
        }
    }
}
