using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;

namespace ArquivoSTL
{
    public partial class Form1 : Form
    {
        struct Triangulo
        {
            public Vector3d A;
            public Vector3d B;
            public Vector3d C;
            public Vector3d N;

            public Triangulo(Vector3d a, Vector3d b, Vector3d c)
            {
                A = a;
                B = b;
                C = c;
                N = Vector3d.Zero;
                N = calculaNormal();
            }

            public Vector3d calculaNormal()
            {
                Vector3d n;
                n = Vector3d.Cross(C - A, B - A);
                n.Normalize();
                return n;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateStarSTL_Click(object sender, EventArgs e)
        {
            try
            {
                int points = (int)numPoints.Value;
                double externalRadius = (double)numExternalRadius.Value;
                double internalRadius = (double)numInternalRadius.Value;
                double height = (double)numHeight.Value;

                if (internalRadius >= externalRadius)
                {
                    MessageBox.Show("Internal radius must be smaller than external radius!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Vector3d> baseVertices = new List<Vector3d>();
                List<Vector3d> topVertices = new List<Vector3d>();
                List<Triangulo> faces = new List<Triangulo>();

                // Generate vertices
                double angleStep = 2 * Math.PI / (points * 2);
                for (int i = 0; i < points * 2; i++)
                {
                    double angle = i * angleStep;
                    double radius = i % 2 == 0 ? externalRadius : internalRadius;
                    double x = radius * Math.Cos(angle);
                    double y = radius * Math.Sin(angle);
                    
                    baseVertices.Add(new Vector3d(x, y, 0));
                    topVertices.Add(new Vector3d(x, y, height));
                }

                // Generate faces
                // Base faces
                Vector3d center = new Vector3d(0, 0, 0);
                for (int i = 0; i < baseVertices.Count; i++)
                {
                    int nextIndex = (i + 1) % baseVertices.Count;
                    faces.Add(new Triangulo(center, baseVertices[i], baseVertices[nextIndex]));
                }

                // Top faces
                Vector3d topCenter = new Vector3d(0, 0, height);
                for (int i = 0; i < topVertices.Count; i++)
                {
                    int nextIndex = (i + 1) % topVertices.Count;
                    faces.Add(new Triangulo(topCenter, topVertices[nextIndex], topVertices[i]));
                }

                // Side faces
                for (int i = 0; i < baseVertices.Count; i++)
                {
                    int nextIndex = (i + 1) % baseVertices.Count;
                    faces.Add(new Triangulo(baseVertices[i], topVertices[i], baseVertices[nextIndex]));
                    faces.Add(new Triangulo(baseVertices[nextIndex], topVertices[i], topVertices[nextIndex]));
                }

                string filePath = Path.Combine(Application.StartupPath, "star.stl");
                using (StreamWriter arquivo = new StreamWriter(filePath))
                {
                    arquivo.WriteLine("solid star");
                    foreach (Triangulo t in faces)
                    {
                        arquivo.WriteLine("facet normal {0} {1} {2}",
                            t.N.X.ToString(CultureInfo.InvariantCulture),
                            t.N.Y.ToString(CultureInfo.InvariantCulture),
                            t.N.Z.ToString(CultureInfo.InvariantCulture));
                        arquivo.WriteLine("   outer loop");
                        arquivo.WriteLine("     vertex {0} {1} {2}",
                            t.A.X.ToString(CultureInfo.InvariantCulture),
                            t.A.Y.ToString(CultureInfo.InvariantCulture),
                            t.A.Z.ToString(CultureInfo.InvariantCulture));
                        arquivo.WriteLine("     vertex {0} {1} {2}",
                            t.B.X.ToString(CultureInfo.InvariantCulture),
                            t.B.Y.ToString(CultureInfo.InvariantCulture),
                            t.B.Z.ToString(CultureInfo.InvariantCulture));
                        arquivo.WriteLine("     vertex {0} {1} {2}",
                            t.C.X.ToString(CultureInfo.InvariantCulture),
                            t.C.Y.ToString(CultureInfo.InvariantCulture),
                            t.C.Z.ToString(CultureInfo.InvariantCulture));
                        arquivo.WriteLine("   endloop");
                        arquivo.WriteLine("endfacet");
                    }
                    arquivo.WriteLine("endsolid star");
                }

                MessageBox.Show($"Star STL file generated successfully!\nFile saved at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating STL file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}