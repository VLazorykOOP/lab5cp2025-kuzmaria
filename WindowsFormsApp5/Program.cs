using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаємо обидві форми одночасно
            Form1 form1 = new Form1();
            KochForm kochForm = new KochForm();

            form1.Show();
            kochForm.Show();

            // Запускаємо цикл обробки подій з form1,
            // щоб додаток не завершився поки відкриті форми
            Application.Run();
        }
    }
}
