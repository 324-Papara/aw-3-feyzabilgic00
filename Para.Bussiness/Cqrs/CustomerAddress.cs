using MediatR;
using Para.Base.Response;
using Para.Schema;

namespace Para.Bussiness.Cqrs;

public record CreateCustomerAddressCommand(CustomerAddressRequest Request) : IRequest<ApiResponse<CustomerAddressResponse>>;
public record UpdateCustomerAddressCommand(long customerAddressId, CustomerAddressRequest Request) : IRequest<ApiResponse>;
public record DeleteCustomerAddressCommand(long customerAddressId) : IRequest<ApiResponse>;
public record GetAllCustomerAddressQuery() : IRequest<ApiResponse<List<CustomerAddressResponse>>>;
public record GetCustomerAddressByIdQuery(long customerAddressId) : IRequest<ApiResponse<CustomerAddressResponse>>;
public record GetCustomerAddressByParametersQuery(long customerAddressId) : IRequest<ApiResponse<List<CustomerAddressResponse>>>;