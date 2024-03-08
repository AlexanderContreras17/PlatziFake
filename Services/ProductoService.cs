using PlatziFake.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziFake.Services
{
    public class ProductoService: BaseService<Producto>
    {
        //internal es para el mismo ensamblado/proyecto
        //Protected solamente es accesible a las clases derivadas
        private readonly string _url;
        private ProductoService()
        {
            _url = $"{_baseUrl}/products";
            _httpClient = new HttpClient();

        }
        public override void Create(Producto obj)
        {
            throw new NotImplementedException();
        }
        public override void Delete(int id) 
        {
            throw new NotImplementedException();
        }
        public override Producto Get(int id)
        {
        }
    }
}
