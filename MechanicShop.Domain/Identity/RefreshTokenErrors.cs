using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.Identity;

public static class RefreshTokenErrors
{
    public static Error IdRequired =>
        Error.Validation("RefreshToken_Id_Required", "Refresh token ID is required.");

    public static Error TokenRequired =>
        Error.Validation("RefreshToken_Token_Required", "Refresh Token Value is Required");

    public static Error UserIdRequired =>
        Error.Validation("UserId_Required", "User Id Is Required");
    public static Error ExpiryDateInvalid =>
    Error.Validation("RefreshToken_ExpiryDateInvalid", "Expiry date must be in the future");
}
