namespace WindowsFormsApp5
{
    partial class KochForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox orderBox;
        private System.Windows.Forms.TextBox sideBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelSide;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.orderBox = new System.Windows.Forms.TextBox();
            this.sideBox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // labelOrder
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(20, 15);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(60, 13);
            this.labelOrder.Text = "Порядок K:";

            // orderBox
            this.orderBox.Location = new System.Drawing.Point(100, 10);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(40, 20);
            this.orderBox.Text = "3";

            // labelSide
            this.labelSide.AutoSize = true;
            this.labelSide.Location = new System.Drawing.Point(160, 15);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(60, 13);
            this.labelSide.Text = "Сторона D:";

            // sideBox
            this.sideBox.Location = new System.Drawing.Point(230, 10);
            this.sideBox.Name = "sideBox";
            this.sideBox.Size = new System.Drawing.Size(60, 20);
            this.sideBox.Text = "300";

            // drawButton
            this.drawButton.Location = new System.Drawing.Point(310, 8);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(100, 24);
            this.drawButton.Text = "Намалювати";
            this.drawButton.UseVisualStyleBackColor = true;

            // KochForm
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.sideBox);
            this.Controls.Add(this.drawButton);

            this.Name = "KochForm";
            this.Text = "Завдання 2 – Фрактал Коха (окремо)";
            this.DoubleBuffered = true;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
