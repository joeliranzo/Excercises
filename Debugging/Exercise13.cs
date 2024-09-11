using Newtonsoft.Json;
using System.Net.Http;

namespace Excercises.Debugging
{
    class Exercise13
    {
        public static async Task ExcerciseAsync()
        {
            using HttpClient client = new();

            string respuestaApi = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/ditto");
            dynamic datos = JsonConvert.DeserializeObject(respuestaApi);
            string nombre = datos.nombre;
        }
    }
}
