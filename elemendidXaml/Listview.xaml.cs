using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace elemendidXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listview : ContentPage
    {
        public Listview()
        {
            InitializeComponent();
        }

        private async void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((string)e.SelectedItem== "iPhone 4 Cтарая модель 2016 года")//выбранный элемент переводиться в стринг и сравниться то ли это выбратонно.
            {
                await Navigation.PushAsync(new iphone_4());//переход на старницу выбранного элемента.
            }
            if ((string)e.SelectedItem == "iPhone 5 Cтарая модель")
            {
                await Navigation.PushAsync(new iphone5());
            }
            if ((string)e.SelectedItem == "iPhone 12 Новая модель 2020 года")
            {
                await Navigation.PushAsync(new iphone12());
            }
            if ((string)e.SelectedItem == "iPhone 10 Новая модель 2020 года")
            {
                await Navigation.PushAsync(new iphone10());
            }
            if ((string)e.SelectedItem == "iPhone 6s Старая модель 2018 года")
            {
                await Navigation.PushAsync(new iphone6s());
            }
            if ((string)e.SelectedItem == "iPhone 7 Старая модель 2018 года")
            {
                await Navigation.PushAsync(new iphone7());
            }
            if ((string)e.SelectedItem == "iPhone 8plus Старая модель 2017 года")
            {
                await Navigation.PushAsync(new iphone8plus());
            }
        }
    }
}