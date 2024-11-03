using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExperto
{
    using System;
    using System.Collections.Generic;

    public static class Preguntas
    {
        // Pregunta inicial de fase
        public static string ObtenerPreguntaFase()
        {
            return "¿En qué fase se encuentra el proyecto? (Inicio, Elaboración, Construcción, Transición)";
        }

        // Pregunta inicial de ISO
        public static string ObtenerPreguntaISO()
        {
            return "¿Con qué ISO desea trabajar? (ISO 12207, ISO/IEC 29110, ISO/IEC 25010, ISO/IEC 27001, ISO/IEC 20000)";
        }

        // Preguntas de confirmación para cada ISO, basadas en la fase
        public static List<string> ObtenerPreguntasDeISO(string iso)
        {
            switch (iso)
            {
                case "12207":
                    return new List<string>
                {
                    "¿Necesitas una planificación detallada y documentación completa para la fase de inicio?",
                    "¿Requieres definir límites de tiempo, presupuesto y tecnología desde el inicio?",
                    "¿Deseas realizar una evaluación de viabilidad técnica y financiera antes de avanzar en el desarrollo?"
                };

                case "29110":
                    return new List<string>
                {
                    "¿Estás interesado en un enfoque simplificado y ágil para proyectos de menor envergadura?",
                    "¿Necesitas una gestión de iteraciones desde la fase de inicio para evaluar el progreso continuo?",
                    "¿Planeas realizar una evaluación inicial de habilidades en el equipo para asignar tareas más adelante?"
                };

                case "25010":
                    return new List<string>
                {
                    "¿Es prioritario realizar un análisis de requisitos no funcionales desde la fase de elaboración?",
                    "¿Deseas establecer atributos críticos de calidad para asegurar la usabilidad y seguridad?",
                    "¿Es necesario para el proyecto la modularidad y reusabilidad del diseño desde el inicio?"
                };

                case "27001":
                    return new List<string>
                {
                    "¿Es necesario establecer controles de seguridad en la fase de construcción?",
                    "¿Te interesa realizar análisis de vulnerabilidades desde la fase de construcción?",
                    "¿Se requiere implementar mecanismos de autenticación y gestión de accesos en el proyecto?"
                };

                case "20000":
                    return new List<string>
                {
                    "¿Es importante definir acuerdos de nivel de servicio (SLAs) para garantizar el soporte en producción?",
                    "¿Deseas una preparación del entorno y validación en producción minuciosa en la fase de transición?",
                    "¿Es importante implementar un plan de soporte post-implementación para asegurar la continuidad?"
                };

                default:
                    return new List<string> { "ISO no reconocida. Por favor, elige una de las opciones proporcionadas." };
            }
        }

        // Función para obtener actividades específicas según fase, ISO y prioridad
        public static List<(string Nombre, string Descripcion, string Flujo)> ObtenerActividades(string fase, string iso, string prioridad)
        {
            if (fase.ToLower() == "inicio" && iso == "12207" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
            {
                ("Identificación de los interesados clave", "Identificar y documentar los principales stakeholders.", "Planificación"),
                ("Definición de los objetivos del proyecto", "Establecer los objetivos específicos a lograr.", "Planificación"),
                ("Establecimiento del alcance inicial del proyecto", "Definir los límites del proyecto en su primera etapa.", "Planificación"),
                ("Revisión de los requisitos del cliente", "Validar los requisitos clave con el cliente.", "Análisis"),
                ("Análisis de viabilidad", "Evaluar la viabilidad técnica y financiera.", "Análisis"),
                ("Definición de restricciones del proyecto", "Establecer límites de tiempo, presupuesto y tecnología.", "Planificación"),
                ("Evaluación de riesgos iniciales", "Identificar y analizar riesgos preliminares.", "Análisis"),
                ("Creación de un cronograma preliminar", "Definir una línea de tiempo inicial del proyecto.", "Planificación"),
                ("Asignación de recursos iniciales", "Determinar los recursos disponibles para comenzar.", "Planificación"),
                ("Aprobación de la fase de inicio por los stakeholders", "Obtener la aprobación formal de los interesados.", "Planificación"),

            };
            }
            else if (fase.ToLower() == "inicio" && iso == "12207" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Análisis de tecnologías viables", "Examinar opciones tecnológicas para el proyecto.", "Análisis"),
        ("Revisión y validación de requisitos con usuarios", "Validar los requisitos con los futuros usuarios.", "Análisis"),
        ("Creación del backlog inicial", "Crear una lista de tareas y requisitos.", "Planificación"),
        ("Establecimiento de criterios de aceptación iniciales", "Definir qué debe cumplirse para aprobar cada funcionalidad.", "Análisis"),
        ("Identificación de hitos clave", "Determinar los principales puntos de verificación.", "Planificación"),
        ("Selección de herramientas de gestión de proyectos", "Elegir herramientas para planificación y seguimiento.", "Planificación"),
        ("Definición de métricas de éxito", "Establecer criterios para medir el éxito del proyecto.", "Análisis"),
        ("Evaluación de habilidades del equipo", "Verificar si el equipo cuenta con las habilidades necesarias.", "Análisis"),
        ("Identificación de dependencias críticas", "Documentar dependencias que puedan afectar el proyecto.", "Análisis"),
        ("Definición de roles y responsabilidades", "Asignar responsabilidades específicas dentro del equipo.", "Planificación")
    };

            }

            else if (fase.ToLower() == "inicio" && iso == "12207" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Documentación del alcance inicial", "Crear un documento formal de alcance.", "Documentación"),
        ("Definición de un plan de comunicación", "Establecer cómo se comunicará el equipo.", "Planificación"),
        ("Definición de políticas de calidad", "Definir estándares de calidad para el proyecto.", "Análisis"),
        ("Análisis preliminar de costes", "Realizar un análisis de costos inicial.", "Análisis"),
        ("Definición del entorno de desarrollo", "Configurar el entorno técnico necesario.", "Desarrollo"),
        ("Evaluación de la compatibilidad con otros sistemas", "Asegurar que el proyecto funcione con otros sistemas.", "Análisis"),
        ("Creación de prototipos iniciales", "Desarrollar modelos básicos para verificar el concepto.", "Diseño"),
        ("Planificación de sprints iniciales", "Organizar las primeras tareas en sprints.", "Planificación"),
        ("Definición de requisitos de soporte técnico", "Determinar las necesidades de soporte.", "Soporte"),
        ("Configuración de control de versiones", "Implementar un sistema de control de versiones.", "Desarrollo")
    };
            }
            // Fase de Elaboración - Alta Prioridad
            else if (fase.ToLower() == "elaboración" && iso == "12207" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Refinamiento de requisitos", "Ajustar los requisitos según feedback.", "Análisis"),
        ("Validación de casos de uso", "Asegurar que los casos de uso cubren las interacciones necesarias.", "Pruebas"),
        ("Diseño detallado de la arquitectura", "Crear un diseño profundo del sistema.", "Diseño"),
        ("Evaluación de atributos de calidad", "Identificar y medir calidad en rendimiento y seguridad.", "Análisis"),
        ("Análisis de impacto de requisitos", "Revisar cómo afectan los requisitos el diseño.", "Análisis"),
        ("Desarrollo de prototipo evolutivo", "Crear prototipos avanzados.", "Diseño"),
        ("Diseño de módulos críticos", "Definir componentes principales.", "Diseño"),
        ("Planificación de pruebas de integración", "Preparar un plan para pruebas integradas.", "Pruebas"),
        ("Estrategias de seguridad iniciales", "Establecer seguridad desde el diseño.", "Análisis"),
        ("Definición de interfaces detalladas", "Diseñar interfaces para la usabilidad.", "Diseño")
    };
            }

            // Fase de Elaboración - Media Prioridad
            else if (fase.ToLower() == "elaboración" && iso == "12207" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Implementación de pruebas de rendimiento", "Crear pruebas para medir tiempos de respuesta.", "Pruebas"),
        ("Optimización para escalabilidad", "Preparar el sistema para mayor demanda.", "Diseño"),
        ("Revisión de interoperabilidad", "Asegurar que el sistema se integre con otros.", "Análisis"),
        ("Refinamiento de casos complejos", "Definir casos detallados.", "Análisis"),
        ("Gestión de errores y excepciones", "Planear cómo manejar errores.", "Análisis"),
        ("Aprobación final de arquitectura", "Obtener aprobación de arquitectura.", "Planificación"),
        ("Evaluación de mantenibilidad", "Asegurar que el sistema pueda ser actualizado.", "Análisis"),
        ("Desarrollo del modelo de datos", "Crear el modelo de datos necesario.", "Diseño"),
        ("Estrategias de portabilidad", "Garantizar que el sistema sea portátil.", "Análisis"),
        ("Estrategia de recuperación", "Definir cómo el sistema se recuperará de fallos.", "Planificación")
    };
            }

            // Fase de Elaboración - Baja Prioridad
            else if (fase.ToLower() == "elaboración" && iso == "12207" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de seguridad iniciales", "Verificar la seguridad básica.", "Pruebas"),
        ("Validación del modelo de usabilidad", "Confirmar que la interfaz es fácil de usar.", "Pruebas"),
        ("Capacidad de integración continua", "Asegurar un desarrollo fluido.", "Desarrollo"),
        ("Resiliencia ante fallos", "Evaluar la respuesta a errores.", "Pruebas"),
        ("Sistema de monitoreo inicial", "Crear herramientas de monitoreo.", "Implementación"),
        ("Refinamiento del modelo de datos físico", "Mejorar bases de datos.", "Diseño"),
        ("Gestión de versiones", "Mantener versiones del sistema.", "Desarrollo"),
        ("Accesibilidad del sistema", "Verificar conformidad con accesibilidad.", "Pruebas"),
        ("Validación de diseño de interfaces", "Validar interfaz y experiencia.", "Pruebas"),
        ("Evaluación de modularidad", "Revisar modularidad de componentes.", "Análisis")
    };
            }

            // Fase de Construcción - Alta Prioridad
            else if (fase.ToLower() == "construcción" && iso == "12207" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Implementación de módulos clave", "Desarrollar los componentes principales según el diseño.", "Desarrollo"),
        ("Desarrollo de la base de datos", "Crear la base de datos necesaria para almacenar la información del sistema.", "Desarrollo"),
        ("Codificación de interfaz de usuario", "Implementar la interfaz de usuario definida en la fase de elaboración.", "Desarrollo"),
        ("Pruebas unitarias", "Diseñar y ejecutar pruebas para cada módulo.", "Pruebas"),
        ("Integración continua", "Asegurar que los módulos se integran y funcionan juntos.", "Desarrollo"),
        ("Optimización de rendimiento", "Mejorar la eficiencia y velocidad de los módulos.", "Desarrollo"),
        ("Implementación de lógica de negocio", "Desarrollar la lógica necesaria para el proyecto.", "Desarrollo"),
        ("Codificación de algoritmos específicos", "Crear algoritmos clave que el proyecto requiera.", "Desarrollo"),
        ("Configuración de entorno de pruebas", "Preparar el entorno en el que se harán las pruebas.", "Pruebas"),
        ("Integración de la base de datos", "Asegurar la comunicación fluida entre la base de datos y la aplicación.", "Desarrollo")
    };
            }

            // Fase de Construcción - Media Prioridad
            else if (fase.ToLower() == "construcción" && iso == "12207" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Ajuste de interfaz gráfica", "Mejorar la experiencia de usuario según el feedback.", "Desarrollo"),
        ("Validaciones de entrada", "Asegurar que la entrada de datos sea consistente y segura.", "Desarrollo"),
        ("Generación de informes de salida", "Implementar los reportes que el sistema necesita.", "Desarrollo"),
        ("Documentación de código fuente", "Crear documentación técnica de cada módulo.", "Documentación"),
        ("Automatización de pruebas", "Implementar scripts para pruebas automáticas.", "Pruebas"),
        ("Revisión de seguridad", "Validar que el sistema cumple con requisitos de seguridad.", "Pruebas"),
        ("Integración con sistemas externos", "Habilitar la comunicación con otros sistemas.", "Desarrollo"),
        ("Desarrollo de herramientas de auditoría", "Crear herramientas para auditar la actividad del sistema.", "Desarrollo"),
        ("Optimización de almacenamiento", "Mejorar el uso de recursos de almacenamiento.", "Desarrollo"),
        ("Gestión de fallos", "Implementar estrategias para manejar y resolver fallos.", "Desarrollo")
    };
            }

            // Fase de Construcción - Baja Prioridad
            else if (fase.ToLower() == "construcción" && iso == "12207" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión de políticas de seguridad", "Confirmar que se cumplen las políticas de seguridad.", "Documentación"),
        ("Pruebas de penetración", "Evaluar la seguridad ante posibles ataques.", "Pruebas"),
        ("Monitoreo de transacciones", "Implementar el monitoreo del flujo de datos.", "Implementación"),
        ("Verificación de resiliencia", "Asegurar que el sistema resiste fallos parciales.", "Pruebas"),
        ("Auditoría de actividades", "Habilitar el registro de actividades del sistema.", "Soporte"),
        ("Capacitación en seguridad", "Entrenar al equipo en prácticas de seguridad.", "Soporte"),
        ("Implementación de backups", "Configurar copias de seguridad automáticas.", "Implementación"),
        ("Cumplimiento de normativas de seguridad", "Confirmar que el sistema cumple con regulaciones.", "Documentación"),
        ("Documentación técnica", "Crear documentación que explique la estructura y código.", "Documentación"),
        ("Optimización de acceso a datos", "Mejorar la rapidez en la recuperación de datos.", "Desarrollo")
    };
            }

            else if (fase.ToLower() == "transición" && iso == "12207" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Despliegue en producción", "Implementar el sistema en el entorno de producción.", "Implementación"),
        ("Validación en producción", "Realizar pruebas finales con datos reales.", "Pruebas"),
        ("Capacitación a usuarios", "Enseñar a los usuarios a usar el sistema.", "Soporte"),
        ("Capacitación a soporte", "Entrenar al equipo de soporte técnico.", "Soporte"),
        ("Pruebas de aceptación", "Verificar que se cumplan los requisitos finales.", "Pruebas"),
        ("Documentación de procesos", "Crear documentación de procesos y funcionalidades.", "Documentación"),
        ("Aprobación de operaciones", "Obtener la aprobación final para su funcionamiento.", "Planificación"),
        ("Migración de datos", "Transferir los datos al entorno de producción.", "Implementación"),
        ("Soporte inicial", "Proveer asistencia en la fase de introducción del sistema.", "Soporte"),
        ("Implementación de respaldo", "Configurar mecanismos de respaldo y restauración.", "Implementación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "12207" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Optimización de rendimiento en producción", "Mejorar el rendimiento según resultados reales.", "Implementación"),
        ("Configuración de respaldo", "Asegurar copias de seguridad confiables.", "Implementación"),
        ("Plan de contingencia", "Documentar acciones ante posibles fallos.", "Planificación"),
        ("Migración de datos", "Mover la información necesaria al entorno de producción.", "Implementación"),
        ("Asistencia en transición", "Ofrecer soporte durante la fase de adaptación.", "Soporte"),
        ("Documentación de operaciones", "Crear guías de uso y solución de problemas.", "Documentación"),
        ("Estrategia de continuidad", "Planear acciones para mantener el sistema operativo.", "Planificación"),
        ("Validación de integridad de datos", "Asegurar que la información se mantenga íntegra.", "Pruebas"),
        ("Pruebas de carga", "Verificar que el sistema puede manejar altos volúmenes de usuarios.", "Pruebas"),
        ("Configuración de monitoreo", "Instalar herramientas para vigilar el sistema.", "Implementación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "12207" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión post-implementación", "Evaluar el desempeño inicial del sistema.", "Análisis"),
        ("Ajustes según feedback", "Realizar cambios en base a las opiniones de usuarios.", "Implementación"),
        ("Actualización de soporte", "Ajustar procesos de soporte a nuevos requisitos.", "Soporte"),
        ("Gestión de versiones", "Asegurar un control de versiones adecuado.", "Desarrollo"),
        ("Monitoreo de SLA", "Comprobar que se cumplan los acuerdos de nivel de servicio.", "Soporte"),
        ("Configuración de mesa de ayuda", "Habilitar un punto de contacto para usuarios.", "Soporte"),
        ("Base de conocimiento", "Crear un repositorio de información para resolver problemas.", "Documentación"),
        ("Recuperación ante desastres", "Simular y verificar los planes de recuperación.", "Soporte"),
        ("Plan de mantenimiento", "Crear un programa de actualizaciones y mejoras.", "Planificación"),
        ("Desactivación de versiones anteriores", "Retirar versiones antiguas del sistema.", "Implementación")
    };
            }

            else if (fase.ToLower() == "inicio" && iso == "20000" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Identificación de servicios clave", "Definir y documentar los servicios principales que el sistema debe proporcionar.", "Planificación"),
        ("Establecimiento de objetivos de nivel de servicio (SLAs)", "Definir los acuerdos de nivel de servicio (SLA) necesarios para el proyecto.", "Planificación"),
        ("Análisis de necesidades del cliente", "Identificar las expectativas y requisitos del cliente para los servicios.", "Análisis"),
        ("Definición de alcance de los servicios", "Determinar los límites y alcance de cada servicio a desarrollar.", "Planificación"),
        ("Evaluación de riesgos en la provisión de servicios", "Identificar y documentar los riesgos asociados a los servicios críticos.", "Análisis"),
        ("Asignación de roles de gestión de servicios", "Definir roles específicos para asegurar la calidad en la entrega de servicios.", "Planificación"),
        ("Definición de métricas de desempeño de servicios", "Establecer métricas para evaluar el desempeño y cumplimiento de SLAs.", "Planificación"),
        ("Creación de un plan de comunicación de servicios", "Desarrollar un plan para comunicar detalles de los servicios a stakeholders.", "Planificación"),
        ("Análisis de viabilidad de SLAs", "Verificar que los SLAs propuestos sean factibles y alcanzables.", "Análisis"),
        ("Documentación de los requisitos de servicio iniciales", "Formalizar los requisitos de servicio en un documento.", "Documentación")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "20000" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Identificación de puntos críticos de contacto", "Determinar los puntos de interacción clave entre los usuarios y el servicio.", "Análisis"),
        ("Definición de procedimientos de solicitud de servicio", "Crear procedimientos para que los usuarios puedan solicitar servicios.", "Planificación"),
        ("Evaluación de proveedores de servicio externos", "Analizar la confiabilidad de terceros involucrados en la entrega de servicios.", "Análisis"),
        ("Definición de políticas de soporte y asistencia", "Establecer las políticas para brindar soporte a los usuarios.", "Planificación"),
        ("Definición de niveles de prioridad en incidentes", "Clasificar los incidentes en niveles de prioridad para una mejor gestión.", "Análisis"),
        ("Desarrollo de un plan de respaldo de datos", "Planificar el respaldo de datos críticos para los servicios.", "Planificación"),
        ("Establecimiento de una política de recuperación de desastres", "Crear políticas de recuperación ante posibles fallos de servicio.", "Planificación"),
        ("Creación de un sistema de gestión de cambios", "Implementar un sistema para gestionar los cambios en los servicios.", "Planificación"),
        ("Establecimiento de roles y responsabilidades en servicios", "Asignar tareas específicas al equipo de soporte.", "Planificación"),
        ("Evaluación de compatibilidad de servicios con infraestructura existente", "Asegurar que los nuevos servicios funcionen con la infraestructura actual.", "Análisis")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "20000" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Definición de requisitos de formación en servicios", "Identificar la formación necesaria para el equipo de soporte.", "Planificación"),
        ("Evaluación de políticas de acceso y seguridad en servicios", "Determinar políticas de acceso seguro para el equipo y usuarios.", "Análisis"),
        ("Documentación de mejores prácticas en la gestión de servicios", "Crear un repositorio de prácticas recomendadas.", "Documentación"),
        ("Creación de un sistema de registro de incidentes", "Planificar un sistema para registrar y monitorear los incidentes.", "Planificación"),
        ("Análisis de impacto de los servicios en el usuario final", "Evaluar cómo los servicios afectarán la experiencia del usuario.", "Análisis"),
        ("Identificación de posibles mejoras en servicios", "Registrar sugerencias de mejoras desde la fase de inicio.", "Análisis"),
        ("Establecimiento de un plan de capacitación de usuarios", "Preparar un plan de entrenamiento para usuarios finales.", "Planificación"),
        ("Planificación de auditorías internas de servicios", "Programar auditorías para asegurar la calidad de los servicios.", "Planificación"),
        ("Evaluación de costos de los servicios", "Determinar el costo aproximado de cada servicio planeado.", "Análisis"),
        ("Definición de requisitos de accesibilidad", "Asegurar que los servicios sean accesibles para todos los usuarios.", "Análisis")
    };
            }

            else if (fase.ToLower() == "elaboración" && iso == "20000" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Diseño de la estructura de soporte", "Crear una estructura para gestionar el soporte y asistencia técnica.", "Diseño"),
        ("Establecimiento de controles de cumplimiento de SLAs", "Definir procedimientos para monitorear el cumplimiento de SLAs.", "Planificación"),
        ("Desarrollo de procedimientos de gestión de incidentes", "Crear procesos para identificar y resolver incidentes.", "Diseño"),
        ("Planificación de pruebas de servicio", "Crear un plan de pruebas para verificar el desempeño y confiabilidad de los servicios.", "Pruebas"),
        ("Diseño de políticas de gestión de problemas", "Establecer políticas para gestionar problemas recurrentes en el servicio.", "Diseño"),
        ("Implementación de criterios de escalabilidad en servicios", "Diseñar los servicios para que puedan expandirse según demanda.", "Diseño"),
        ("Establecimiento de medidas de recuperación de datos", "Configurar medidas para recuperar datos en caso de fallos.", "Diseño"),
        ("Desarrollo de plan de soporte técnico en línea", "Crear un plan para ofrecer soporte a través de canales digitales.", "Planificación"),
        ("Definición de roles de escalamiento en incidentes", "Asignar niveles de responsabilidad para resolver problemas.", "Planificación"),
        ("Implementación de procesos de control de calidad en servicios", "Asegurar que los servicios cumplen con los estándares de calidad.", "Planificación")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "20000" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Evaluación de capacidad de servicios", "Asegurar que el sistema puede soportar la carga prevista.", "Análisis"),
        ("Definición de métricas de desempeño de servicios", "Establecer métricas específicas para monitorear el rendimiento.", "Análisis"),
        ("Pruebas de recuperación ante fallos", "Verificar que el sistema puede recuperarse de errores.", "Pruebas"),
        ("Simulación de incidentes", "Realizar pruebas que simulen fallos para analizar la respuesta del sistema.", "Pruebas"),
        ("Planificación de auditorías de calidad de servicio", "Programar auditorías para asegurar la calidad en el servicio.", "Planificación"),
        ("Creación de documentación de soporte técnico", "Desarrollar manuales y guías para el equipo de soporte.", "Documentación"),
        ("Definición de flujos de trabajo en gestión de incidentes", "Crear flujos de trabajo para cada tipo de incidente.", "Diseño"),
        ("Gestión de dependencias en servicios", "Identificar y controlar las dependencias entre servicios y módulos.", "Análisis"),
        ("Implementación de pruebas de carga", "Asegurar que el servicio puede manejar una carga elevada.", "Pruebas"),
        ("Optimización de tiempos de respuesta", "Reducir los tiempos de respuesta del servicio para mejorar la experiencia del usuario.", "Diseño")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "20000" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Documentación de políticas de gestión de cambios", "Crear documentos que describan las políticas de gestión de cambios.", "Documentación"),
        ("Definición de un plan de actualización de servicios", "Planificar actualizaciones periódicas de los servicios.", "Planificación"),
        ("Pruebas de accesibilidad en servicios", "Asegurar que todos los usuarios puedan acceder a los servicios.", "Pruebas"),
        ("Desarrollo de informes de desempeño de servicios", "Generar informes detallados del desempeño durante pruebas.", "Documentación"),
        ("Revisión de escalabilidad en diseño", "Verificar que el diseño permite la escalabilidad sin comprometer la calidad.", "Análisis"),
        ("Evaluación de la sostenibilidad de los servicios", "Asegurar que los servicios son sostenibles a largo plazo.", "Análisis"),
        ("Establecimiento de métricas de satisfacción del cliente", "Crear métricas para evaluar la satisfacción del cliente.", "Planificación"),
        ("Revisión de compatibilidad de servicio con otros sistemas", "Verificar que los servicios sean compatibles con sistemas externos.", "Análisis"),
        ("Planificación de actualización de hardware para soporte de servicios", "Planificar actualizaciones de infraestructura para mejorar servicios.", "Planificación"),
        ("Definición de un plan de entrenamiento para el equipo de soporte", "Crear un programa de formación para el equipo de soporte.", "Planificación")
    };
            }

            else if (fase.ToLower() == "construcción" && iso == "20000" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Implementación de la estructura de soporte", "Configurar el equipo y herramientas para el soporte técnico.", "Desarrollo"),
        ("Desarrollo de la mesa de ayuda", "Crear un sistema de ayuda para la gestión y resolución de incidentes.", "Desarrollo"),
        ("Implementación de SLAs en producción", "Configurar los acuerdos de nivel de servicio en el entorno de producción.", "Implementación"),
        ("Pruebas de aceptación del servicio", "Realizar pruebas de aceptación para garantizar que los servicios cumplen con SLAs.", "Pruebas"),
        ("Implementación de controles de calidad en servicios", "Asegurar que cada servicio cumple con estándares de calidad.", "Implementación"),
        ("Configuración de un sistema de monitoreo de servicios", "Implementar monitoreo en tiempo real de los servicios.", "Implementación"),
        ("Automatización de procesos de gestión de incidentes", "Crear scripts para automatizar la gestión de incidentes.", "Desarrollo"),
        ("Documentación de soporte técnico", "Crear documentación detallada para el equipo de soporte.", "Documentación"),
        ("Configuración de medidas de escalamiento en incidentes", "Establecer protocolos de escalamiento según la gravedad de incidentes.", "Implementación"),
        ("Implementación de controles de recuperación de datos", "Configurar mecanismos para la recuperación de datos en producción.", "Implementación")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "20000" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Evaluación de rendimiento de soporte", "Analizar el desempeño del soporte técnico en el entorno de producción.", "Análisis"),
        ("Pruebas de continuidad del servicio", "Verificar que el servicio se mantenga operativo durante fallos menores.", "Pruebas"),
        ("Desarrollo de documentación de procesos de soporte", "Crear guías que expliquen los procesos de soporte implementados.", "Documentación"),
        ("Optimización de recursos en soporte", "Asegurar que los recursos de soporte son utilizados eficientemente.", "Desarrollo"),
        ("Simulación de fallos en soporte", "Realizar pruebas que simulen fallos en el sistema de soporte.", "Pruebas"),
        ("Validación de recuperación de datos", "Asegurar que el sistema pueda recuperar datos en caso de errores.", "Pruebas"),
        ("Pruebas de capacidad de escalamiento en producción", "Verificar que el sistema puede escalar en respuesta a una demanda creciente.", "Pruebas"),
        ("Documentación de métricas de desempeño de soporte", "Crear informes sobre el desempeño del equipo de soporte.", "Documentación"),
        ("Optimización de tiempo de respuesta en soporte", "Asegurar que el tiempo de respuesta del soporte sea adecuado.", "Desarrollo"),
        ("Implementación de mejoras en el flujo de trabajo de soporte", "Optimizar los procesos del equipo de soporte para aumentar la eficiencia.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "20000" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión de políticas de escalamiento en soporte", "Evaluar y ajustar las políticas de escalamiento en el equipo de soporte.", "Documentación"),
        ("Implementación de procesos de mantenimiento preventivo", "Crear un plan para el mantenimiento preventivo en el sistema de soporte.", "Implementación"),
        ("Evaluación de usabilidad del sistema de soporte", "Asegurar que el sistema de soporte es fácil de usar.", "Pruebas"),
        ("Documentación de acuerdos de nivel de servicio (SLAs)", "Crear documentos formales para todos los SLAs en producción.", "Documentación"),
        ("Revisión de herramientas de soporte técnico", "Evaluar herramientas adicionales que puedan mejorar el soporte.", "Análisis"),
        ("Establecimiento de métricas de eficiencia del soporte", "Definir métricas para evaluar la eficiencia del equipo de soporte.", "Planificación"),
        ("Pruebas de compatibilidad de soporte en diferentes plataformas", "Verificar que el sistema de soporte funcione en diferentes entornos.", "Pruebas"),
        ("Evaluación de seguridad en la gestión de soporte", "Confirmar que el soporte cumple con estándares de seguridad.", "Pruebas"),
        ("Planificación de actualizaciones en soporte", "Preparar actualizaciones para mejorar el sistema de soporte.", "Planificación"),
        ("Gestión de versiones en sistemas de soporte", "Implementar control de versiones en las herramientas de soporte.", "Desarrollo")
    };
            }

            else if (fase.ToLower() == "transición" && iso == "20000" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Preparación del entorno de producción", "Asegurar que el entorno esté listo para el lanzamiento.", "Implementación"),
        ("Pruebas de aceptación finales", "Realizar pruebas finales de aceptación para asegurar la satisfacción del cliente.", "Pruebas"),
        ("Despliegue de servicios en producción", "Implementar los servicios en el entorno de producción.", "Implementación"),
        ("Capacitación en soporte para usuarios finales", "Entrenar a los usuarios en la utilización de los servicios.", "Soporte"),
        ("Implementación de sistema de soporte continuo", "Asegurar que el soporte estará disponible tras el despliegue.", "Implementación"),
        ("Configuración de monitoreo en producción", "Instalar herramientas de monitoreo para la operación en producción.", "Implementación"),
        ("Migración de datos al entorno de producción", "Transferir los datos críticos de manera segura.", "Implementación"),
        ("Configuración de copias de seguridad de producción", "Asegurar que existan copias de respaldo en el entorno de producción.", "Implementación"),
        ("Creación de procedimientos de gestión de incidentes en producción", "Documentar procesos de gestión de incidentes para producción.", "Documentación"),
        ("Definición de métricas de satisfacción del cliente", "Establecer métricas para evaluar la satisfacción del usuario.", "Planificación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "20000" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Optimización de tiempo de respuesta en producción", "Mejorar el rendimiento del sistema en producción.", "Implementación"),
        ("Establecimiento de planes de contingencia en producción", "Crear planes para mitigar riesgos en producción.", "Planificación"),
        ("Documentación de procedimientos operativos", "Formalizar los procedimientos para el funcionamiento en producción.", "Documentación"),
        ("Pruebas de carga y rendimiento en producción", "Verificar que el sistema maneja adecuadamente la carga esperada.", "Pruebas"),
        ("Validación de accesibilidad en producción", "Confirmar que el sistema es accesible para todos los usuarios.", "Pruebas"),
        ("Pruebas de usabilidad para usuarios finales", "Confirmar que el sistema cumple con estándares de usabilidad.", "Pruebas"),
        ("Gestión de cambio en producción", "Documentar y gestionar cambios durante la fase de transición.", "Planificación"),
        ("Establecimiento de un canal de feedback", "Crear mecanismos para recopilar la retroalimentación de usuarios.", "Soporte"),
        ("Configuración de métricas de servicio en producción", "Implementar métricas para monitorear el desempeño del servicio.", "Implementación"),
        ("Definición de un sistema de resolución de incidencias", "Crear un sistema para gestionar incidencias en producción.", "Planificación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "20000" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Evaluación de seguridad post-implementación", "Revisar la seguridad del sistema tras la implementación.", "Análisis"),
        ("Revisión de procesos de soporte en producción", "Ajustar el soporte según las necesidades del usuario.", "Soporte"),
        ("Optimización de uso de recursos en producción", "Asegurar que el sistema utiliza eficientemente los recursos.", "Implementación"),
        ("Monitoreo de métricas de satisfacción del cliente", "Evaluar continuamente la satisfacción del cliente.", "Soporte"),
        ("Revisión y actualización de SLAs", "Ajustar los SLAs según las necesidades del entorno de producción.", "Documentación"),
        ("Actualización de procedimientos de calidad", "Modificar los procedimientos para mantener la calidad en producción.", "Documentación"),
        ("Evaluación de planes de mejora continua", "Asegurar que los planes de mejora se ejecuten regularmente.", "Planificación"),
        ("Documentación de lecciones aprendidas", "Registrar lecciones para mejorar futuros despliegues.", "Documentación"),
        ("Análisis de rendimiento en diferentes entornos", "Confirmar que el sistema funciona bien en distintos entornos.", "Pruebas"),
        ("Planificación de futuras actualizaciones", "Crear un cronograma para próximas mejoras y actualizaciones.", "Planificación")
    };
            }

            else if (fase.ToLower() == "inicio" && iso == "25010" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Definición de requisitos de calidad", "Identificar los atributos de calidad clave para el proyecto, como usabilidad y eficiencia.", "Análisis"),
        ("Identificación de interesados clave", "Determinar los stakeholders con interés en la calidad del producto.", "Planificación"),
        ("Establecimiento de estándares de calidad", "Definir estándares específicos de calidad que debe cumplir el proyecto.", "Planificación"),
        ("Evaluación de necesidades de calidad del cliente", "Entender los requisitos de calidad específicos del cliente.", "Análisis"),
        ("Priorización de atributos de calidad", "Clasificar los atributos de calidad según su importancia para el proyecto.", "Planificación"),
        ("Identificación de limitaciones técnicas para la calidad", "Detectar limitaciones tecnológicas que puedan afectar la calidad del proyecto.", "Análisis"),
        ("Análisis de impacto de calidad", "Evaluar cómo cada atributo de calidad influirá en el diseño del sistema.", "Análisis"),
        ("Definición de objetivos de usabilidad", "Establecer metas claras de usabilidad para guiar el desarrollo del sistema.", "Planificación"),
        ("Definición de métricas de calidad", "Crear métricas que permitan evaluar el cumplimiento de los atributos de calidad.", "Planificación"),
        ("Documentación de requisitos de calidad", "Formalizar los requisitos de calidad en un documento de referencia.", "Documentación")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "25010" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión de estándares de calidad existentes", "Examinar estándares de calidad previos aplicables al proyecto.", "Documentación"),
        ("Definición de criterios de aceptación de calidad", "Especificar los requisitos mínimos de calidad que deben cumplirse.", "Análisis"),
        ("Definición de roles y responsabilidades para la calidad", "Asignar responsabilidades de calidad dentro del equipo.", "Planificación"),
        ("Análisis de compatibilidad de calidad", "Asegurar que el proyecto pueda integrar estándares de calidad sin afectar su rendimiento.", "Análisis"),
        ("Creación de un prototipo inicial centrado en la calidad", "Desarrollar un prototipo para validar conceptos de calidad.", "Diseño"),
        ("Evaluación de herramientas de medición de calidad", "Seleccionar herramientas para medir atributos de calidad.", "Análisis"),
        ("Establecimiento de un plan de validación de calidad", "Definir un plan para validar los atributos de calidad a lo largo del desarrollo.", "Planificación"),
        ("Definición de características de accesibilidad", "Especificar requisitos de accesibilidad que debe cumplir el proyecto.", "Análisis"),
        ("Definición de políticas de control de calidad", "Crear políticas para asegurar la calidad durante todo el proyecto.", "Planificación"),
        ("Establecimiento de mecanismos de feedback del usuario", "Definir cómo se recopilará feedback del usuario para ajustar la calidad.", "Planificación")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "25010" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Documentación de mejores prácticas de calidad", "Registrar prácticas recomendadas de calidad.", "Documentación"),
        ("Análisis de seguridad inicial", "Evaluar la seguridad como parte de la calidad general del proyecto.", "Análisis"),
        ("Evaluación de impacto de la calidad en el tiempo de desarrollo", "Determinar cómo la calidad influirá en los tiempos de desarrollo.", "Análisis"),
        ("Evaluación de la facilidad de mantenimiento", "Asegurar que el diseño permita ajustes y mejoras futuras.", "Análisis"),
        ("Revisión de requisitos no funcionales", "Documentar los requisitos que afectan a la calidad, como rendimiento y portabilidad.", "Documentación"),
        ("Evaluación de riesgos de calidad", "Identificar posibles riesgos que afecten la calidad.", "Análisis"),
        ("Establecimiento de un sistema de control de cambios", "Crear un sistema que controle los cambios para mantener la calidad.", "Planificación"),
        ("Estudio de la reusabilidad de componentes", "Evaluar la posibilidad de reutilizar componentes para mejorar la calidad.", "Análisis"),
        ("Análisis de eficiencia de recursos", "Asegurar que el sistema utiliza eficientemente los recursos disponibles.", "Análisis"),
        ("Establecimiento de un plan de recuperación ante fallos de calidad", "Definir un plan para solucionar problemas de calidad.", "Planificación")
    };
            }

            else if (fase.ToLower() == "elaboración" && iso == "25010" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Definición de arquitectura", "Crear la estructura del sistema.", "Diseño"),
        ("Identificación de atributos críticos de calidad", "Seleccionar atributos clave.", "Análisis"),
        ("Validación de requisitos funcionales", "Confirmar que los requisitos funcionales se cumplen.", "Pruebas"),
        ("Escenarios de calidad críticos", "Probar atributos críticos.", "Pruebas"),
        ("Análisis de requisitos no funcionales", "Revisar cómo afectan al diseño.", "Análisis"),
        ("Implementación de prototipos", "Crear prototipos para validar diseño.", "Diseño"),
        ("Diseño modular y reusabilidad", "Optimizar para reuso.", "Diseño"),
        ("Pruebas de integración tempranas", "Probar integración de módulos.", "Pruebas"),
        ("Estrategia de seguridad", "Asegurar seguridad en diseño.", "Análisis"),
        ("Interfaces centradas en accesibilidad", "Hacer que las interfaces sean accesibles.", "Diseño")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "25010" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de rendimiento", "Ejecutar pruebas para medir eficiencia.", "Pruebas"),
        ("Escalabilidad de la arquitectura", "Evaluar el sistema ante aumento de demanda.", "Análisis"),
        ("Interoperabilidad", "Confirmar que el sistema interactúa con otros.", "Análisis"),
        ("Refinamiento de casos complejos", "Completar casos de uso complejos.", "Análisis"),
        ("Plan de gestión de errores", "Establecer cómo se manejarán errores.", "Análisis"),
        ("Aprobación final de arquitectura", "Confirmar la arquitectura.", "Planificación"),
        ("Facilidad de mantenimiento", "Optimizar el diseño para su mantenimiento.", "Análisis"),
        ("Modelo lógico de datos", "Estructurar datos necesarios.", "Diseño"),
        ("Estrategia de portabilidad", "Preparar el sistema para ambientes distintos.", "Análisis"),
        ("Estrategia de recuperación", "Crear un plan de recuperación ante fallos.", "Planificación")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "25010" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas iniciales de resiliencia", "Realizar pruebas para evaluar la capacidad del sistema de mantenerse operativo ante fallos menores.", "Pruebas"),
        ("Validación de calidad en prototipos alternativos", "Probar prototipos alternativos para analizar la mejora en calidad y rendimiento.", "Pruebas"),
        ("Revisión de modularidad en diseño", "Revisar que los módulos sean independientes y que puedan actualizarse sin afectar otros.", "Análisis"),
        ("Documentación de prácticas de diseño para calidad", "Crear una guía de prácticas de diseño para mantener la calidad en el desarrollo.", "Documentación"),
        ("Pruebas de compatibilidad de calidad en plataformas diversas", "Verificar que el sistema cumpla con los estándares de calidad en diferentes plataformas.", "Pruebas"),
        ("Evaluación de usabilidad con muestras de usuarios", "Probar la usabilidad del sistema con un grupo de usuarios para obtener retroalimentación temprana.", "Pruebas"),
        ("Simulación de escenarios de carga", "Ejecutar pruebas de carga simulada para verificar el desempeño en condiciones intensivas.", "Pruebas"),
        ("Validación de requisitos no funcionales secundarios", "Asegurar que los requisitos secundarios, como accesibilidad y eficiencia energética, se cumplan.", "Pruebas"),
        ("Evaluación de facilidad de mantenimiento", "Verificar que el diseño permita un mantenimiento eficiente y ágil en el futuro.", "Análisis"),
        ("Revisión de estándares de seguridad en diseño", "Comprobar que los estándares de seguridad aplicados sean consistentes y adecuados para el proyecto.", "Análisis")
    };
            }

            else if (fase.ToLower() == "construcción" && iso == "25010" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Implementación de requisitos de calidad en módulos críticos", "Aplicar atributos de calidad en los módulos más importantes.", "Desarrollo"),
        ("Pruebas de calidad en componentes individuales", "Ejecutar pruebas de calidad específicas en cada componente.", "Pruebas"),
        ("Integración de criterios de usabilidad en la interfaz de usuario", "Desarrollar la interfaz con un enfoque en la usabilidad.", "Desarrollo"),
        ("Validación de rendimiento", "Asegurar que el sistema cumple con los requisitos de rendimiento.", "Pruebas"),
        ("Pruebas de funcionalidad y eficiencia en módulos principales", "Validar que los módulos cumplen con los atributos de calidad.", "Pruebas"),
        ("Implementación de accesibilidad en la interfaz de usuario", "Integrar funciones que faciliten el acceso de todos los usuarios.", "Desarrollo"),
        ("Documentación de calidad de código", "Crear documentación que refleje la calidad del código fuente.", "Documentación"),
        ("Automatización de pruebas de calidad", "Crear scripts para pruebas de calidad automatizadas.", "Pruebas"),
        ("Optimización del uso de recursos", "Asegurar que el sistema utiliza eficientemente CPU y memoria.", "Desarrollo"),
        ("Pruebas de escalabilidad del sistema", "Validar que el sistema puede crecer sin perder calidad.", "Pruebas")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "25010" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de seguridad en el sistema", "Verificar que la seguridad cumple con los estándares de calidad.", "Pruebas"),
        ("Implementación de modularidad", "Crear módulos que permitan una fácil integración y modificación.", "Desarrollo"),
        ("Optimización de tiempo de respuesta", "Mejorar la velocidad de respuesta del sistema para una mejor calidad.", "Desarrollo"),
        ("Configuración de herramientas de monitoreo de calidad", "Implementar herramientas que midan el desempeño en tiempo real.", "Implementación"),
        ("Validación de consistencia de datos", "Asegurar que los datos se mantienen consistentes durante el uso.", "Pruebas"),
        ("Creación de informes de calidad", "Generar reportes detallados sobre el cumplimiento de los atributos de calidad.", "Documentación"),
        ("Documentación técnica detallada de los módulos", "Incluir detalles técnicos en la documentación para facilitar mantenimiento.", "Documentación"),
        ("Validación de portabilidad", "Confirmar que el sistema puede funcionar en distintos entornos sin problemas.", "Pruebas"),
        ("Optimización de recursos de almacenamiento", "Asegurar el uso efectivo del espacio de almacenamiento.", "Desarrollo"),
        ("Implementación de medidas de recuperación ante fallos", "Incluir mecanismos que aseguren la recuperación de errores de calidad.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "25010" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de compatibilidad en diferentes plataformas", "Verificar que el sistema funcione en diferentes entornos.", "Pruebas"),
        ("Validación de interfaces de usuario alternativas", "Probar interfaces alternativas para mejorar la accesibilidad.", "Pruebas"),
        ("Gestión de la reusabilidad de código", "Organizar el código para su reutilización en otros módulos o proyectos.", "Desarrollo"),
        ("Monitoreo del uso de recursos durante la ejecución", "Evaluar el consumo de recursos en tiempo de ejecución.", "Implementación"),
        ("Revisión de métricas de calidad de software", "Analizar las métricas obtenidas para mejoras futuras.", "Análisis"),
        ("Documentación de procesos de desarrollo de calidad", "Crear documentación sobre prácticas de desarrollo de calidad.", "Documentación"),
        ("Pruebas de calidad de imagen y sonido", "Validar que los elementos multimedia cumplen con los estándares.", "Pruebas"),
        ("Optimización del rendimiento en dispositivos móviles", "Asegurar que el sistema funcione en móviles.", "Desarrollo"),
        ("Validación de opciones de configuración de calidad", "Probar diferentes configuraciones de calidad en el sistema.", "Pruebas"),
        ("Pruebas de mantenimiento y actualizaciones", "Asegurar que el sistema es fácilmente actualizable y mantenible.", "Pruebas")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "25010" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Validación de calidad en producción", "Ejecutar pruebas finales para asegurar que el sistema cumple con los requisitos de calidad en producción.", "Pruebas"),
        ("Implementación de monitoreo de calidad en tiempo real", "Configurar monitoreo continuo de la calidad en el entorno de producción.", "Implementación"),
        ("Capacitación a usuarios en prácticas de calidad", "Entrenar a los usuarios para usar el sistema conforme a los estándares de calidad.", "Soporte"),
        ("Pruebas de aceptación enfocadas en la calidad", "Verificar que los usuarios estén satisfechos con la calidad del sistema.", "Pruebas"),
        ("Implementación de medidas de recuperación en producción", "Configurar mecanismos de recuperación ante fallos en producción.", "Implementación"),
        ("Documentación de calidad de operaciones", "Crear documentación que describa cómo mantener la calidad en operaciones diarias.", "Documentación"),
        ("Establecimiento de acuerdos de calidad con clientes (SLAs)", "Definir y documentar los niveles de calidad que se mantendrán en producción.", "Planificación"),
        ("Validación de integridad de datos en producción", "Asegurar que los datos estén completos y sin errores en producción.", "Pruebas"),
        ("Implementación de monitoreo de rendimiento en producción", "Asegurar que el rendimiento sea óptimo en el entorno real.", "Implementación"),
        ("Ajustes de configuración para optimización de calidad", "Ajustar la configuración del sistema para maximizar la calidad.", "Implementación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "25010" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Documentación de métricas de rendimiento", "Crear informes con métricas de rendimiento alcanzado en producción.", "Documentación"),
        ("Evaluación de la escalabilidad en producción", "Confirmar que el sistema puede adaptarse a un crecimiento de usuarios.", "Análisis"),
        ("Soporte inicial para resolución de problemas de calidad", "Brindar soporte técnico para abordar problemas de calidad en la transición.", "Soporte"),
        ("Validación de la accesibilidad en producción", "Asegurar que el sistema es accesible para todos los usuarios.", "Pruebas"),
        ("Evaluación de usabilidad en producción", "Confirmar que la experiencia de usuario en producción es satisfactoria.", "Pruebas"),
        ("Implementación de auditorías de calidad periódicas", "Planificar revisiones de calidad periódicas en producción.", "Planificación"),
        ("Monitoreo de SLA de calidad", "Asegurar el cumplimiento de los acuerdos de calidad establecidos.", "Soporte"),
        ("Optimización de tiempos de respuesta en producción", "Ajustar el sistema para reducir tiempos de respuesta.", "Implementación"),
        ("Validación de modularidad en producción", "Asegurar que los módulos del sistema se integran sin problemas.", "Pruebas"),
        ("Documentación de recomendaciones de mejora de calidad", "Crear un documento con sugerencias para futuras mejoras de calidad.", "Documentación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "25010" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión post-implementación de calidad", "Analizar el rendimiento de calidad tras la implementación en producción.", "Análisis"),
        ("Actualización de procedimientos de calidad en producción", "Revisar y mejorar los procesos de calidad implementados.", "Documentación"),
        ("Gestión de versiones de calidad en producción", "Asegurar que las versiones cumplan con los estándares de calidad.", "Desarrollo"),
        ("Optimización de recursos en producción", "Asegurar que el sistema utiliza los recursos eficientemente.", "Implementación"),
        ("Planificación de mejoras continuas de calidad", "Establecer un plan para incrementar la calidad en versiones futuras.", "Planificación"),
        ("Capacitación en mantenimiento de calidad para el equipo de soporte", "Entrenar al equipo de soporte en estándares de calidad.", "Soporte"),
        ("Monitoreo de métricas de satisfacción del usuario", "Supervisar la satisfacción de los usuarios con la calidad del sistema.", "Implementación"),
        ("Evaluación de actualizaciones de calidad", "Analizar cómo futuras actualizaciones pueden mejorar la calidad.", "Análisis"),
        ("Desactivación de configuraciones antiguas de baja calidad", "Retirar configuraciones previas que afecten la calidad.", "Desarrollo"),
        ("Revisión de documentación de calidad y su actualización", "Asegurar que la documentación se mantenga actualizada.", "Documentación")
    };
            }

            else if (fase.ToLower() == "inicio" && iso == "27001" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Identificación de riesgos de seguridad", "Evaluar y documentar los posibles riesgos de seguridad en el proyecto.", "Análisis"),
        ("Definición de objetivos de seguridad", "Establecer los objetivos clave de seguridad para el proyecto.", "Planificación"),
        ("Establecimiento de políticas de seguridad", "Crear políticas de seguridad que regulen el acceso, almacenamiento y manejo de la información.", "Planificación"),
        ("Asignación de roles de seguridad", "Definir responsabilidades específicas de seguridad en el equipo.", "Planificación"),
        ("Análisis de viabilidad de controles de seguridad", "Verificar la viabilidad técnica de las medidas de seguridad.", "Análisis"),
        ("Evaluación de cumplimiento normativo", "Comprobar que el proyecto cumple con normativas legales y estándares de seguridad.", "Análisis"),
        ("Definición de requisitos de autenticación", "Determinar el nivel de autenticación y autorización necesario.", "Análisis"),
        ("Identificación de activos críticos", "Detectar los datos o módulos críticos que deben protegerse.", "Análisis"),
        ("Establecimiento de un plan de respuesta a incidentes", "Definir cómo el equipo debe actuar ante un incidente de seguridad.", "Planificación"),
        ("Evaluación inicial de amenazas y vulnerabilidades", "Realizar un análisis de amenazas y vulnerabilidades que podrían afectar el proyecto.", "Análisis")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "27001" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Plan de comunicación de seguridad", "Desarrollar un plan para comunicar políticas de seguridad al equipo.", "Planificación"),
        ("Capacitación en seguridad básica", "Entrenar al equipo en prácticas de seguridad fundamentales.", "Soporte"),
        ("Evaluación de proveedores de seguridad", "Verificar si los proveedores cumplen con los estándares de seguridad.", "Análisis"),
        ("Definición de criterios de acceso a la información", "Especificar cómo y quiénes pueden acceder a los datos.", "Análisis"),
        ("Creación de políticas de control de acceso", "Desarrollar políticas para gestionar permisos y acceso de usuarios.", "Planificación"),
        ("Identificación de datos confidenciales", "Detectar datos sensibles que requieren protección adicional.", "Análisis"),
        ("Definición de métricas de seguridad", "Establecer métricas para evaluar la efectividad de las medidas de seguridad.", "Planificación"),
        ("Planificación de controles de acceso", "Crear un plan para implementar controles de acceso en el proyecto.", "Planificación"),
        ("Establecimiento de control de versiones en seguridad", "Implementar una gestión de versiones enfocada en la seguridad.", "Desarrollo"),
        ("Documentación de políticas de seguridad", "Crear y organizar documentos de políticas de seguridad del proyecto.", "Documentación")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "27001" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Revisión de políticas de seguridad del cliente", "Alinear las políticas de seguridad del proyecto con las del cliente.", "Documentación"),
        ("Evaluación de requisitos de auditoría de seguridad", "Determinar si se necesita auditoría en seguridad.", "Análisis"),
        ("Planificación de auditorías internas", "Programar revisiones de seguridad en el ciclo de desarrollo.", "Planificación"),
        ("Plan de eliminación de datos", "Definir cómo eliminar datos de manera segura.", "Planificación"),
        ("Análisis de impacto de amenazas", "Evaluar cómo cada amenaza podría afectar el sistema.", "Análisis"),
        ("Documentación de controles de seguridad iniciales", "Registrar controles de seguridad en la fase de inicio.", "Documentación"),
        ("Análisis de riesgos relacionados con terceros", "Identificar riesgos en la colaboración con proveedores externos.", "Análisis"),
        ("Establecimiento de un plan de copias de seguridad", "Crear un plan de copias de seguridad para datos sensibles.", "Planificación"),
        ("Definición de acceso remoto seguro", "Establecer políticas de acceso seguro para el trabajo remoto.", "Planificación"),
        ("Identificación de puntos de acceso críticos", "Detectar puntos del sistema donde podría haber acceso no autorizado.", "Análisis")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "27001" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Diseño de arquitectura segura", "Desarrollar una arquitectura que integre medidas de seguridad.", "Diseño"),
        ("Evaluación de riesgos de seguridad", "Realizar un análisis detallado de los riesgos de seguridad en el diseño.", "Análisis"),
        ("Definición de controles de acceso", "Determinar los mecanismos de control de acceso para cada módulo.", "Diseño"),
        ("Desarrollo de planes de mitigación de amenazas", "Crear estrategias para reducir las amenazas identificadas.", "Planificación"),
        ("Diseño de sistemas de autenticación", "Crear un sistema de autenticación adecuado para el acceso seguro.", "Diseño"),
        ("Validación de requisitos de seguridad", "Confirmar que todos los requisitos de seguridad están cubiertos en el diseño.", "Pruebas"),
        ("Establecimiento de medidas de protección de datos", "Configurar mecanismos para proteger la integridad de los datos.", "Diseño"),
        ("Gestión de riesgos de vulnerabilidad", "Identificar y documentar vulnerabilidades en el sistema.", "Análisis"),
        ("Planificación de auditoría de seguridad", "Preparar una auditoría de seguridad para evaluar la arquitectura.", "Planificación"),
        ("Implementación de cifrado de datos", "Incluir cifrado para proteger datos sensibles.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "27001" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Simulación de amenazas", "Realizar pruebas para simular amenazas y verificar la respuesta del sistema.", "Pruebas"),
        ("Verificación de escalabilidad en seguridad", "Asegurarse de que las medidas de seguridad pueden ampliarse con el sistema.", "Análisis"),
        ("Implementación de controles de auditoría", "Configurar herramientas para auditar las actividades del sistema.", "Desarrollo"),
        ("Gestión de incidentes de seguridad", "Establecer procedimientos para manejar incidentes de seguridad.", "Soporte"),
        ("Validación de acceso seguro", "Probar que el acceso al sistema cumple con los requisitos de seguridad.", "Pruebas"),
        ("Planificación de pruebas de penetración", "Programar pruebas para evaluar la resistencia a intrusiones.", "Planificación"),
        ("Definición de métricas de integridad de datos", "Establecer métricas para controlar la integridad de los datos.", "Análisis"),
        ("Implementación de controles de rastreo de actividad", "Habilitar el seguimiento de acciones en el sistema.", "Desarrollo"),
        ("Documentación de arquitectura de seguridad", "Crear documentación detallada de la seguridad en la arquitectura.", "Documentación"),
        ("Evaluación de usabilidad en sistemas seguros", "Asegurar que el diseño seguro también sea fácil de usar.", "Análisis")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "27001" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Simulación de escenarios de desastre", "Probar la recuperación del sistema ante situaciones de desastre.", "Pruebas"),
        ("Validación de registros de auditoría", "Comprobar que los registros de auditoría capturan datos críticos.", "Pruebas"),
        ("Planificación de gestión de parches de seguridad", "Establecer un plan para aplicar parches de seguridad.", "Planificación"),
        ("Revisión de políticas de acceso físico", "Evaluar el control de acceso físico a los sistemas y datos.", "Análisis"),
        ("Desarrollo de informes de seguridad", "Crear informes detallados sobre el estado de seguridad del proyecto.", "Documentación"),
        ("Gestión de contraseñas seguras", "Establecer normas para la creación y gestión de contraseñas seguras.", "Soporte"),
        ("Revisión de acceso de terceros", "Asegurar que el acceso de terceros esté controlado y monitoreado.", "Análisis"),
        ("Pruebas de acceso a datos críticos", "Probar que el acceso a datos críticos esté limitado y seguro.", "Pruebas"),
        ("Configuración de autenticación multifactor", "Implementar autenticación adicional para acceso seguro.", "Desarrollo"),
        ("Evaluación de políticas de recuperación de datos", "Revisar políticas de recuperación para garantizar la seguridad.", "Análisis")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "27001" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Desarrollo de módulos críticos", "Construir los módulos más importantes.", "Desarrollo"),
        ("Controles de seguridad", "Implementar seguridad en los componentes clave.", "Desarrollo"),
        ("Codificación segura", "Usar prácticas de codificación seguras.", "Desarrollo"),
        ("Verificación de privacidad y protección de datos", "Asegurar que los datos están protegidos.", "Pruebas"),
        ("Pruebas de seguridad en componentes", "Probar la seguridad de cada componente.", "Pruebas"),
        ("Gestión de accesos", "Definir permisos y accesos a cada parte del sistema.", "Desarrollo"),
        ("Mecanismos de autenticación", "Implementar métodos de autenticación sólidos.", "Desarrollo"),
        ("Interfaces de usuario final", "Desarrollar las interfaces finales para los usuarios.", "Desarrollo"),
        ("Pruebas de integración continua", "Validar que los componentes funcionan juntos.", "Pruebas"),
        ("Control de versiones", "Gestionar versiones y cambios de código.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "27001" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Seguridad en bases de datos", "Asegurar y proteger la información almacenada.", "Desarrollo"),
        ("Análisis de vulnerabilidades", "Identificar y resolver debilidades de seguridad.", "Pruebas"),
        ("Funcionalidades de auditoría", "Crear funciones para monitorear la actividad.", "Desarrollo"),
        ("Pruebas funcionales clave", "Asegurar que los requisitos críticos funcionan.", "Pruebas"),
        ("Configuración de gestión de incidentes", "Habilitar una respuesta ante fallos.", "Soporte"),
        ("Documentación técnica", "Describir el diseño y funcionalidad del sistema.", "Documentación"),
        ("Recuperación de fallos", "Habilitar una recuperación rápida de fallos.", "Soporte"),
        ("Consistencia de datos", "Asegurar la integridad de la información.", "Pruebas"),
        ("Validación de rendimiento", "Comprobar que cumple con los tiempos de respuesta.", "Pruebas"),
        ("Cifrado de comunicaciones", "Proteger la información en tránsito.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "27001" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Políticas de seguridad en desarrollo", "Confirmar que se sigue la política de seguridad.", "Documentación"),
        ("Pruebas de penetración", "Evaluar la seguridad ante ataques de prueba.", "Pruebas"),
        ("Monitoreo de actividades", "Vigilar el uso y comportamiento del sistema.", "Implementación"),
        ("Verificación de resiliencia", "Asegurar que el sistema puede seguir operativo ante errores.", "Pruebas"),
        ("Capacidades de auditoría", "Habilitar funciones de auditoría.", "Soporte"),
        ("Capacitación en seguridad", "Entrenar al equipo en seguridad específica.", "Soporte"),
        ("Mecanismos de respaldo", "Implementar copias de seguridad para restauración.", "Implementación"),
        ("Interfaz de usuario segura", "Verificar que la interfaz es segura.", "Pruebas"),
        ("Escalabilidad del sistema", "Asegurar que puede adaptarse a mayor demanda.", "Análisis"),
        ("Cumplimiento de normativas", "Validar que se cumplen todas las normativas de seguridad.", "Documentación")
    };
            }

            else if (fase.ToLower() == "transición" && iso == "27001" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Despliegue seguro en producción", "Asegurar que el sistema se implementa en un entorno seguro.", "Implementación"),
        ("Validación de la seguridad en producción", "Realizar pruebas para garantizar la seguridad en el entorno real.", "Pruebas"),
        ("Pruebas de aceptación en seguridad", "Verificar que se cumplan los requisitos de seguridad definidos.", "Pruebas"),
        ("Capacitación en seguridad para usuarios finales", "Instruir a los usuarios en prácticas de seguridad.", "Soporte"),
        ("Creación de planes de respuesta a incidentes en producción", "Establecer protocolos ante posibles incidentes de seguridad.", "Planificación"),
        ("Establecimiento de monitoreo continuo", "Implementar monitoreo para supervisar la seguridad en tiempo real.", "Implementación"),
        ("Configuración de un sistema de auditoría en producción", "Registrar y monitorear todas las actividades en producción.", "Implementación"),
        ("Migración de datos segura", "Transferir los datos al entorno de producción de manera segura.", "Implementación"),
        ("Documentación de procedimientos de seguridad en producción", "Crear guías detalladas para la seguridad en producción.", "Documentación"),
        ("Configuración de copias de seguridad en producción", "Implementar un sistema de copias de seguridad.", "Implementación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "27001" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de rendimiento con enfoque en seguridad", "Verificar que las medidas de seguridad no afecten el rendimiento.", "Pruebas"),
        ("Optimización de medidas de seguridad", "Mejorar la configuración de seguridad en base a los resultados de pruebas.", "Implementación"),
        ("Establecimiento de un plan de contingencia", "Preparar un plan ante posibles fallos en producción.", "Planificación"),
        ("Soporte durante la transición a producción", "Proveer asistencia para asegurar la estabilidad del sistema.", "Soporte"),
        ("Documentación de las configuraciones de seguridad", "Crear documentos detallados sobre la configuración de seguridad en producción.", "Documentación"),
        ("Definición de acuerdos de nivel de servicio en seguridad (SLAs)", "Asegurar que los acuerdos de servicio incluyan seguridad.", "Planificación"),
        ("Validación de integridad de datos en producción", "Verificar que los datos se mantengan íntegros durante la transición.", "Pruebas"),
        ("Pruebas de carga con requisitos de seguridad", "Asegurar que el sistema mantenga su seguridad bajo alta demanda.", "Pruebas"),
        ("Configuración de accesos y permisos finales", "Ajustar permisos y accesos antes del lanzamiento en producción.", "Implementación"),
        ("Revisión de cumplimiento de políticas de seguridad", "Verificar que se cumplan todas las políticas de seguridad en el entorno final.", "Pruebas")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "27001" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Evaluación de seguridad post-implementación", "Revisar la efectividad de las medidas de seguridad tras la implementación.", "Análisis"),
        ("Realización de ajustes en seguridad según feedback", "Adaptar las configuraciones de seguridad en base a comentarios de los usuarios.", "Implementación"),
        ("Gestión de acceso de usuarios finales", "Supervisar y ajustar los accesos de los usuarios finales tras la implementación.", "Soporte"),
        ("Verificación de registros de auditoría", "Asegurarse de que los registros de auditoría capturen la información necesaria.", "Pruebas"),
        ("Actualización de la base de conocimiento en seguridad", "Documentar los procedimientos y guías de seguridad para soporte.", "Documentación"),
        ("Revisión de las configuraciones de recuperación", "Evaluar la eficacia de los sistemas de recuperación en el entorno final.", "Pruebas"),
        ("Documentación de informes de seguridad post-implementación", "Crear un informe detallado del estado de seguridad post-lanzamiento.", "Documentación"),
        ("Revisión de la mesa de ayuda en seguridad", "Asegurar que el equipo de soporte esté preparado para incidentes de seguridad.", "Soporte"),
        ("Planificación de mejoras continuas en seguridad", "Establecer un plan para futuras mejoras de seguridad en el sistema.", "Planificación"),
        ("Desactivación segura de entornos de prueba", "Retirar entornos de prueba que ya no se utilicen.", "Implementación")
    };
            }

            // ISO/IEC 29110 - FASE DE INICIO

            else if (fase.ToLower() == "inicio" && iso == "29110" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Identificación de stakeholders clave", "Reconocer a los interesados principales.", "Planificación"),
        ("Definición de alcance y objetivos del proyecto", "Determinar la dirección y alcance.", "Planificación"),
        ("Recopilación de requisitos iniciales", "Reunir requisitos de clientes y usuarios.", "Análisis"),
        ("Análisis de riesgos iniciales", "Evaluar los riesgos preliminares.", "Análisis"),
        ("Definición del entorno de desarrollo", "Establecer el ambiente técnico.", "Desarrollo"),
        ("Evaluación de capacidades del equipo", "Medir si el equipo tiene habilidades suficientes.", "Análisis"),
        ("Priorización de requisitos", "Clasificar los requisitos según su importancia.", "Análisis"),
        ("Planificación de iteraciones", "Organizar el trabajo en iteraciones.", "Planificación"),
        ("Aprobación del alcance inicial", "Confirmar el alcance del proyecto.", "Planificación"),
        ("Evaluación de costos preliminares", "Realizar un análisis de presupuesto inicial.", "Análisis")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "29110" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Establecimiento de criterios de aceptación", "Definir condiciones de éxito para cada requisito.", "Análisis"),
        ("Definición de roles y responsabilidades del equipo", "Asignar tareas específicas a los miembros.", "Planificación"),
        ("Definición de casos de uso principales", "Identificar los procesos principales a implementar.", "Análisis"),
        ("Desarrollo de un prototipo inicial", "Crear un modelo funcional preliminar.", "Diseño"),
        ("Planificación de comunicación con stakeholders", "Definir cómo se interactuará con los interesados.", "Planificación"),
        ("Estrategia de pruebas iniciales", "Crear un enfoque inicial para las pruebas.", "Pruebas"),
        ("Identificación de dependencias", "Registrar las relaciones críticas para el proyecto.", "Análisis"),
        ("Definición de módulos clave", "Establecer los componentes centrales.", "Diseño"),
        ("Configuración del sistema de control de versiones", "Asegurar control de versiones.", "Desarrollo"),
        ("Revisión de normativas aplicables", "Verificar conformidad con estándares.", "Documentación")
    };
            }
            else if (fase.ToLower() == "inicio" && iso == "29110" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Elaboración del documento de visión", "Describir la visión general del proyecto.", "Documentación"),
        ("Definición de métricas de éxito del proyecto", "Establecer cómo medir logros.", "Análisis"),
        ("Creación de plan de capacitación", "Planear entrenamientos para usuarios y equipo.", "Soporte"),
        ("Evaluación de herramientas y frameworks", "Seleccionar herramientas adecuadas.", "Análisis"),
        ("Documentación de requisitos no funcionales", "Especificar requisitos de rendimiento y seguridad.", "Documentación"),
        ("Definición inicial de interfaces de usuario", "Crear un diseño preliminar.", "Diseño"),
        ("Planificación de gestión de configuración", "Organizar la gestión de cambios.", "Planificación"),
        ("Estudio de escalabilidad", "Analizar cómo escalar el sistema.", "Análisis"),
        ("Análisis de cumplimiento legal", "Asegurar conformidad legal.", "Análisis"),
        ("Definición de plan de gestión del conocimiento", "Organizar la documentación y conocimiento.", "Documentación")
    };
            }

            // ISO/IEC 29110 - FASE DE ELABORACIÓN

            else if (fase.ToLower() == "elaboración" && iso == "29110" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Refinamiento de requisitos", "Revisar y ajustar los requisitos del proyecto según el feedback recibido.", "Análisis"),
        ("Validación de casos de uso", "Asegurarse de que los casos de uso identifican las interacciones esenciales.", "Pruebas"),
        ("Diseño arquitectónico preliminar", "Crear un diseño básico para la arquitectura del sistema.", "Diseño"),
        ("Identificación de atributos de calidad", "Definir atributos clave como seguridad, rendimiento, y usabilidad.", "Análisis"),
        ("Diseño de prototipo", "Desarrollar un prototipo básico para validar el diseño.", "Diseño"),
        ("Gestión de dependencias críticas", "Identificar y documentar dependencias entre módulos clave.", "Planificación"),
        ("Evaluación de impacto de requisitos", "Analizar cómo los requisitos afectan el diseño general.", "Análisis"),
        ("Planificación de pruebas de integración", "Definir el plan para la integración de módulos y pruebas conjuntas.", "Pruebas"),
        ("Definición de módulos clave", "Especificar los componentes y sus roles en el sistema.", "Diseño"),
        ("Definición de interfaces detalladas", "Crear interfaces de usuario detalladas y fáciles de usar.", "Diseño")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "29110" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas de rendimiento preliminares", "Ejecutar pruebas iniciales para evaluar el rendimiento del sistema.", "Pruebas"),
        ("Optimización para escalabilidad", "Ajustar el sistema para soportar un mayor volumen de usuarios.", "Diseño"),
        ("Evaluación de la interoperabilidad", "Asegurar que el sistema pueda comunicarse con otros sistemas.", "Análisis"),
        ("Revisión de casos de uso complejos", "Revisar y detallar casos de uso complejos.", "Análisis"),
        ("Gestión de errores y excepciones", "Definir cómo el sistema manejará errores.", "Análisis"),
        ("Revisión de arquitectura final", "Obtener la aprobación para el diseño arquitectónico.", "Planificación"),
        ("Evaluación de la mantenibilidad", "Analizar si el sistema puede ser actualizado y mantenido fácilmente.", "Análisis"),
        ("Desarrollo del modelo lógico de datos", "Definir la estructura lógica de los datos del sistema.", "Diseño"),
        ("Evaluación de portabilidad", "Verificar que el sistema pueda adaptarse a diferentes entornos.", "Análisis"),
        ("Definición de plan de recuperación", "Planear la recuperación del sistema en caso de fallos.", "Planificación")
    };
            }
            else if (fase.ToLower() == "elaboración" && iso == "29110" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Pruebas iniciales de seguridad", "Verificar la seguridad del sistema en esta fase.", "Pruebas"),
        ("Validación de la usabilidad", "Asegurarse de que la interfaz es amigable para el usuario.", "Pruebas"),
        ("Implementación de integración continua", "Establecer un proceso de desarrollo continuo y fluido.", "Desarrollo"),
        ("Evaluación de la resiliencia ante fallos", "Probar la capacidad del sistema para funcionar a pesar de errores.", "Pruebas"),
        ("Desarrollo de herramientas de monitoreo", "Crear herramientas para monitorear el sistema en tiempo real.", "Implementación"),
        ("Refinamiento del modelo de datos físico", "Mejorar el modelo de datos para optimizar el rendimiento.", "Diseño"),
        ("Gestión de versiones", "Implementar un control de versiones para los cambios en el sistema.", "Desarrollo"),
        ("Revisión de accesibilidad", "Asegurar que el sistema sea accesible para todos los usuarios.", "Pruebas"),
        ("Validación del diseño de interfaces", "Confirmar que el diseño de las interfaces es efectivo y usable.", "Pruebas"),
        ("Evaluación de la modularidad", "Asegurarse de que los módulos del sistema están claramente definidos y organizados.", "Análisis")
    };
            }

            else if (fase.ToLower() == "construcción" && iso == "29110" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Desarrollo de módulos clave", "Construir los módulos fundamentales del sistema.", "Desarrollo"),
        ("Implementación de la base de datos", "Configurar la base de datos para almacenar y gestionar los datos.", "Desarrollo"),
        ("Desarrollo de la interfaz de usuario", "Crear y codificar la interfaz que utilizarán los usuarios finales.", "Desarrollo"),
        ("Pruebas unitarias", "Diseñar y realizar pruebas para verificar la funcionalidad de cada módulo.", "Pruebas"),
        ("Integración de componentes", "Asegurarse de que los componentes funcionan correctamente al unirse.", "Desarrollo"),
        ("Optimización de rendimiento", "Mejorar la eficiencia del sistema en términos de velocidad y uso de recursos.", "Desarrollo"),
        ("Implementación de la lógica de negocio", "Codificar la lógica que gestionará las operaciones del sistema.", "Desarrollo"),
        ("Configuración de entornos de prueba", "Establecer los entornos necesarios para pruebas seguras.", "Pruebas"),
        ("Integración de la base de datos", "Asegurar la comunicación entre la base de datos y el sistema.", "Desarrollo"),
        ("Automatización de procesos", "Implementar scripts para la automatización de tareas rutinarias.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "29110" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Ajustes de interfaz basados en feedback", "Realizar mejoras a la interfaz de usuario según el feedback.", "Desarrollo"),
        ("Validaciones de seguridad de datos", "Verificar que los datos de entrada sean correctos y seguros.", "Desarrollo"),
        ("Generación de informes y reportes", "Implementar reportes y análisis requeridos por el sistema.", "Desarrollo"),
        ("Documentación técnica del código", "Crear documentación detallada sobre el código del sistema.", "Documentación"),
        ("Automatización de pruebas unitarias", "Crear scripts de prueba automática para validaciones continuas.", "Pruebas"),
        ("Revisión de seguridad del sistema", "Evaluar si el sistema cumple con las normas de seguridad establecidas.", "Pruebas"),
        ("Validación de integración con sistemas externos", "Asegurar la comunicación efectiva con otros sistemas.", "Desarrollo"),
        ("Desarrollo de herramientas de auditoría", "Crear herramientas que permitan auditar las acciones dentro del sistema.", "Desarrollo"),
        ("Optimización de almacenamiento de datos", "Mejorar el uso de almacenamiento para manejar los datos eficientemente.", "Desarrollo"),
        ("Implementación de gestión de fallos", "Configurar mecanismos para gestionar y resolver errores.", "Desarrollo")
    };
            }
            else if (fase.ToLower() == "construcción" && iso == "29110" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Implementación de políticas de seguridad", "Asegurarse de que las políticas de seguridad estén aplicadas en el sistema.", "Documentación"),
        ("Pruebas de seguridad avanzadas", "Realizar pruebas detalladas para verificar la seguridad del sistema.", "Pruebas"),
        ("Monitoreo de actividad del sistema", "Vigilar las transacciones y uso del sistema en tiempo real.", "Implementación"),
        ("Verificación de resiliencia", "Probar la capacidad del sistema para resistir y recuperarse de fallos.", "Pruebas"),
        ("Capacitación en prácticas de seguridad", "Entrenar al equipo en medidas y protocolos de seguridad.", "Soporte"),
        ("Configuración de backups automáticos", "Asegurar que se realicen copias de seguridad automáticas.", "Implementación"),
        ("Cumplimiento de normativas de seguridad", "Confirmar que el sistema cumple con normativas y estándares de seguridad.", "Documentación"),
        ("Revisión técnica de la documentación", "Validar que la documentación refleja correctamente el sistema.", "Documentación"),
        ("Optimización de acceso a datos", "Mejorar el rendimiento de acceso y consulta de datos.", "Desarrollo"),
        ("Revisión de cumplimiento normativo", "Verificar que el sistema cumple con todas las regulaciones aplicables.", "Análisis")
    };
            }

            else if (fase.ToLower() == "transición" && iso == "29110" && prioridad.ToLower() == "alta")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Preparación para el despliegue en producción", "Configurar el entorno para la implementación final del sistema.", "Implementación"),
        ("Pruebas de aceptación finales", "Realizar pruebas para asegurar que el sistema cumple con los requisitos del cliente.", "Pruebas"),
        ("Capacitación a usuarios finales", "Instruir a los usuarios en el uso del sistema.", "Soporte"),
        ("Entrenamiento del equipo de soporte", "Capacitar al equipo que brindará soporte técnico.", "Soporte"),
        ("Validación del sistema en producción", "Realizar pruebas en el entorno real para asegurar su funcionalidad.", "Pruebas"),
        ("Documentación de los procedimientos operativos", "Crear y distribuir guías para el uso y operación del sistema.", "Documentación"),
        ("Configuración de un sistema de soporte", "Implementar una mesa de ayuda para resolver incidencias.", "Soporte"),
        ("Migración de datos a producción", "Transferir datos al entorno de producción.", "Implementación"),
        ("Configuración de copias de seguridad", "Asegurar que el sistema cuente con respaldos automáticos.", "Implementación"),
        ("Implementación de monitoreo continuo", "Configurar herramientas para vigilar el sistema en tiempo real.", "Implementación")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "29110" && prioridad.ToLower() == "media")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Optimización del rendimiento en producción", "Ajustar el sistema para un rendimiento óptimo en el entorno real.", "Implementación"),
        ("Establecimiento de un plan de contingencia", "Preparar acciones en caso de fallos en producción.", "Planificación"),
        ("Migración de datos crítica", "Transferir los datos esenciales para la operación en el entorno de producción.", "Implementación"),
        ("Soporte durante la transición", "Proporcionar soporte temporal mientras el sistema se estabiliza.", "Soporte"),
        ("Documentación de las operaciones", "Crear guías detalladas para el equipo de operaciones.", "Documentación"),
        ("Plan de continuidad del negocio", "Asegurar que el sistema esté preparado para mantener su operación continua.", "Planificación"),
        ("Validación de integridad de datos", "Verificar que los datos migrados sean correctos y completos.", "Pruebas"),
        ("Pruebas de carga en producción", "Evaluar el rendimiento bajo alta demanda.", "Pruebas"),
        ("Configuración de monitoreo", "Establecer sistemas de monitoreo para supervisión continua.", "Implementación"),
        ("Revisión de configuración de seguridad", "Verificar que el entorno de producción cumpla con las políticas de seguridad.", "Pruebas")
    };
            }
            else if (fase.ToLower() == "transición" && iso == "29110" && prioridad.ToLower() == "baja")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
    {
        ("Evaluación de la implementación inicial", "Revisar el desempeño del sistema tras su implementación.", "Análisis"),
        ("Ajustes según feedback de usuarios", "Realizar cambios según la retroalimentación de los usuarios.", "Implementación"),
        ("Actualización de procesos de soporte", "Ajustar los procedimientos de soporte técnico.", "Soporte"),
        ("Control de versiones post-implementación", "Asegurar que las nuevas versiones están controladas.", "Desarrollo"),
        ("Monitoreo de SLA (Service Level Agreements)", "Verificar el cumplimiento de los acuerdos de nivel de servicio.", "Soporte"),
        ("Revisión de la mesa de ayuda", "Asegurarse de que el sistema de soporte esté operativo y efectivo.", "Soporte"),
        ("Actualización de la base de conocimiento", "Crear un repositorio de información de soporte.", "Documentación"),
        ("Pruebas de recuperación ante desastres", "Confirmar que el sistema puede recuperarse tras incidentes críticos.", "Pruebas"),
        ("Planificación de actualizaciones", "Establecer un calendario para mejoras futuras.", "Planificación"),
        ("Desactivación de sistemas anteriores", "Deshabilitar o retirar sistemas antiguos reemplazados.", "Implementación")
    };
            }


            else if (fase == "" && iso == "" && prioridad == "")
            {
                return new List<(string Nombre, string Descripcion, string Flujo)>
                {

                };

            }

            return new List<(string Nombre, string Descripcion, string Flujo)>
        {
            ("Sin resultados", "No se encontraron actividades para la combinación seleccionada.", "N/A")
        };
        }
    }

}