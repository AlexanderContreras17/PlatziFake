namespace PlatziFake.Services
{
    internal abstract class BaseService<T> where T : class
    {
        protected readonly string _baseUrl;
        protected  HttpClient _httpClient;
        public BaseService()
        {
            _baseUrl = "https://api.escuelajs.co/api/v1";
        }
        public async abstract Task Create(T obj);
        public async abstract Task< IEnumerable<T>> GetAll();
        public async abstract Task<T> Get(int id);
        public async abstract Task Delete(int id);
        public async abstract Task Update(T obj);
    }
}