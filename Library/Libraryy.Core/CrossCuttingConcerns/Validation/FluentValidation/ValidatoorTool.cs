using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Libraryy.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatoorTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate((IValidationContext)entity); //49.2 de farklı hocanınkinden başka bir yerden patlarsan ilk burayı düzelt

            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
