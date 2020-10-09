using Eto.Drawing;
using Eto.Forms;

namespace Yagl.Retro.Designer
{
    public sealed class MainForm : Form
    {
        public MainForm()
        {
            Title = "YAGL Retro Designer";
            ClientSize = new Size(800, 600);

            Content = new StackLayout
            {
                Padding = 10,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Stretch,
                
                Items =
                {
                    new Label { Text = "Hello World!", 
                        TextAlignment = TextAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    }
                    // add more controls here
				}
            };

            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (sender, e) => Application.Instance.Quit();

            var aboutCommand = new Command { MenuText = "About..." };
            aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

            // create menu
            Menu = new MenuBar
            {
                Items =
                {
                    // File submenu
                    new ButtonMenuItem {Text = "&File"}
                },
                ApplicationItems =
                {
                    // application (OS X) or file menu (others)
                    new ButtonMenuItem {Text = "&Preferences..."},
                },
                QuitItem = quitCommand,
                AboutItem = aboutCommand
            };

            // create toolbar			
            //ToolBar = new ToolBar { Items = { } };
        }
    }
}
