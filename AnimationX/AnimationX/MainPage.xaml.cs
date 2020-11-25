using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationX
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void HableClick(object o, EventArgs e)
        {
            if (!this.popuplayout.IsVisible)
            {
                this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
                this.popuplayout.AnchorX = 1;
                this.popuplayout.AnchorY = 1;

                Animation scaleAnimation = new Animation(
                    f => this.popuplayout.Scale = f,
                    0.5,
                    1,
                    Easing.CubicOut);

                Animation fadeAnimation = new Animation(
                    f => this.popuplayout.Opacity = f,
                    0.2,
                    1,
                    Easing.SinInOut);

                scaleAnimation.Commit(this.popuplayout, "popupScaleAnimation", 250);
                fadeAnimation.Commit(this.popuplayout, "popupFadeAnimation", 250);
            }
            else
            {
                await Task.WhenAny<bool>(this.popuplayout.FadeTo(16, 2000, Easing.Linear));
                // Task.WhenAny<bool>(this.popuplayout.FadeTo(0, 200, Easing.SinInOut));
                this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
            }
        }
    }
}
