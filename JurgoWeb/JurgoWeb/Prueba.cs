using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JurgoWeb
{
    [Serializable()]
    public class Prueba
    {
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public Dictionary<int, Respuesta> Respuestas { get; set; }
        public Single Resultado
        {
            get
            {
                if (Respuestas == null)
                {
                    throw new InvalidCastException(); 
                }
                if (Respuestas.Count() == 0)
                {
                    throw new InvalidOperationException();
                }
                return Convert.ToSingle(Respuestas.Count(x => x.Value.Correcta)) / Convert.ToSingle(Respuestas.Count);

            }
        }


        public Prueba(string nombre, string departamento)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(departamento))
            {
                throw new ArgumentNullException();
            }
            Nombre = nombre;
            Departamento = departamento;
            Inicio = DateTime.Now;
            Fin = null;

            Respuestas = Pregunta.CatalogoPreguntas.Values.Select
                (x => new Respuesta { Id = x.ID, Valor = null })
                .ToDictionary(x => x.Id);
        }
        

        public void Contestar(int id, bool respuesta)
        {
            if (Respuestas == null)
            {
                throw new InvalidOperationException();
            }
            if (!Respuestas.ContainsKey(id))
            {
                throw new KeyNotFoundException();                
            }
            Respuestas[id] = new Respuesta{Id = id, Valor = respuesta};
        }

        public void Terminar()
        {
            Fin = DateTime.Now;
 
        }
    }
}