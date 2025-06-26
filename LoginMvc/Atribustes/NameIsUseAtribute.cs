using System.ComponentModel.DataAnnotations;
using LoginMvc.Services;

namespace LoginMvc.Atribustes;

public class NameIsUseAtribute : ValidationAttribute
{

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var name = value as string;
        var service = (ServiceRepositoryLogin)validationContext.GetService(typeof(ServiceRepositoryLogin));

        var existe =service.ExisteName(name);
        if (existe)
            return new ValidationResult("Este nome já está em uso.");

        return ValidationResult.Success;
    }
}