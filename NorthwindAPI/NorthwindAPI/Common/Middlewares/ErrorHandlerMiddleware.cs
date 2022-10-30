using NorthwindAPI.Common.Exceptions;
using NorthwindAPI.Wrappers;
using System.Net;
using System.Text.Json;

namespace NorthwindAPI.Common.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new Response<string>() { Succeeded = false, Message = error.Message };

                switch (error) //TODO: add more exceptions or custom exceptions
                {
                    case ApiException err:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Message = "Ocurrió un error en la API.";
                        break;
                    case KeyNotFoundException err:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.Message = "Hubo un error al intentar encontrar el ID especificado.";
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Message = "Hubo un error interno del servidor. Intente más tarde.";
                        break;
                }
                var result = JsonSerializer.Serialize(responseModel);
                // agrega al response, el contenido de nuestro responseModel custom
                await response.WriteAsync(result);
            }
        }
    }
}
