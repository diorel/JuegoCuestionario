using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace JurgoWeb
{
    public class Pregunta
    {
        public int ID { get; set; }
        public string Texto { get; set; }
        public bool Respueta { get; set; }


        public static void CargarCatalogo() 
        {
            Pregunta[] array = new Pregunta[]
            {
                new Pregunta{ID=1, Texto="¿En Agentia somos especialistas en servicios de Outsourcing?", Respueta=true},
                new Pregunta{ID=2, Texto="¿Somos una empresa 100% mexicana", Respueta=true},
            };
            string json = Serializar(array);
        }

        public static string Serializar(params Pregunta[] preguntas)
        {
            if(preguntas==null) return null;
            return JsonConvert.SerializeObject(preguntas);
        }
        public static Pregunta[] Deserializar(string json)
        {
            return JsonConvert.DeserializeObject<Pregunta[]>(json);
        }

        public static Dictionary<int, Pregunta> CatalogoPreguntas
        {
            get 
            {
                return Pregunta.Deserializar(Properties.Settings.Default.Preguntas).ToDictionary(x => x.ID);
            }
        }

        
    }
}