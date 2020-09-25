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
    public partial class Lund : ContentPage
    {
        BoxView pea, amber, keha;
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //голова
            pea = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };    
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.3, 0.2, 200, 200));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);
            //тело
            keha = new BoxView { Color = Color.Blue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.5, 0.5, 300, 300));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);



            Content = abs;
        }
    }
}