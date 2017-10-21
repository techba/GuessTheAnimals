using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GuessTheAnimals.ViewModel;

namespace GuessTheAnimals.Commands
{
    public class AddAnimalCommand : ICommand
    {

        private AddAnimalsViewModel addAnimalVM;
        public AddAnimalCommand(AddAnimalsViewModel vm)
        {
            addAnimalVM = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            addAnimalVM.Add();
        }

        public event EventHandler CanExecuteChanged;
    }
}
