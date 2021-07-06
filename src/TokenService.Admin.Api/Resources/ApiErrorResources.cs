using TokenService.Admin.Api.ExceptionHandling;

namespace TokenService.Admin.Api.Resources
{
    public class ApiErrorResources : IApiErrorResources
    {
        public virtual ApiError CannotSetId()
        {
            return new ApiError
            {
                Code = nameof(CannotSetId),
                Description = ApiErrorResource.CannotSetId
            };
        }
    }
}







