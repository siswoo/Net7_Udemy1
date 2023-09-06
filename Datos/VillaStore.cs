using Udemy1_API.Modelos.Dto;

namespace Udemy1_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{ Id = 1, Nombre = "Vista a la Piscina", Ocupantes = 10, MetrosCuadrados = 200 },
            new VillaDto{ Id = 2, Nombre = "Vista a la Playa", Ocupantes = 18, MetrosCuadrados = 450 }
        };
    }
}
