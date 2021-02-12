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
    public partial class timerPicer : ContentPage
    {
        Label label;
        TimePicker timePicker;
        public timerPicer()
        {
            StackLayout stack = new StackLayout();
            label = new Label();
            label.FontSize = 20;
            label.BackgroundColor = Color.Orange;
            timePicker = new TimePicker() { Time = new TimeSpan(0, 0, 0) };
            timePicker.PropertyChanged += TimePicker_PropertyChanged; ;

            stack.Children.Add(label);
            stack.Children.Add(timePicker);
            this.Content = stack;
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            label.Text = "Время: " + Convert.ToString(timePicker.Time);
        }
    }
}