using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace Yagl.Retro.Designer.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new Yagl.Retro.Designer.App());
        }
    }
}
