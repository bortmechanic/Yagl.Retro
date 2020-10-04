using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace Yagl.Retro.Designer.Linux
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("YAGL Retro Designer");
            window.Show();

            Gtk.Application.Run();
        }
    }
}