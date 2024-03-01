using Newtonsoft.Json;
using PlatziFake.Dtos;

namespace PlatziFake.Services
{
    public class PlatziFakeAPI
    {
        HttpClient? httpclient;
        string url = "https://api.escuelajs.co/api/v1/products";


        public async Task<List<Producto>?> GetProductos()
        {
            if (NetworkAccess.Internet == Connectivity.Current.NetworkAccess)//aqui validamos si hay conexion a wifi
            {
                httpclient = new();
                try
                {
                    var respuesta = await httpclient.GetAsync($"{url}");
                    if (respuesta.IsSuccessStatusCode)
                    {
                        var json = await respuesta.Content.ReadAsStringAsync();
                        var ProductosData = JsonConvert.DeserializeObject<List<Producto>>(json);// aqui devolvemos los datos de la api

                        return ProductosData;
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Error", "Al hacer peticion: " + respuesta.StatusCode, "Cerrar");//aqui devolvemos el error que ocurre
                    }
                }
                catch (Exception e)
                {
                    await Shell.Current.DisplayAlert("Error", "ocurrio un error" + e.Message, "cerrar");
                    return null;
                }



            }


            return null;

            ////var response=await httpclient.GetAsync(url);
            //response.EnsureSuccessStatusCode();
        }
    }
}
