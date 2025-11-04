namespace UdemyNewMicroservice.Basket.Api.Features.Baskets.DeleteBasketItem
{
    public record DeleteBasketItemCommand(Guid Id) : IRequestByServiceResult;

}
