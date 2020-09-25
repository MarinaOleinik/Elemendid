using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolute : ContentPage
    {
        AbsoluteLayout abs = new AbsoluteLayout();
        BoxView r, b1, b2, b3, ol, or;

        public Absolute()
        {
            //InitializeComponent();
            //AbsoluteLayout abs = new AbsoluteLayout();
            Label lbl = new Label { Text = "Смайлики", FontSize = 20 };
            Button btn1 = new Button { Text = "Радость" };
            Button btn2 = new Button { Text = "Борода" };
            Button btn3 = new Button { Text = "Очки" };
            Button btn4 = new Button { Text = "Стереть" };
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            BoxView redbox = new BoxView { Color = Color.LightPink , CornerRadius = 50};
            BoxView bluecircle_l = new BoxView { Color = Color.Blue, CornerRadius=50};
            BoxView bluecircle_r = new BoxView { Color = Color.Blue, CornerRadius=50 };
            ol = new BoxView { Color = Color.Gray, CornerRadius = 50 , Opacity=0.5};
            or = new BoxView { Color = Color.Gray, CornerRadius = 50, Opacity = 0.5 };
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.0, 0.0, 200, 30));//координаты
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.0, 0.05, 100, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(0.3, 0.05, 100, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(btn2, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn3, new Rectangle(0.6, 0.05, 100, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(btn3, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn4, new Rectangle(0.9, 0.05, 100, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(btn4, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(redbox, new Rectangle(0.4, 0.4, 400, 500));
            AbsoluteLayout.SetLayoutFlags(redbox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(bluecircle_l, new Rectangle(0.2, 0.3, 50, 50));
            AbsoluteLayout.SetLayoutFlags(bluecircle_l, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(bluecircle_r, new Rectangle(0.8, 0.3, 50, 50));
            AbsoluteLayout.SetLayoutFlags(bluecircle_r, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(ol, new Rectangle(0.15, 0.2, 150, 130));
            AbsoluteLayout.SetLayoutFlags(ol, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(or, new Rectangle(0.85, 0.2, 150, 130));
            AbsoluteLayout.SetLayoutFlags(or, AbsoluteLayoutFlags.PositionProportional);
            //ol.IsVisible = false;
            //or.IsVisible = false;
            abs.Children.Add(lbl);
            abs.Children.Add(btn1);
            abs.Children.Add(btn2);
            abs.Children.Add(btn3);
            abs.Children.Add(btn4);
            abs.Children.Add(redbox);
            abs.Children.Add(bluecircle_l);
            abs.Children.Add(bluecircle_r);
            abs.Children.Add(ol);
            abs.Children.Add(or);

            r = new BoxView { Color = Color.Red, CornerRadius = 50, Rotation = -10 };
            AbsoluteLayout.SetLayoutBounds(r, new Rectangle(0.4, 0.5, 200, 30));//координаты
            AbsoluteLayout.SetLayoutFlags(r, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(r);
            r.IsVisible = true;
            b1 = new BoxView { Color = Color.Black, CornerRadius = 20 };
            AbsoluteLayout.SetLayoutBounds(b1, new Rectangle(0.4, 0.6, 50, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(b1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(b1);
            b1.IsVisible = true;
            b2 = new BoxView { Color = Color.Black, CornerRadius = 20 };
            AbsoluteLayout.SetLayoutBounds(b2, new Rectangle(0.5, 0.6, 50, 70));//координаты
            AbsoluteLayout.SetLayoutFlags(b2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(b2);
            b2.IsVisible = true;
            b3 = new BoxView { Color = Color.Black, CornerRadius = 20 };
            AbsoluteLayout.SetLayoutBounds(b3, new Rectangle(0.6, 0.6, 50, 60));//координаты
            AbsoluteLayout.SetLayoutFlags(b3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(b3);
            b3.IsVisible = true;

            Content = abs;
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            ol.IsVisible = false;
            or.IsVisible = false;
            b1.IsVisible = false;
            b2.IsVisible = false;
            b3.IsVisible = false;
            r.IsVisible = false;

        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (ol.IsVisible ==true || or.IsVisible == true)
            {
                ol.IsVisible = false;
                or.IsVisible = false;

            }
            else
            {
                ol.IsVisible = true;
                or.IsVisible = true;

            }
            
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (b1.IsVisible == false || b2.IsVisible == false || b3.IsVisible == false)
            {
                b1.IsVisible = true;
                b2.IsVisible = true;
                b3.IsVisible = true;
            }
            else
            {
                b1.IsVisible = false;
                b2.IsVisible = false;
                b3.IsVisible = false;
            }
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (r.IsVisible == false)
            {
                r.IsVisible = true;
            }
            else
            {               
                r.IsVisible = false;
            }
            
        }
    }
}