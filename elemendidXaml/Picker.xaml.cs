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
    public partial class Picker : ContentPage
    {
        public Picker()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
        }
    }
}