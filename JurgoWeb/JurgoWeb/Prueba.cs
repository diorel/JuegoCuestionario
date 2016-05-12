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
        public Dictionary<int, bool?> Respuestas { get; set; }
        public Single Resultado
        {
            get
            {
                if (Respuestas == null)       
                {
                    throw new InvalidOperationException();
                }
                if (Pregunta.CatalogoPreguntas == null)
                {
                    throw new InvalidOperationException();
                }
                if(Pregunta.CatalogoPreguntas.Count() == 0)
                {
                    return 0; 
                }

                int respuestasCorrectas = 0;
                foreach (var r in Respuestas.Where(x => x.Value.HasValue))
                {
                    if (r.Value.Value == Pregunta.CatalogoPreguntas[r.Key].Respueta)
                    {
                        respuestasCorrectas++;
                    }

                }
                return Convert.ToSingle(respuestasCorrectas) / Convert.ToSingle(Pregunta.CatalogoPreguntas.Count);

            }
        }

        public Prueba(string nombre , string departamento)
        {
            if ( string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(departamento))
            {
                throw new ArgumentNullException();
            }
            Nombre = nombre;
            Departamento = departamento;
            Inicio = DateTime.Now;
            Fin = null;
            Respuestas = new Dictionary<int,bool?>();
            
            foreach (var elemento in Pregunta.CatalogoPreguntas.OrderBy (x=> x.Key))
            {

                Respuestas.Add(elemento.Key, null);
                
            }
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
            Respuestas[id] = respuesta;
        }

        public void Terminar()
        {
            Fin = DateTime.Now;
 
        }
    }
}