using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace GuessTheAnimals.Common
{
    public class RequiredFieldValidator : ValidationRule
    {
        public RequiredFieldValidator()
        {

        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString().Length > 0)
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false, "Required Field");
        }

    }
}
