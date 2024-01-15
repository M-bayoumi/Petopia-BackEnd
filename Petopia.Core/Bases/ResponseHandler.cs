namespace Petopia.Core.Bases
{
    public class ResponseHandler
    {

        #region Constructor
        public ResponseHandler()
        {
        }
        #endregion

        public Response<T> Deleted<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Deleted Successfully"

            };
        }

        public Response<T> Success<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Added Successfully",
                Meta = Meta
            };
        }
        public Response<T> Unauthorized<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = "UnAuthorized"
            };
        }
        public Response<T> BadRequest<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message == "" ? "Bad Request" : Message
            };
        }

        public Response<T> UnprocessableEntity<T>(string Message)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = Message == "" ? "Unprocessable Entity" : Message
            };
        }

        public Response<T> NotFound<T>(string message)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == "" ? "NotFound" : message
            };
        }

        public Response<T> Created<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Created Successfully",
                Meta = Meta
            };
        }
    }
}
