using System;

namespace TesteTecnico.AmigosProximos.ConsoleApp.Dll
{
    public class Distancia
    {
        private const int MEDIDA_TERRA_RADIANOS = 6373;

        public static double CalcularDistancia(Amigo amigoVisitando, Amigo amigoProximo)
        {
            double latitude = GrausParaRadianos(amigoProximo.Coordenadas.Latitude - amigoVisitando.Coordenadas.Latitude);
            double longitude = GrausParaRadianos(amigoProximo.Coordenadas.Longitude - amigoVisitando.Coordenadas.Longitude);

            double latLong = Math.Sin(latitude / 2) * Math.Sin(latitude / 2)
                + Math.Cos(GrausParaRadianos(amigoVisitando.Coordenadas.Latitude)) * Math.Cos(GrausParaRadianos(amigoProximo.Coordenadas.Latitude))
                * Math.Sin(longitude / 2) * Math.Sin(longitude / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(latLong)));
            double distancia = MEDIDA_TERRA_RADIANOS * c;

            return distancia;
        }

        private static double GrausParaRadianos(double angulo)
        {
            return Math.PI * angulo / 180.0;
        }
    }
}
