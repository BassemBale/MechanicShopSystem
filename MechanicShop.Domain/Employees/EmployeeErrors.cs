
using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.Employees;

public static class EmployeeErrors
{
    public static readonly Error IdRequired =
        Error.Validation("Employee.Id.Required", "Employee id is required");

    public static readonly Error FirstNameRequired =
        Error.Validation("Employee.FirstName.Rquired", "Employee firstName is rquired");

    public static readonly Error LastNameRequired =
        Error.Validation("Employee.LastName.Rquired", "Employee lastName is rquired");

    public static readonly Error RoleInvalid =
        Error.Validation("Employee.Role.Invalid", "Employee role is invalid");
}
