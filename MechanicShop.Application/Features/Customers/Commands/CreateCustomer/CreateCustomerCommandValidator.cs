using FluentValidation;

namespace MechanicShop.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("name is required .")
                .MaximumLength(100);

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Invalid Email .")
                .MaximumLength(100);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone Number is required .")
                .Matches(@"^\+?\d{7,15}$").WithMessage("Phone number must be 7 - 15 digits and may start with '+' .");

            RuleFor(x => x.Vehicles)
                .NotNull().WithMessage("Vehicle list cannot be null .")
                .Must(p => p.Count > 0).WithMessage("At least one vehicle is required");

            RuleForEach(x => x.Vehicles).SetValidator(new CreateVehicleCommandValidator());

        }
    }
}
