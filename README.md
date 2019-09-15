# pi3-win10-iot-SimpleClock
A really simple, and basic digital clock. Primary purpose is for Windows 10 IoT installed on Raspberry Pi 3 running on official pi display.  

![Img Pi3 in Use in Bedroom](readme-stuff/pi3SimpleClockBedroomRealLifeDemo.jpg?raw=true "Pi3 on Bedroom Night Stand")  

## SETUP, DEPLOY NOTES
Microsoft Guide for <a href="https://docs.microsoft.com/en-us/windows/iot-core/tutorials/rpi" target="_blank">Setting up a Raspberry Pi </a>

For Pi, deploy to ARM target, Remote Device.  
![Visual Studio Debug Toolbar](readme-stuff/pi3-vs-toolbar.png?raw=true "Deploy Target Config")  

When you select Remote Machine from the dropdown, Visual Studio will detect your Pi3 assuming it's online connected to your LAN.  
![Pi3 Auto Detection Remote Machine](readme-stuff/pi3-vs-remoteMachine.png?raw=true "Deploy Target Config")

## CLOCK PIECES
It takes very little code to get this clock running.

1. Add the visual text block to the MainPage.xaml, named it txtTime.
```XML
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto"/>
        </Grid.ColumnDefinitions>
        <TextBlock x:Name="txtTime" Grid.Row = "0" Grid.Column = "0"  Text="Initializing Time"
           IsTextSelectionEnabled="False" TextWrapping="Wrap" TextAlignment="Center" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="140" />
    </Grid>
```

2. Create the ticker to serve as the clock's engine, and fire it up in MainPage.xaml.cs
```C#
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
			txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); // update the xaml text object with friendy string formatted time

		});
	}
```

![Alt text](readme-stuff/pi3SimpleClockGif.gif?raw=true "Live Clock in Visual Studio")
![Alt text](readme-stuff/pi3SimpleClockGif-LightsOn.gif?raw=true "Clock with Lights on")
![Alt text](readme-stuff/pi3SimpleClockGif-LiveDark.gif?raw=true "Clock with Lights Off")
