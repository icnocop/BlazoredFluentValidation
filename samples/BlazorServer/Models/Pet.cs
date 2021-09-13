using FluentValidation;

namespace BlazorServer.Models
{
    public class Pet : Animal
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public class PetValidator : AnimalValidator<Pet>
        {
            public PetValidator()
            {
                this.RuleFor(x => x.Name)
                    .NotEmpty();

                this.RuleFor(x => x.Address)
                    .NotNull()
                    /*.SetValidator(new Address.AddressValidator())*/;
            }
        }
    }
}
