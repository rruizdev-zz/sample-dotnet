using FluentValidation;

namespace SampleDotnet.Application.Query.Item.GetBySearch
{
    public class GetItemsBySearchValidator : AbstractValidator<GetItemsBySearchRequest>
    {
        public GetItemsBySearchValidator()
        {
            RuleFor(x => x.Page).NotNull().GreaterThan(0);
        }
    }
}
