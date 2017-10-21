using System.ComponentModel;

namespace GuessTheAnimals.Model
{
    public class StateModel : INotifyPropertyChanged
    {

        private string insertState;
        private string errorState;
        private string selectedColor;
        private string selectedSound;
        private string selectedFeature;

        public string SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    RaisePropertyChanged("SelectedColor");
                }
            }
        }

        public string SelectedSound
        {
            get { return selectedSound; }
            set
            {
                if (selectedSound != value)
                {
                    selectedSound = value;
                    RaisePropertyChanged("SelectedSound");
                }
            }
        }

        public string SelectedFeature
        {
            get { return selectedFeature; }
            set
            {
                if (selectedFeature != value)
                {
                    selectedFeature = value;
                    RaisePropertyChanged("SelectedFeature");
                }
            }
        }

        public string InsertState
        {
            get { return insertState; }
            set
            {
                if (insertState != value)
                {
                    insertState = value;
                    RaisePropertyChanged("InsertState");
                }
            }
        }

        public string ErrorState
        {
            get { return errorState; }
            set
            {
                if (errorState != value)
                {
                    errorState = value;
                    RaisePropertyChanged("ErrorState");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
