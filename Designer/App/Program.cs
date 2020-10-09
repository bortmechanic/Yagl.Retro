using System;
using Eto.Forms;

namespace Yagl.Retro.Designer
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new Application(Eto.Platform.Detect).Run(new MainForm());
        }
    }
}