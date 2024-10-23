namespace BankAccounts.API.Application.Abstractions
{
    public sealed record Error(string Code, string Message) 
    {
        public readonly static Error None = new(string.Empty, string.Empty);

        public readonly static Error NullValue = new("Error.NullValue", "Un valor Null fue ingresado");
    };
    
}
