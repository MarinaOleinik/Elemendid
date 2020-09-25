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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            // InitializeComponent();
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
                ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) }
            }
            };
            BoxView b00;
            grid.Children.Add(b00 = new BoxView { Color = Color.Red }, 0, 0);
            BoxView b01;
            grid.Children.Add(b01=new BoxView { Color = Color.Blue }, 0, 1);
            //grid.Children.Add(new BoxView { Color = Color.Fuchsia }, 0, 2);

            //grid.Children.Add(new BoxView { Color = Color.Teal }, 1, 0);
            grid.Children.Add(new BoxView { Color = Color.Green }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.Maroon }, 1, 2);

            //grid.Children.Add(new BoxView { Color = Color.Olive }, 2, 0);
            grid.Children.Add(new BoxView { Color = Color.Pink }, 2, 1);
            grid.Children.Add(new BoxView { Color = Color.Yellow }, 2, 2);
            Grid.SetColumnSpan(b00, 3);
            Grid.SetRowSpan(b01, 2);
            Content = grid;
        }
    }
}