namespace SerrvicioApiCurso.Models
{
    public class GenericResponseModel<T>
    {
        public int statusCode {  get; set; }
        public T data { get; set; }
        public string? message { get; set; }
    }
}
