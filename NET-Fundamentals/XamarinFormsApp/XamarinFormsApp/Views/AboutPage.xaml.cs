using ClassLibraryConcat;
using System;
using Xamarin.Forms;

namespace XamarinFormsApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_OnClicked(object sender, EventArgs e)
        {
            GreetingsLabel.Text = InputBox.Text.ToGreeting();
        }
    }
}