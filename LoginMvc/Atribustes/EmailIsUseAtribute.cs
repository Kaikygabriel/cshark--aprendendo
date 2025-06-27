using System.ComponentModel.DataAnnotations;
using LoginMvc.Services;

namespace LoginMvc.Atribustes;

public class EmailIsUseAttribute : ValidationAttribute
{
    
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    { 
        var email = value as string;
        var service = (ServiceRepositoryLogin)validationContext.GetService(typeof(ServiceRepositoryLogin));
        
        var existe = service.ExisteEmail(email);
        if (existe)
            return new ValidationResult("Este e-mail já está em uso.");

        return ValidationResult.Success;
    }
}