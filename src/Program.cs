using System;
using System.IO;
using System.Windows.Forms;

namespace CalcNet
{

    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string log_file_name = Path.Combine(
                              Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                              "calc-net.log");
            Log.LogToFile(log_file_name);
            if (args.Length > 0)
            {
                TestGenerators.TestThem();
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainWindow());
        }

    }
}





