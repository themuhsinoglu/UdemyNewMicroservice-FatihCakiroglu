﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UdemyNewMicroservice.Catalog.Api.Features.Categories.Dtos;
using UdemyNewMicroservice.Catalog.Api.Repositories;
using UdemyNewMicroservice.Shared;
using UdemyNewMicroservice.Shared.Extensions;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories.GetAll
{
    public class GetAllCategoriesQuery : IRequestByServiceResult<List<CategoryDto>>;

    public class GetAllCategoryQueryHandler(AppDbContext context, IMapper mapper)
        : IRequestHandler<GetAllCategoriesQuery, ServiceResult<List<CategoryDto>>>
    {
        public async Task<ServiceResult<List<CategoryDto>>> Handle(GetAllCategoriesQuery request,
             CancellationToken cancellationToken)
        {
            var categories = await context.Categories.ToListAsync(cancellationToken: cancellationToken);
            var categoriesAsDto = mapper.Map<List<CategoryDto>>(categories);
            return ServiceResult<List<CategoryDto>>.SuccessAsOk(categoriesAsDto);
        }
    }

    public static class GetAllCategoriesEndpoint
    {
        public static RouteGroupBuilder GetAllCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapGet("/",
                    async (IMediator mediator) =>
                        (await mediator.Send(new GetAllCategoriesQuery())).ToGenericResult())
                .MapToApiVersion(1, 0)
                .WithName("GetAllCategory");


            return group;
        }
    }
}
