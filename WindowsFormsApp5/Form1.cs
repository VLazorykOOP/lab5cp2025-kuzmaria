using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private PointF[] bezierPoints = new PointF[4];
        private int kochOrder = 3;
        private bool showBezier = true;
        private bool showKoch = true;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    float x = float.Parse(bezierX[i].Text);
                    float y = float.Parse(bezierY[i].Text);
                    bezierPoints[i] = new PointF(x, y);
                }

                kochOrder = int.Parse(kochOrderBox.Text);
                showBezier = bezierCheckBox.Checked;
                showKoch = kochCheckBox.Checked;

                this.Invalidate(); // перемальовка
            }
            catch
            {
                MessageBox.Show("Некоректні координати або порядок фракталу!", "Помилка");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (showBezier)
                DrawBezier(g, bezierPoints[0], bezierPoints[1], bezierPoints[2], bezierPoints[3]);

            if (showKoch)
            {
                int D = 300;
                PointF A = new PointF(450, 100);
                PointF B = new PointF(450 + D, 100);
                PointF C = new PointF(450 + D, 100 + D);
                PointF Dp = new PointF(450, 100 + D);

                DrawKoch(g, A, B, kochOrder);
                DrawKoch(g, B, C, kochOrder);
                DrawKoch(g, C, Dp, kochOrder);
                DrawKoch(g, Dp, A, kochOrder);
            }
        }

        private void DrawBezier(Graphics g, PointF P1, PointF P2, PointF P3, PointF P4)
        {
            PointF prev = P1;
            for (float t = 0; t <= 1.0f; t += 0.01f)
            {
                float x = (float)Math.Pow(1 - t, 3) * P1.X
                        + 3 * (float)Math.Pow(1 - t, 2) * t * P2.X
                        + 3 * (1 - t) * (float)Math.Pow(t, 2) * P3.X
                        + (float)Math.Pow(t, 3) * P4.X;

                float y = (float)Math.Pow(1 - t, 3) * P1.Y
                        + 3 * (float)Math.Pow(1 - t, 2) * t * P2.Y
                        + 3 * (1 - t) * (float)Math.Pow(t, 2) * P3.Y
                        + (float)Math.Pow(t, 3) * P4.Y;

                PointF current = new PointF(x, y);
                g.DrawLine(Pens.Red, prev, current);
                prev = current;
            }

            g.FillEllipse(Brushes.Black, P1.X - 3, P1.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Black, P2.X - 3, P2.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Black, P3.X - 3, P3.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Black, P4.X - 3, P4.Y - 3, 6, 6);
        }

        private void DrawKoch(Graphics g, PointF a, PointF b, int depth)
        {
            if (depth == 0)
            {
                g.DrawLine(Pens.Blue, a, b);
                return;
            }

            PointF ab = new PointF((2 * a.X + b.X) / 3, (2 * a.Y + b.Y) / 3);
            PointF bc = new PointF((a.X + 2 * b.X) / 3, (a.Y + 2 * b.Y) / 3);
            float dx = b.X - a.X;
            float dy = b.Y - a.Y;

            float px = (ab.X + bc.X) / 2 - (float)(Math.Sqrt(3) / 6 * dy);
            float py = (ab.Y + bc.Y) / 2 + (float)(Math.Sqrt(3) / 6 * dx);
            PointF p = new PointF(px, py);

            DrawKoch(g, a, ab, depth - 1);
            DrawKoch(g, ab, p, depth - 1);
            DrawKoch(g, p, bc, depth - 1);
            DrawKoch(g, bc, b, depth - 1);
        }
    }
}
