using System;
using System.Windows.Forms;
using WinFormsApp2_RSA;

namespace WinFormsApp2_RSA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(
                new Form1()
            );
        }
    }
}