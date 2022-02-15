using Core.CustomEntities;

namespace Api.Responses
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }
        public T Data { get; set; }
        public Metadata Meta { get; set; }

        public ApiResponse(T data, int status)
        {
            Data = data;
            Status = status;
        }
    }
}
