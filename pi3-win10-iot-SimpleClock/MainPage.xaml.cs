using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices.WindowsRuntime;
//using Windows.Foundation;
//using Windows.Foundation.Collections;
//using Windows.UI.Xaml.Controls.Primitives;
//using Windows.UI.Xaml.Data;
//using Windows.UI.Xaml.Input;
//using Windows.UI.Xaml.Media;
//using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace pi3_win10_iot_SimpleClock
{
    /// <summary>
    /// Simple Clock Page Guts
    /// For Pi, deploy to ARM target, Remote Device.
    /// Assuming it's online and connected to your LAN, visual studio will detect it when you target REMOTE debug target.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1); // hh,mi,ss tick once per second
            Timer.Start(); // kick off the ticker forever
        }

        async void Timer_Tick(object Sender, object e)
        {
            await this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () =>
            {
                // Run the Code
                txtTime.Text = DateTime.Now.ToString("h:mm:ss tt"); // update the xaml text object

            });
        }
    }
}
