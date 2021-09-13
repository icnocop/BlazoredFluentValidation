using FluentValidation;

namespace BlazorServer.Models
{
    public class Address
    {
        public string Street { get; set; }

        public class AddressValidator : AbstractValidator<Address>
        {
            public AddressValidator()
            {
                this.RuleFor(x => x.Street)
                    .NotEmpty();
            }
        }
    }
}
