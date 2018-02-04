using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using AudioSwitcher.AudioApi.CoreAudio;


namespace Automatic_Volume_Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        double current_volume = 0;

        public MainWindow()
        {
            InitializeComponent();
            current_volume=defaultPlaybackDevice.Volume;
        }

        private void Vol_up_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
            current_volume = current_volume + 10;
            defaultPlaybackDevice.Volume = current_volume;
        }

        private void Vol_Dwn_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
            current_volume = current_volume - 10;
            defaultPlaybackDevice.Volume = current_volume;
        }

        private void Mute_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
            current_volume = 0;
            defaultPlaybackDevice.Volume = current_volume;
        }
    }
}
