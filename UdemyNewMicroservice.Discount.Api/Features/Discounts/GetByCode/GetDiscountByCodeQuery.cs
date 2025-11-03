namespace UdemyNewMicroservice.Discount.Api.Features.Discounts.GetByCode
{
    public record GetDiscountByCodeQuery(string Code) : IRequestByServiceResult<GetDiscountByCodeQueryResponse>;
}

