using System.Net;

namespace Fantasy.Frontend.Repositories;

public class HttpResponseWrapper<T>
{ /*1.Atributos privados */
    public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage) /*2. Constructores*/
    {
        Response = response;
        Error = error;
        HttpResponseMessage = httpResponseMessage;
    }

    public T? Response { get; } /*3.Propiedades */
    public bool Error { get; }
    public HttpResponseMessage HttpResponseMessage { get; }

    public async Task<string?> GetErrorMessageAsync() /*Es un metodo asicrono y me va devolver un string*/
    {
        if (!Error)
        {
            return null;
        }

        var statusCode = HttpResponseMessage.StatusCode;
        if (statusCode == HttpStatusCode.NotFound)
        {
            return "Recurso no encontrado.";
        }
        if (statusCode == HttpStatusCode.BadRequest)
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
        if (statusCode == HttpStatusCode.Unauthorized)
        {
            return "Tienes que estar logueado para ejecutar esta operación.";
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
            return "No tienes permisos para hacer esta operación.";
        }

        return "Ha ocurrido un error inesperado.";
    }
}