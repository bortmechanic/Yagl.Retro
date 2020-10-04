using System;

namespace Yagl.Retro.Designer
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapButton_OnClicked(object sender, EventArgs e)
        {
            HelloLabel.Text += " Clicked!";
        }
    }
}
