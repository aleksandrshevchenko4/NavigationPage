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
    public partial class Switch : ContentPage
    {
        public Switch()
        {
            InitializeComponent();
        }
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label.Text = String.Format("Значение  {0}", e.Value);
        }
    }
}