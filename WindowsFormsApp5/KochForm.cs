using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class KochForm : Form
    {
        private int kochOrder = 3;
        private float sideLength = 300f;

        public KochForm()
        {
            InitializeComponent();

            // Подія кліку кнопки
            drawButton.Click += DrawButton_Click;

            // Подія малювання форми
            this.Paint += KochForm_Paint;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(orderBox.Text, out int k) || k < 0)
            {
                MessageBox.Show("Невірне число порядку K (має бути цілим не відʼємним)!");
                return;
            }

            if (!float.TryParse(sideBox.Text, out float d) || d <= 0)
            {
                MessageBox.Show("Невірна довжина сторони D (має бути додатнім числом)!");
                return;
            }

            kochOrder = k;
            sideLength = d;

            this.Invalidate(); // Перемалювати форму
        }

        private void KochForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            PointF A = new PointF(50, 50);
            PointF B = new PointF(50 + sideLength, 50);
            PointF C = new PointF(50 + sideLength, 50 + sideLength);
            PointF D = new PointF(50, 50 + sideLength);

            DrawKoch(g, A, B, kochOrder);
            DrawKoch(g, B, C, kochOrder);
            DrawKoch(g, C, D, kochOrder);
            DrawKoch(g, D, A, kochOrder);
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
