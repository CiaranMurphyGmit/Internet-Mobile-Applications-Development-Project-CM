using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project___Ciaran_M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Button su = Sun;
            Button mer = Mercury;
            Button ven = Venus;
            Button ear = Earth;
            Button mar = Mars;
            Button jup = Jupiter;
            Button sat = Saturn;
            Button ura = Uranus;
            Button nep = Neptune;
            Button plu = Pluto;
        }

        private async void Button_Click_Sun(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();// This creates a speech synthesis object, voicing the description
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("The sun is the star at the centre of our solar system. It is a sphere of hot plasma (mostly hydrogen) that radiates an incredible amount of heat. The temperature of its core is " +
                "about 15 million degrees Celsius. Life on Earth depends on the sun for energy and heat.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
            
            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Sun.jpg")); //Changes the image displayed at top of screen
            
            // Below is the code for changing the text displayed on screen
            PName.Text = "Name: Sun";
            PDesignation.Text = "Designation: Star";
            PType.Text = "Type: G-type main-sequence star (G2V)";
            PRadius.Text = "Radius: 695700km";
            PVolume.Text = "Volume: 1.41×10^18 km3";
            PMass.Text = "Mass: 1.989 × 10^30 kg";
            PGravity.Text = "Surface Gravity: 274 m/s2";
            PDescription.Text = "Description: The sun is the star at the centre of our Solar System.\n" +
                "It is a sphere of hot plasma (mostly hydrogen) that radiates heat.\n" +
                "The temperature of its core is about 15 million degrees Celsius.\n" +
                "Life on Earth depends on the sun for energy and heat.\n";
        }

        private async void Button_Click_Mercury(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Mercury is the smallest and innermost planet in the Solar System. It is named after the Roman deity Mercury, the messenger to the gods. It is one of four " +
                "terrestrial planets in the Solar System, and is a rocky body like Earth.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Mercury.jpg"));
            PName.Text = "Name: Mercury";
            PDesignation.Text = "Designation: First planet in the Solar System";
            PType.Text = "Type: Terrestrial Planet";
            PRadius.Text = "Radius: 2440km";
            PVolume.Text = "Volume: 6.083×10^10 km3";
            PMass.Text = "Mass: 3.285 × 10^23 kg";
            PGravity.Text = "Surface Gravity: 3.7 m/s2";
            PDescription.Text = "Description: Mercury is the smallest and innermost planet in the Solar System.\n" +
                "It is named after the Roman deity Mercury, the messenger to the gods.\n" +
                "It is one of four terrestrial planets in the Solar System, and is a rocky body like \nEarth.\n";
        }

        private async void Button_Click_Venus(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Venus is the second planet from the sun.\n" +
                " It has a hot dense atmosphere composed mainly of carbon dioxide.\n" +
                " Its atmospheric pressure is 92 times that of Earth.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Venus.jpg"));
            PName.Text = "Name: Venus";
            PDesignation.Text = "Designation: Second planet in the Solar System";
            PType.Text = "Type: Terrestrial Planet";
            PRadius.Text = "Radius: 6052 km";
            PVolume.Text = "Volume: 9.38 x 10^11 km3";
            PMass.Text = "Mass: 4.867 × 10^24 kg";
            PGravity.Text = "Surface Gravity: 8.87 m/s2";
            PDescription.Text = "Description: Venus is the second planet from the sun.\n" +
                "It has a hot dense atmosphere composed mainly of CO2.\n" +
                "Its atmospheric pressure is 92 times that of Earth.\n";
        }

        private async void Button_Click_Earth(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Earth is the third planet from the sun.\n" +
                " It is the only place in the Universe known to harbor life.\n" +
                " It is orbited by the Moon, Earth's only natural satellite.\n" +
                " It is the largest of the four terrestrial planets.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Earth.jpg"));
            PName.Text = "Name: Earth";
            PDesignation.Text = "Designation: Third Planet in the Solar System";
            PType.Text = "Type: Terrestrial Planet";
            PRadius.Text = "Radius: 6371km";
            PVolume.Text = "Volume: ‎1.08321 ×10^12 km3";
            PMass.Text = "Mass: 5.972 × 10^24 kg";
            PGravity.Text = "Surface Gravity: 9.807 m/s2";
            PDescription.Text = "Description: Earth is the third planet from the sun.\n" +
                "It is the only place in the Universe known to harbor life.\n" +
                "It is orbited by the Moon, Earth's only natural satellite.\n" +
                "It is the largest of the four terrestrial planets.\n";
        }

        private async void Button_Click_Mars(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Mars is the fourth planet from the sun.\n" +
                " It is a cold, barren world named after the Roman god of war.\n" +
                " Known as the Red Planet due to the presence of iron oxide, giving it a reddish tint.\n" +
                " Scientists believe Mars might once have been able to support life, and may possibly harbor extant life beneath its surface.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Mars.jpg"));
            PName.Text = "Name: Mars";
            PDesignation.Text = "Designation: Fourth planet in the Solar System";
            PType.Text = "Type: Terrestrial Planet";
            PRadius.Text = "Radius: 3390km";
            PVolume.Text = "Volume: 6.4171 × 10^23 km3";
            PMass.Text = "Mass: 6.39 × 10^23 kg";
            PGravity.Text = "Surface Gravity: 3.711 m/s2";
            PDescription.Text = "Description: Mars is the fourth planet from the sun.\n" +
                "It is a cold, barren world named after the Roman god of war.\n" +
                "Known as the Red Planet due to the presence of iron oxide, giving it a \nreddish tint.\n" +
                "Scientists believe Mars might once have been able to support life, and \nmay possibly harbor extant life beneath its surface.\n";
        }

        private async void Button_Click_Jupiter(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Jupiter is the fifth planet from the sun, and the largest planet in the Solar System.\n" +
                " It is one of four giant planets, the others being Saturn, Uranus and Neptune.\n" +
                " It is a gas giant, and thus has no real 'surface' to speak of - the atmosphere simply gets denser towards the core of the planet.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Jupiter.jpg"));
            PName.Text = "Name: Jupiter";
            PDesignation.Text = "Designation: Fifth planet in the Solar System";
            PType.Text = "Type: Gas Giant";
            PRadius.Text = "Radius: 69911km";
            PVolume.Text = "Volume: 1.4313 × 10^15 km3";
            PMass.Text = "Mass: 1.8982 × 10^27 kg";
            PGravity.Text = "Surface Gravity: 24.79 m/s2";
            PDescription.Text = "Description: Jupiter is the fifth planet from the sun, and the largest planet \nin the Solar System.\n" +
                "It is one of four giant planets, the others being Saturn, Uranus and Neptune.\n" +
                "It is a gas giant, and thus has no real 'surface' to speak of - the atmosphere \nsimply gets denser towards the core of the planet.\n";
        }

        private async void Button_Click_Saturn(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Saturn is the sixth planet from the sun, and the second largest in the Solar System.\n" +
                " It is named after the Roman god of agriculture.\n" +
                " It is most known for its visible rings composed mainly of ice particles.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Saturn.jpg"));
            PName.Text = "Name: Saturn";
            PDesignation.Text = "Designation: Sixth planet in the Solar System";
            PType.Text = "Type: Gas Giant";
            PRadius.Text = "Radius: 58232km";
            PVolume.Text = "Volume: 8.2713 × 10^14 km3";
            PMass.Text = "Mass: 5.6834 × 10^26 kg";
            PGravity.Text = "Surface Gravity: 10.44 m/s2";
            PDescription.Text = "Description: Saturn is the sixth planet from the sun, and the second largest in the \nSolar System.\n" +
                "It is named after the Roman god of agriculture.\n" +
                "It is most known for its visible rings composed mainly of ice particles.\n";
        }

        private async void Button_Click_Uranus(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Uranus is the seventh planet from the sun.\n" +
                " It is composed mainly of hydrogen and helium, but also contains more 'ices' such as water, ammonia and methane.\n" +
                " At -224 degrees Celsius, it has the coldest atmosphere of any planet in the Solar System.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Uranus.jpg"));
            PName.Text = "Name: Uranus";
            PDesignation.Text = "Designation: Seventh planet in the Solar System";
            PType.Text = "Type: Ice Giant";
            PRadius.Text = "Radius: 25362km";
            PVolume.Text = "Volume: 6.833 × 10^13 km3";
            PMass.Text = "Mass: (8.6810±0.0013) × 10^25 kg";
            PGravity.Text = "Surface Gravity: 8.69 m/s2";
            PDescription.Text = "Description: Uranus is the seventh planet from the sun.\n" +
                "It is composed mainly of hydrogen and helium, but also contains more 'ices' \nsuch as water, ammonia and methane.\n" +
                "At -224 degrees Celsius, it has the coldest atmosphere of any planet \nin the Solar System.\n";
        }

        private async void Button_Click_Neptune(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Neptune is the eighth and farthest known planet from the sun in the Solar System.\n" +
                " It is similar in composition to its twin, Uranus.\n" +
                " It is named after the Roman god of the sea.\n" +
                " It is not visible to the naked eye, and was the only planet in the Solar System discovered through mathematical prediction rather than empirical observation.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Neptune.jpg"));
            PName.Text = "Name: Neptune";
            PDesignation.Text = "Designation: Eight planet in the Solar System";
            PType.Text = "Type: Ice Giant";
            PRadius.Text = "Radius: 24622km";
            PVolume.Text = "Volume: 6.254 × 10^13 km3";
            PMass.Text = "Mass: 1.0243 × 10^26 kg";
            PGravity.Text = "Surface Gravity: 11.15 m/s2";
            PDescription.Text = "Description: Neptune is the eighth and farthest known planet from the sun in the \nSolar System.\n" +
                "It is similar in composition to its twin, Uranus.\n" +
                "It is named after the Roman god of the sea.\n" +
                "It is not visible to the naked eye, and was the only planet \nin the Solar System discovered through mathematical prediction rather than \nempirical observation.\n";
        }

        private async void Button_Click_Pluto(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond Neptune.\n" +
                " It was the first Kuiper belt object to be discovered.\n" +
                " It was named after the god of the underworld from classical mythology.\n");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            DisplayPlanet.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Pluto.jpg"));
            PName.Text = "Name: Pluto";
            PDesignation.Text = "Minor-planet Designation: 134340 Pluto (Formerly classified as a planet)";
            PType.Text = "Type: Dwarf Planet";
            PRadius.Text = "Radius: 1188km";
            PVolume.Text = "Volume: (7.057±0.004) × 10^9 km3";
            PMass.Text = "Mass: (1.303±0.003) × 10^22 kg";
            PGravity.Text = "Surface Gravity: 0.620 m/s2";
            PDescription.Text = "Description: Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond Neptune.\n" +
                "It was the first Kuiper belt object to be discovered.\n" +
                "It was named after the god of the underworld from classical mythology.\n";
        }
    }
}
