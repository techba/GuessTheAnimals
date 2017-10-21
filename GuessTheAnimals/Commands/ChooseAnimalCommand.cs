using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GuessTheAnimals.ViewModel;

namespace GuessTheAnimals.Commands
{
    public class ChooseAnimalCommand :ICommand
    {
        private ChooseAnimalViewModel chooseAnimalVM;
        public ChooseAnimalCommand(ChooseAnimalViewModel vm)
        {
            chooseAnimalVM = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            string name = chooseAnimalVM.findAnimal();
        }

        public event EventHandler CanExecuteChanged;
    }
}
