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

            Form1 form1 = new Form1();

            form1.Show();

            Application.Run();
        }
    }
}
