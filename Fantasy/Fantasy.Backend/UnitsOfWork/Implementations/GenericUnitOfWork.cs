using Fantasy.Backend.UnitsOfWork.Interfaces;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.UnitsOfWork.Implementations;

public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
{
    public Task<ActionResponse<T>> AddAsync(T model)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResponse<T>> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResponse<IEnumerable<T>>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ActionResponse<T>> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResponse<T>> UpdateAsync(T model)
    {
        throw new NotImplementedException();
    }
}