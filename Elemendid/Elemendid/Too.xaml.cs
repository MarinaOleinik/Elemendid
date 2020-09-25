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
    public partial class Too : ContentPage
    {
        public Too()
        {
            InitializeComponent();
        }
        int t = 0;
        private void btn_up_Clicked(object sender, EventArgs e)
        {
            t = t + 1;
            label_tere.FontSize = label_tere.FontSize + t;
            if (t%3==0)
            {
                stack.BackgroundColor = Color.FromRgb(15, 250, 0);
            }
            else
            {
                stack.BackgroundColor = Color.FromRgb(250-5*t, 250-5*t, 250-5*t);
            }

        }

        private void btn_dn_Clicked(object sender, EventArgs e)
        {
            //t = t + 1;
            //label_tere.FontSize = label_tere.FontSize -5;
            //if (t % 5 == 0)
            //{
            //    stack.BackgroundColor = Color.FromRgb(15, 250, 120);
            //}
            //else
            //{
            //    stack.BackgroundColor = Color.FromRgb(250 - 5 * t, 250 - 5 * t, 250 - 5 * t);
            //}
            bob.Rotation = bob.Rotation + 2;

        }
    }
}