# pi3-win10-iot-SimpleClock
Really simple clock. Primarily designed for Raspberry Pi 3 with Windows 10 IOT installed.

![Alt text](pi3SimpleClockGif.gif?raw=true "Title")

1. Add the text block to the MainPage.xaml designed
```XML
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto"/>
        </Grid.ColumnDefinitions>
        <TextBlock x:Name="txtTime" Grid.Row = "0" Grid.Column = "0"  Text="Initializing Time"
           IsTextSelectionEnabled="False" TextWrapping="Wrap" TextAlignment="Center" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="140" />
    </Grid>
```

2. Add a ticker for the  clock engine.  MainPage.xaml.cs
