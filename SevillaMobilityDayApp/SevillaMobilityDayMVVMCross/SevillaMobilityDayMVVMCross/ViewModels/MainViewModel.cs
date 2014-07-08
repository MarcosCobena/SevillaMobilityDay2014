using Cirrious.MvvmCross.ViewModels;

namespace SevillaMobilityDay.Core.ViewModels
{
    using System.Collections.Generic;
    using System.Windows.Input;
    using SevillaMobilityDay.Core.Models;
    using PropertyChanged;

    [ImplementPropertyChanged]
    public class MainViewModel : MvxViewModel
    {
		public List<Speaker> Speakers { get; set; }

        private MvxCommand<Speaker> showDetailCommand;

        public ICommand ShowDetailCommand
        {
            get
            {
                showDetailCommand = showDetailCommand ?? new MvxCommand<Speaker>(ShowDetailCommandExecute);
                return showDetailCommand;
            }
        }

        public void Init()
        {
            this.Speakers = new List<Speaker>()
                {
                    new Speaker
                        {
                            Name = "Josu� Yeray",
                            SessionTitle = "[Windows Phone 8.1] Trio de ases: Behaviors, Animations y VisualStates",
                            SessionDescription = "En esta sesi�n vamos a analizar a un trio cl�sico de XAML que nos ayudar� a crear mejores apps tanto para Windows Phone 8.1 como para Windows Store y Universal Apps. Sin duda hablamos del equipo formado por los behaviors, las animaciones y los visual states.",
                            SessionTime = "9:30"
                        },
                    new Speaker
                        {
                            Name = "Javier Su�rez",
                            SessionTitle = "Aplicaciones Universales",
                            SessionDescription = "Desarrolla una �nica vez para pcs, tabletas y tel�fonos. En esta sesi�n aprenderemos como desarrollar aplicaciones unviersales para Windows Phone 8.1 y Windows reutilizando la mayor parte del c�digo.",
                            SessionTime = "10:35"
                        },
                    new Speaker
                        {
                            Name = "Juan Mar�a La�",
                            SessionTitle = "Crea tu juego Multiplataforma con Wave Engine",
                            SessionDescription = "Wave Engine te permite crear un videojuego una sola vez y obtener sus versiones multiplataforma para Windows Phone, Android, iOS, Metro, Mac, Linux, Windows y Ouya sin tener que tocar una l�nea de c�digo. En la sesi�n veremos c�mo trabajar con Wave Engine y generaremos las diferentes versiones de un videojuego hecho con Wave Engine.",
                            SessionTime = "11:40"
                        },
                    new Speaker
                        {
                            Name = "Juan Antonio Cano y Marcos Cobe�a",
                            SessionTitle = "Crea aplicaciones multiplataforma con Xamarin",
                            SessionDescription = "Aprende a sacar todo el provecho a Xamarin y reutiliza la mayor parte del c�digo entre diferentes palataformas, disminuyendo los tiempos de desarrollo y facilitando el mantenimiento.",
                            SessionTime = "12:50"
                        }
                };
        }

        private void ShowDetailCommandExecute(Speaker speaker)
        {
            this.ShowViewModel<DetailsViewModel>(speaker);
        }
    }
}
