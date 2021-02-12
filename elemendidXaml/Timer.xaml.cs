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
    public partial class Timer : ContentPage
    {
        Button timerButton, stopButton, startButton;
        bool alive = true;
        public Timer()
        {
            StackLayout stack = new StackLayout()
            {
                BackgroundColor = Color.Orange
            };
            timerButton = new Button
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),

            };
            stopButton = new Button
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Fill,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                Text = "Stop",
                BackgroundColor = Color.CadetBlue

            };
            startButton = new Button
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Fill,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                Text = "Start",
                BackgroundColor = Color.CadetBlue
            };
            timerButton.Clicked += TimerButton_Clicked;
            stopButton.Clicked += StopButton_Clicked;
            startButton.Clicked += Start_Clicked;

            stack.Children.Add(timerButton);
            stack.Children.Add(stopButton);
            stack.Children.Add(startButton);
            Content = stack;

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        private void Start_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }

        private void StopButton_Clicked(object sender, EventArgs e)
        {
            alive = false;
        }

        private bool OnTimerTick()
        {
            timerButton.Text = DateTime.Now.ToString("T");
            return alive;
        }

        private void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
            }
            else
            {
                alive = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }
    }
}