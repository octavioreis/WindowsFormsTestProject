using System;
using System.Windows.Forms;
using TestProject.View;

namespace TestProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MainView());
        }
    }
}
