using System;
using TestProject.Controller;
using TestProject.Database;
using TestProject.View;

namespace TestProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var mainView = new MainView();
            var database = new DummyDatabase1();
            new MainController(mainView, database);

            mainView.ShowDialog();
        }
    }
}
