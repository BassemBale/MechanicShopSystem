using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.Identity;

public static class RefreshTokenErrors
{
    public static readonly Error IdRequired =
        Error.Validation("RefreshToken_Id_Required", "Refresh token ID is required.");

    public static readonly Error TokenRequired =
        Error.Validation("RefreshToken_Token_Required", "Refresh Token Value is Required");

    public static readonly Error UserIdRequired =
        Error.Validation("UserId_Required", "User Id Is Required");
    public static readonly Error ExpiryDateInvalid =
    Error.Validation("RefreshToken_ExpiryDateInvalid", "Expiry date must be in the future");
}
