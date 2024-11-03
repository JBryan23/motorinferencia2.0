using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExperto
{
    using System;
    using System.Collections.Generic;

    public class MotorDeInferencia
    {
        private string faseSeleccionada;
        private string isoSeleccionada;
        private string prioridadSeleccionada;

        public void IniciarChat()
        {
            Console.WriteLine(Preguntas.ObtenerPreguntaFase());
        }

        public void ResponderFase(string fase)
        {
            faseSeleccionada = fase;
            Console.WriteLine(Preguntas.ObtenerPreguntaISO());
        }

        public void ResponderISO(string iso)
        {
            isoSeleccionada = iso;
            List<string> preguntasISO = Preguntas.ObtenerPreguntasDeISO(iso);

            Console.WriteLine("Por favor, responde las siguientes preguntas para confirmar si esta ISO es adecuada:");
            foreach (var pregunta in preguntasISO)
            {
                Console.WriteLine(pregunta);
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "si")
                {
                    Console.WriteLine("Esta ISO podría no ser la más adecuada para sus objetivos.");
                    return;
                }
            }

            Console.WriteLine("¿Desea trabajar con actividades de Alta, Media o Baja prioridad?");
        }

        public void ResponderPrioridad(string prioridad)
        {
            prioridadSeleccionada = prioridad;
            List<(string Nombre, string Descripcion, string Flujo)> actividades = Preguntas.ObtenerActividades(faseSeleccionada, isoSeleccionada, prioridadSeleccionada);

            Console.WriteLine("Actividades recomendadas:");
            foreach (var actividad in actividades)
            {
                Console.WriteLine($"Actividad: {actividad.Nombre}");
                Console.WriteLine($"Descripción: {actividad.Descripcion}");
                Console.WriteLine($"Flujo: {actividad.Flujo}");
                Console.WriteLine();
            }
        }
    }
}