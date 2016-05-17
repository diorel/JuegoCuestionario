using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JurgoWeb
{
[Serializable]
    public class Respuesta
    {
        public int Id { get; set; }
        public bool? Valor { get; set; }
        public bool Correcta { get 
        {
            if (Valor== null)
            {
                return false; 
            }
            if (Pregunta.CatalogoPreguntas == null)
            {
                throw new InvalidOperationException();
            }
            if (!Pregunta.CatalogoPreguntas.ContainsKey(Id))
            {
                throw new KeyNotFoundException();
            }
            return Pregunta.CatalogoPreguntas[Id].Respueta == Valor.Value;
        } 
        }
    }
}