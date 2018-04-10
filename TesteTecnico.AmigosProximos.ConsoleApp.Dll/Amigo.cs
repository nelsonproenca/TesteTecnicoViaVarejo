using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteTecnico.AmigosProximos.ConsoleApp.Dll
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Visitando { get; set; }
        public CoordenadasAmigo Coordenadas { get; set; }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("{0}\n", this.Id);
            retorno.AppendFormat("{0}\n", this.Nome);
            retorno.AppendFormat("{0}\n", this.Visitando);
            retorno.AppendFormat("{0}\n", this.Coordenadas.Latitude);
            retorno.AppendFormat("{0}\n", this.Coordenadas.Longitude);

            return retorno.ToString();
        }
    }
}
