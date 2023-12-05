using ProductAPI.Responses;

namespace ProductAPI.Services
{
    public interface IService
    {
        Task<IResponseApi> GetById(int id);

        Task<IResponseApi> GetAll();

        Task<IResponseApi> Create();

        Task<int> Delete(int id);

        Task<int> Update(int id, object obj);
    }
}