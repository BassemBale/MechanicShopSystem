namespace MechanicShop.Domain.Common.Results;

public readonly record struct Error
{

    private Error(string code,string description,ErrorKind type)
    {
        this.Code = code;
        this.Description = description;
        this.Type = type;
    }
    public string Code { get; }
    public string Description {  get; }
    public ErrorKind Type { get; }

    public static Error Failure(string code = nameof(Failure), string description = "General Failure.")
        => new (code, description, ErrorKind.Failure);
    public static Error Unexpected(string code = nameof(Unexpected),string description = "Unexpected Error.")
        => new(code, description, ErrorKind.Unexpected);
    public static Error Validation(string code = nameof(Validation), string description = "Validation Error.")
        => new(code, description, ErrorKind.Validation);
    public static Error Conflict(string code = nameof(Conflict), string description = "Conflict Error.")
        => new(code, description, ErrorKind.Conflict);
    public static Error NotFound(string code = nameof(NotFound), string description = "NotFound Error.")
        => new(code, description, ErrorKind.NotFound);
    public static Error UnAuthorized(string code = nameof(UnAuthorized), string description = "UnAuthorized Error.")
        => new(code, description, ErrorKind.UnAuthorized);
    public static Error Forbidden(string code = nameof(Forbidden), string description = "Forbidden Error.")
        => new(code, description, ErrorKind.Forbidden);
}
