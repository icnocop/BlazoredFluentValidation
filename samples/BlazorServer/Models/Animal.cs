using FluentValidation;

namespace BlazorServer.Models
{
    public class Animal
    {
        public int Age { get; set; }

        public class AnimalValidator<T> : AbstractValidator<T>
            where T : Animal
        {
            public AnimalValidator()
            {
                this.RuleFor(x => x.Age)
                    .GreaterThan(0);
            }
        }
    }
}
