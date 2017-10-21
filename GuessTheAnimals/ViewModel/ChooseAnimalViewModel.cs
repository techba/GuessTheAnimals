using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheAnimals.Commands;
using GuessTheAnimals.Model;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;
using System.Xml.Linq;


namespace GuessTheAnimals.ViewModel
{
    public class ChooseAnimalViewModel
    {
        private const string defatultSelection = "Select";
        public HashSet<string> colorPanel { get; set; }
        public HashSet<string> soundPanel { get; set; }
        public HashSet<string> featurePanel { get; set; }

        public StateModel state { get; set; }

        public AnimalModel animal { get; set; }

        public ChooseAnimalCommand chooseAnimalCmd { get; set; }

        public ChooseAnimalViewModel()
        {
            colorPanel = new HashSet<string>();
            soundPanel = new HashSet<string>();
            featurePanel = new HashSet<string>();
            chooseAnimalCmd = new ChooseAnimalCommand(this);
            animal = new AnimalModel();
            state = new StateModel();
        }
        
        public ObservableCollection<AnimalModel> Animals
        {
            get;
            set;
        }

        public void LoadAnimals()
        {
            Animals = LoadFromXML();
        }

        private ObservableCollection<AnimalModel> LoadFromXML()
        {
            state.ErrorState = string.Empty;
            ObservableCollection<AnimalModel> animals = new ObservableCollection<AnimalModel>();
            try
            {
                colorPanel.Add(defatultSelection);
                soundPanel.Add(defatultSelection);
                featurePanel.Add(defatultSelection);
                string dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                string fname = dirname + "\\AnimalsData.xml";
        
                XDocument doc = XDocument.Load(fname);

                var anlist = from r in doc.Descendants("Animal")
                             select new
                             {
                                 Name = r.Element("Name").Value,
                                 ImageLoc = r.Element("Imgloc").Value,
                                 Color = r.Element("Color").Value,
                                 Sound = r.Element("Sound").Value,
                                 Feature = r.Element("Feature").Value,
                             };

                foreach (var r in anlist)
                {
                    AnimalModel am = new AnimalModel(r.Name, r.ImageLoc, r.Color, r.Sound, r.Feature);
                    colorPanel.Add(r.Color);
                    soundPanel.Add(r.Sound);
                    featurePanel.Add(r.Feature);
                    animals.Add(am);
                }
                state.SelectedColor = state.SelectedFeature = state.SelectedSound = defatultSelection;
            }
            catch (Exception ex)
            {
                state.ErrorState = "Error occurred - " + ex.Message;
            }
            return animals;
        }

        public string findAnimal()
        {
            try
            {
                state.ErrorState = string.Empty;
                //value should not be empty ior default value
                if (!string.IsNullOrWhiteSpace(state.SelectedColor) && !string.IsNullOrWhiteSpace(state.SelectedFeature) && !string.IsNullOrWhiteSpace(state.SelectedSound) && !string.Equals(state.SelectedColor, defatultSelection) && !string.Equals(state.SelectedFeature, defatultSelection) && !string.Equals(state.SelectedSound, defatultSelection))
                {
                    string dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string fname = dirname + "\\AnimalsData.xml";

                    XDocument doc = XDocument.Load(fname);

                    var fieldNames1 = (from n in doc.Descendants("Animal")
                                       where (string)n.Element("Color") == state.SelectedColor
                                       && (string)n.Element("Feature") == state.SelectedFeature
                                       && (string)n.Element("Sound") == state.SelectedSound
                                       select (string)n.Element("Name")).ToList();

                    //XElement xel = doc.Element("Animals")
                    //                           .Elements("Animal")
                    //                           .Where(x => ((string)x.Element("Color") == selectedColor) && ((string)x.Element("Feature") == selectedFeature))
                    //                           .SingleOrDefault();

                    if (fieldNames1.Count > 0)
                    {
                        foreach (string name in fieldNames1)
                        {
                            if (name != null)
                            {
                                animal.Name = "Animal picked by you is " + name;
                                break;
                            }
                        }
                    }
                    else
                    {
                        animal.Name = "Oh Oh, No Animal exists with this combination !!";
                    }
                    state.SelectedColor = state.SelectedFeature = state.SelectedSound = defatultSelection;
                }
                else
                {
                    state.ErrorState = " All fields are Mandatory";
                }
            }
            catch (Exception ex)
            {
                state.ErrorState = "Error occurred - " + ex.Message;
            }
            
            return animal.Name;
        }
    }
}
