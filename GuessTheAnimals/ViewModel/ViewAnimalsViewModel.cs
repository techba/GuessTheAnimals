using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheAnimals.Model;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using GuessTheAnimals.Model;

namespace GuessTheAnimals.ViewModel
{
    public class ViewAnimalsViewModel
    {
        public ObservableCollection<AnimalModel> Animals
        {
            get;
            set;
        }

        public StateModel state { get; set; }

        public ViewAnimalsViewModel()
        {
            state = new StateModel();
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
                string dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string fname = dirname + "\\AnimalsData.xml";
                
                XDocument doc = XDocument.Load(fname);
                var anlist = from r in doc.Descendants("Animal")
                             select new
                             {
                                 Name = r.Element("Name").Value,
                                 ImageLoc =  r.Element("Imgloc").Value,
                                 Color = r.Element("Color").Value,
                                 Sound = r.Element("Sound").Value,
                                 Feature = r.Element("Feature").Value,
                             };

                foreach (var r in anlist)
                {
                    AnimalModel am = new AnimalModel(r.Name, r.ImageLoc, r.Color, r.Sound, r.Feature);
                    animals.Add(am);
                }
            }
            catch (Exception ex)
            {
                state.ErrorState = "Error occured - " + ex.Message;
            }
            return animals;
        }
    }
}
