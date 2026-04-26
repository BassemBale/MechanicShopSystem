using MechanicShop.Application.Common.Interfaces;
using MechanicShop.Application.Features.Customers.Dtos;
using MechanicShop.Application.Features.Customers.Mappers;
using MechanicShop.Domain.Common.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MechanicShop.Application.Features.Customers.Queries.GetCustomerById;

public class GetCustomerByIdQueryHandler(IAppDbContext context,
                                         ILogger<GetCustomerByIdQueryHandler> logger) 
    :IRequestHandler<GetCustomerByIdQuery, Result<CustomerDto>>
{
    private readonly IAppDbContext _context = context;
    private readonly ILogger<GetCustomerByIdQueryHandler> _logger = logger;

    public async Task<Result<CustomerDto>> Handle(GetCustomerByIdQuery request, CancellationToken ct)
    {
        var customer = await _context.Customers.AsNoTracking().Include(x => x.Vehicles)
            .FirstOrDefaultAsync(x => x.Id == request.CustomerId, ct);

        if(customer is null)
        {
            _logger.LogWarning("Customer with id {customerId} not found.", request.CustomerId);
            return Error.NotFound(
                code: "Customer_NotFound",
                description: "$\"Customer with id '{query.CustomerId}' was not found\")"
                );
        }

        return customer.ToDto();
    }
}
