namespace WindowsFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox[] bezierX;
        private System.Windows.Forms.TextBox[] bezierY;
        private System.Windows.Forms.TextBox kochOrderBox;
        private System.Windows.Forms.CheckBox bezierCheckBox;
        private System.Windows.Forms.CheckBox kochCheckBox;
        private System.Windows.Forms.Button drawButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.bezierX = new System.Windows.Forms.TextBox[4];
            this.bezierY = new System.Windows.Forms.TextBox[4];
            this.kochOrderBox = new System.Windows.Forms.TextBox();
            this.bezierCheckBox = new System.Windows.Forms.CheckBox();
            this.kochCheckBox = new System.Windows.Forms.CheckBox();
            this.drawButton = new System.Windows.Forms.Button();

            for (int i = 0; i < 4; i++)
            {
                this.bezierX[i] = new System.Windows.Forms.TextBox();
                this.bezierY[i] = new System.Windows.Forms.TextBox();
            }

            this.SuspendLayout();

            // CheckBox для Без’є
            this.bezierCheckBox.AutoSize = true;
            this.bezierCheckBox.Location = new System.Drawing.Point(20, 20);
            this.bezierCheckBox.Size = new System.Drawing.Size(140, 17);
            this.bezierCheckBox.Text = "Малювати криву Без’є";
            this.bezierCheckBox.Checked = true;

            // CheckBox для Коха
            this.kochCheckBox.AutoSize = true;
            this.kochCheckBox.Location = new System.Drawing.Point(160, 20);
            this.kochCheckBox.Size = new System.Drawing.Size(156, 17);
            this.kochCheckBox.Text = "Малювати фрактал Коха";
            this.kochCheckBox.Checked = true;

            // Текстові поля для координат
            for (int i = 0; i < 4; i++)
            {
                this.bezierX[i].Location = new System.Drawing.Point(20, 50 + i * 30);
                this.bezierX[i].Size = new System.Drawing.Size(40, 20);
                this.bezierX[i].Text = (50 + i * 100).ToString();

                this.bezierY[i].Location = new System.Drawing.Point(70, 50 + i * 30);
                this.bezierY[i].Size = new System.Drawing.Size(40, 20);
                this.bezierY[i].Text = "250";

                this.Controls.Add(this.bezierX[i]);
                this.Controls.Add(this.bezierY[i]);
            }

            // Текстове поле для порядку фракталу Коха
            this.kochOrderBox.Location = new System.Drawing.Point(160, 50);
            this.kochOrderBox.Size = new System.Drawing.Size(40, 20);
            this.kochOrderBox.Text = "3";

            // Кнопка
            this.drawButton.Location = new System.Drawing.Point(20, 180);
            this.drawButton.Size = new System.Drawing.Size(100, 30);
            this.drawButton.Text = "Намалювати";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);

            // Додати всі елементи
            this.Controls.Add(this.bezierCheckBox);
            this.Controls.Add(this.kochCheckBox);
            this.Controls.Add(this.kochOrderBox);
            this.Controls.Add(this.drawButton);

            // Форма
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.Text = "Lab 5 — Без’є і Кох";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
