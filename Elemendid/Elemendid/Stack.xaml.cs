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
    public partial class Stack : ContentPage
    {
        public Stack()
        {
            InitializeComponent();
        }
        int tik = 0;
        private void Btn_Clicked(object sender, EventArgs e)
        {
            tik = tik+1;
            btn.Text = tik.ToString();
            btn.CornerRadius = tik;
            if (tik % 3==0)
            {
                lbl1.IsVisible = true;
            }
            else
            {
                lbl1.IsVisible = false;
            }
        }
    }
}