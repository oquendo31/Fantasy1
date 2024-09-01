namespace Fantasy.Frontend.Repositories;

public interface IRepository
{
    //El <T> es generico y puede recibir diferentes clases y no tener que hacer una clase por cada servicio (repositorio generico para cuallquier tipo de dato)
    Task<HttpResponseWrapper<T>> GetAsync<T>(string url);

    Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);

    Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);
}