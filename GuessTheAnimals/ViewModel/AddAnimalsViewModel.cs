using System;
using GuessTheAnimals.Commands;
using GuessTheAnimals.Model;
using System.Xml;
using System.IO;

namespace GuessTheAnimals.ViewModel
{
    public class AddAnimalsViewModel
    {
        public AddAnimalCommand addAnimalCmd { get; set; }
        public AnimalModel animal { get; set; }
        public StateModel state { get; set; }

        //Initialize all models
        public AddAnimalsViewModel()
        {
            addAnimalCmd = new AddAnimalCommand(this);
            animal = new AnimalModel();
            state = new StateModel();
        }
        
        /// <summary>
        /// Add a new animal to datasource (xml) - Add only if all values are provided
        /// </summary>
        public void Add()
        {
            try
            {
                state.ErrorState = string.Empty;
                state.InsertState = string.Empty;
                if (!String.IsNullOrWhiteSpace(animal.Name) && !String.IsNullOrWhiteSpace(animal.Color) && !String.IsNullOrWhiteSpace(animal.Sound) && !String.IsNullOrWhiteSpace(animal.Feature) && !String.IsNullOrWhiteSpace(animal.ImageLoc))
                {
                    XmlDocument xdoc = new XmlDocument();
                    string dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string fname = dirname + "\\AnimalsData.xml";
                    xdoc.Load(fname);

                    XmlNode AnimalNode = xdoc.CreateNode(XmlNodeType.Element, "Animal", null);
                    XmlNode xmlnewAnimalName = xdoc.CreateElement("Name");
                    xmlnewAnimalName.InnerText = animal.Name;
                    XmlNode xmlnewAnimalImgloc = xdoc.CreateElement("Imgloc");
                    xmlnewAnimalImgloc.InnerText = animal.ImageLoc;
                    XmlNode xmlnewAnimalColor = xdoc.CreateElement("Color");
                    xmlnewAnimalColor.InnerText = animal.Color;
                    XmlNode xmlnewAnimalSound = xdoc.CreateElement("Sound");
                    xmlnewAnimalSound.InnerText = animal.Sound;
                    XmlNode xmlnewAnimalFeature = xdoc.CreateElement("Feature");
                    xmlnewAnimalFeature.InnerText = animal.Feature;

                    AnimalNode.AppendChild(xmlnewAnimalName);
                    AnimalNode.AppendChild(xmlnewAnimalImgloc);
                    AnimalNode.AppendChild(xmlnewAnimalColor);
                    AnimalNode.AppendChild(xmlnewAnimalSound);
                    AnimalNode.AppendChild(xmlnewAnimalFeature);

                    xdoc.DocumentElement.AppendChild(AnimalNode);
                    xdoc.Save(fname);
                    state.InsertState = "Animal Added Successfully !!";
                    animal.Name = string.Empty;
                    animal.Feature = string.Empty;
                    animal.ImageLoc = string.Empty;
                    animal.Sound = string.Empty;
                    animal.Color = string.Empty;
                }
                else
                {
                    state.ErrorState = "All Fields are Mandatory";
                }
            }
            catch (Exception ex)
            {
                state.ErrorState = "Error occured - " + ex.Message;
            }
        }
    }
}
