using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Color GetRndColor()
        {
            Random rnd = new Random();
            return Color.FromRgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0,256));

        }

        private void SnowmanOpacity(int opacity)
        {
            ball1.Opacity = opacity;
            ball2.Opacity = opacity;
            ball3.Opacity = opacity;
        }

        private void Random_Button_Clicked(object sender, EventArgs e)
        {
            ball1.BackgroundColor = GetRndColor();
            ball2.BackgroundColor = GetRndColor();
            ball3.BackgroundColor = GetRndColor();
        }

        private void Hide_Button_Clicked(object sender, EventArgs e)
        {
            if (ball1.Opacity != 1) { SnowmanOpacity(1); }
            else { SnowmanOpacity(0); }
        }

        private void SetBackgroundColor(int r, int g, int b)
        {
            mainLayout.BackgroundColor = Color.FromRgb(r, g, b);
        }

        private async void TurnOver_Clicked(object sender, EventArgs e)
        {
            await Task.Run(() =>
           {
               
           });
        }

        private async void Melt_Button_Clicked(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 256; i++)
                {
                    SetBackgroundColor(i, i, i);
                    Thread.Sleep(15);
                }
                SnowmanOpacity(0);
                Thread.Sleep(1000);
                SnowmanOpacity(1);
            });
        }


        private void Surprise_Button_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}