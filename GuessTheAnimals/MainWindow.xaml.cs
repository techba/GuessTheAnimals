using System.Windows;
using GuessTheAnimals.ViewModel;


namespace GuessTheAnimals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewAnimalViewControl.Visibility = Visibility.Collapsed;
            AddAnimalViewControl.Visibility = Visibility.Collapsed;
            ChoosetheANimalViewControl.Visibility = Visibility.Collapsed;
            btnReady.Visibility = Visibility.Collapsed;
        }

        private void ViewAnimalViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (ViewAnimalViewControl.Visibility == Visibility.Visible)
            {
                LoadViewAnimals();
            }
        }

        private void LoadViewAnimals()
        {
            ViewAnimalsViewModel viewAnimalsVM = new ViewAnimalsViewModel();
            viewAnimalsVM.LoadAnimals();
            ViewAnimalViewControl.DataContext = viewAnimalsVM;
        }

        private void AddAnimalViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (AddAnimalViewControl.Visibility == Visibility.Visible)
            {
                LoadAddAnimal();
            }
        }

        private void LoadAddAnimal()
        {
            AddAnimalsViewModel addAnimalVM = new AddAnimalsViewModel();
            AddAnimalViewControl.DataContext = addAnimalVM;
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ViewAnimalViewControl.Visibility = Visibility.Visible;
            btnReady.Visibility = Visibility.Visible;
            LoadViewAnimals();
            AddAnimalViewControl.Visibility = Visibility.Collapsed;
            ChoosetheANimalViewControl.Visibility = Visibility.Collapsed;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ViewAnimalViewControl.Visibility = Visibility.Collapsed;
            AddAnimalViewControl.Visibility = Visibility.Visible;
            LoadAddAnimal();
            ChoosetheANimalViewControl.Visibility = Visibility.Collapsed;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Visibility = Visibility.Visible;
            btnAdd.Visibility = Visibility.Visible;
            btnReady.Visibility = Visibility.Collapsed;
            ViewAnimalViewControl.Visibility = Visibility.Collapsed;
            AddAnimalViewControl.Visibility = Visibility.Collapsed;
            ChoosetheANimalViewControl.Visibility = Visibility.Collapsed;
        }

        private void HideButtons()
        {
            btnPlay.Visibility = Visibility.Collapsed;
            btnAdd.Visibility = Visibility.Collapsed;
        }

        private void ChoosetheANimalViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (ChoosetheANimalViewControl.Visibility == Visibility.Visible)
            {
                LoadChooseAnimals();
            }
        }

        private void LoadChooseAnimals()
        {
            ChooseAnimalViewModel chooseAnimalsVM = new ChooseAnimalViewModel();
            chooseAnimalsVM.LoadAnimals();
            ChoosetheANimalViewControl.DataContext = chooseAnimalsVM;
            
        }

        private void btnReady_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Visibility = Visibility.Collapsed;
            btnAdd.Visibility = Visibility.Collapsed;
            ViewAnimalViewControl.Visibility = Visibility.Collapsed;
            AddAnimalViewControl.Visibility = Visibility.Collapsed;
            ChoosetheANimalViewControl.Visibility = Visibility.Visible;
            LoadChooseAnimals();
        }
    }
}
