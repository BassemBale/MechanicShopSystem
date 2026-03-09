
using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.Employees;

public static class EmployeeErrors
{
    public static  Error IdRequired =>
        Error.Validation("Employee.Id.Required", "Employee id is required");
    public static  Error FirstNameRequired =>
        Error.Validation("Employee.FirstName.Rquired", "Employee firstName is rquired");
    public static  Error LastNameRequired =>
        Error.Validation("Employee.LastName.Rquired", "Employee lastName is rquired");
    public static  Error RoleInvalid =>
        Error.Validation("Employee.Role.Invalid", "Employee role is invalid");
}
