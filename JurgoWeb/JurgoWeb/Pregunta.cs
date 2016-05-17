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
                new Pregunta{ID=1, Texto="La Mejora Continua del Sistema de gestión de Calidad está basado en Ciclo de Deming (Planificar, Hacer, verificar y Actuar).", Respueta=true},
                new Pregunta{ID=2, Texto="Para implementar el Sistema de Gestión de Calidad AGENTIA tuvo que determinar: MACROPROCESO, TABLA DE INTERRELACION DE PROCESOS, DOCUMENTOS MANDATORIOS y SU MANUAL DE CALIDAD", Respueta=true},
                new Pregunta{ID=3, Texto="El alcance de la CERTIFICACIÓN en AGENTIA, es Administración de Nomina y Reclutamiento y Selección.", Respueta=true},
                new Pregunta{ID=4, Texto="La Política de Calidad en Agentia es “Nos comprometemos a proporcionar servicios de calidad, para satisfacer los requisitos de los clientes mediante un sistema de gestión y su mejora continua, basado en el desarrollo integral de nuestra gente", Respueta=true},
                new Pregunta{ID=5, Texto="Los objetivos de la Calidad contemplan aspectos de satisfacción del cliente, mejora continua y desarrollo integral de la gente.", Respueta=true},
                new Pregunta{ID=6, Texto="En AGENTIA están definidas las responsabilidades y autoridades del personal y los procesos, mediante el MACROPROCESO, ORGANIGRAMA y DESCRIPTO DE PUESTO.", Respueta=true},
                new Pregunta{ID=7, Texto="El Representante de la Dirección ante el Sistema de Gestión de Calidad es Jesús Cerda.", Respueta=false},
                new Pregunta{ID=8, Texto="El Representante de la Dirección ante el Sistema de Gestión de Calidad es Elvira Villarreal Ramos.", Respueta=true},
                new Pregunta{ID=9, Texto="El comité de Calidad lo forman La Dirección General, Líder del Sistema de Gestión de Calidad y Dueños de Proceso.", Respueta=false},
                new Pregunta{ID=10, Texto="El comité de Calidad lo forman La Dirección General, Direcciones de área y el Líder del Sistema de Gestión de Calidad. Verdadero", Respueta=true}
                //new Pregunta{ID=11, Texto="Los Dueños de Proceso son las los Responsables de Implementar y mejorar los Procesos que están a su cargo.", Respueta=true},
                //new Pregunta{ID=12, Texto="Existe un proceso de comunicación interna dentro de la organización, que comunica los indicadores del sistema, cambios documentales y/o cualquier información que afecta al Sistema de Gestión de Calidad en AGENTIA.", Respueta=true},
                //new Pregunta{ID=13, Texto="La Biblioteca Documental almacena y resguarda el sistema documental AGENTIA los (Procedimientos, formatos y registros etc.).", Respueta=true},
                //new Pregunta{ID=14, Texto="Existen siete procedimientos mandatorios en AGENTIA, que son básicos para el seguimiento del Sistema de Gestión de Calidad AGENTIA.", Respueta=true},
                //new Pregunta{ID=15, Texto="Los Procedimientos mandatorios son: a) Elaboración de Documentos, a) Control de documentos y Registros, b) Control de Producto no conforme, c) Acciones Correctivas, d) Acciones Preventivas, e) Auditoria Interna, f) Revisión por la Dirección.", Respueta=true}
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