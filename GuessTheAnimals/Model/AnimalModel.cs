using System.ComponentModel;

namespace GuessTheAnimals.Model
{
    public class AnimalModel:INotifyPropertyChanged
    {
        private string name;
        private string imgLoc;
        private string color;
        private string sound;
        private string feature;

        public string Name
        {
            get { return name; }
            set
            {
                if(name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string ImageLoc
        {
            get { return imgLoc; }
            set
            {
                if (imgLoc != value)
                {
                    imgLoc = value;
                    RaisePropertyChanged("ImageLoc");
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    RaisePropertyChanged("Color");
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (sound != value)
                {
                    sound = value;
                    RaisePropertyChanged("Sound");
                }
            }
        }

        public string Feature
        {
            get { return feature; }
            set
            {
                if (feature != value)
                {
                    feature = value;
                    RaisePropertyChanged("Feature");
                }
            }
        }

        public AnimalModel(string Name, string ImageLocation, string Color, string Sound, string Feature)
        {
            name = Name;
            imgLoc = ImageLocation;
            color = Color;
            sound = Sound;
            feature = Feature;
        }

        public AnimalModel()
        { }

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
