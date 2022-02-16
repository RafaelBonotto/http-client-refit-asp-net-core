namespace RefitExemplo.API.Response
{
    public class ResultResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public object Data { get; set; }
    }
}
