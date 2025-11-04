using UdemyNewMicroservice.Basket.Api.Dtos;

namespace UdemyNewMicroservice.Basket.Api.Features.Baskets.GetBasket
{
    public record GetBasketQuery : IRequestByServiceResult<BasketDto>;
    
}
