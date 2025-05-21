using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.ValidationRules.FluentValidation
{
    public class EmployeValidation : AbstractValidator<ResultEmployeeDto>
    {
        public EmployeValidation()
        {
            RuleFor(p => p.FirstName).NotNull().WithMessage("Ad null ola bilməz").NotEmpty().WithMessage("Ad boş ola bilməz")
    .Must(name => !string.IsNullOrWhiteSpace(name)).WithMessage("Ad yalnız boşluqlardan ibarət ola bilməz");
        }
    }
}
