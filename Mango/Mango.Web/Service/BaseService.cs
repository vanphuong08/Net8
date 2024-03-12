using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory )
        {

        }
        public async Task<ResponseDto?> SendAsync(RequestDto requestDto)
        {

        }

        Task<RequestDto?> IBaseService.SendAsync(RequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
