using System.Windows.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new Yagl.Retro.Designer.App());
        }
    }
}
