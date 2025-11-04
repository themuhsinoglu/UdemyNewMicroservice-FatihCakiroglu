namespace UdemyNewMicroservice.Basket.Api.Features.Baskets.DeleteBasketItem
{
    public class DeleteBasketItemValidator : AbstractValidator<DeleteBasketItemCommand>
    {
        public DeleteBasketItemValidator()
        {
            RuleFor(x=>x.Id).NotEmpty().WithMessage("CourseId is required");
        }
    }
}
