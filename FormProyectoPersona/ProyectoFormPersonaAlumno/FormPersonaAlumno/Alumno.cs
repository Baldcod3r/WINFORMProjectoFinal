using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormPersonaAlumno
{
    public class Alumno : Estudiante, INotas
    {

        private bool adeudaDocumentacion;
        private bool inscripto;
        private int cantidadDeMaterias;

        public bool AdeudaDocumentacion { get => adeudaDocumentacion; set => adeudaDocumentacion = value; }
        public bool Inscripto { get => inscripto; set => inscripto = value; }
        public int CantidadDeMaterias { get => cantidadDeMaterias; set => cantidadDeMaterias = value; }



        public Alumno()
        {

        }
        public Alumno(int id,
            string nombre,
            string apellido,
            string dni,
            string cuil,
            bool estado,
            string carrera,
            bool adeudaDocumentacion,
            bool inscripto,
            int cantidadDeMaterias) : base(id, nombre, apellido, dni, cuil, estado, carrera)
        {
            this.adeudaDocumentacion = true;
            this.inscripto = true;
            this.cantidadDeMaterias = 0;

        }


        List<Alumno> listaAlumno = new List<Alumno>();


        /// <summary>
        /// Este método permite al usuario ingresar los datos de uno o más alumnos y los almacena en la lista de alumnos.
        /// Para cada alumno, solicita información como ID, nombre, apellido, DNI, CUIL, carrera, documentación adeudada,
        /// inscripción, cantidad de materias y estado (regular o no regular). Luego, guarda la lista actualizada en un archivo.
        /// </summary>
        public void CrearAlumno()


        {
            Console.WriteLine("---------Crear Alumnos---------");
            Console.WriteLine("\n");


            // VALIDACION CANTIDAD DE ALUMNOS
            bool alumnosValid = false;

            int cantidadAlumnos = 0;


            while (!alumnosValid)
            {
                Console.WriteLine("Cuantos Alumnos desea ingresar: ");
                string alumnosCant = Console.ReadLine();
                bool esNumCantidadDeAlumnos = int.TryParse(alumnosCant, out cantidadAlumnos);

                if (esNumCantidadDeAlumnos)
                {
                    alumnosValid = true;
                    Console.WriteLine($"Va a ingresar el dato de {cantidadAlumnos} alumnos");
                }

                else
                {
                    Console.WriteLine("Ingrese un numero entero.");
                }

            }


            for (int i = 0; i < cantidadAlumnos; i++)
            {


                //INGRESAR ID
                bool validId = false;
                int id = 0;

                while (!validId)
                {
                    Console.WriteLine("Ingresa el id del alumno :");

                    string idString = Console.ReadLine();

                    bool esNum = int.TryParse(idString, out id);
                    if (esNum && id > 0 && !listaAlumno.Any(alumno => alumno.Id == id))
                    {
                        validId = true;
                        Console.WriteLine("El id guardado es: " + id);
                    }

                    else
                    {
                        Console.WriteLine("El id no es un entero valido y debe ser mayor a 0 o ya existe un id con ese valor.");
                    }
                }



                //INGRESAR NOMBRE DEL ALUMNO

                bool esValido = false;
                string nombre = "";
                while (!esValido)
                {
                    Console.WriteLine("Ingresa el Nombre del alumno: ");
                    nombre = Console.ReadLine();

                    if (SoloLetras(nombre))
                    {
                        esValido = true;
                        Console.WriteLine($"El nombre ingresado es {nombre}.");

                    }

                    else
                    {
                        Console.WriteLine("Ingresa solo letras por favor");
                    }
                }






                //INGRESAR Apellido DEL ALUMNO

                bool apellidoValido = false;
                string apellido = "";


                while (!apellidoValido)
                {
                    Console.WriteLine("Ingresa el Apellido del alumno: ");
                    apellido = Console.ReadLine();

                    if (SoloLetras(apellido))
                    {
                        apellidoValido = true;
                        Console.WriteLine($"El apellido ingresado es {apellido}.");

                    }

                    else
                    {
                        Console.WriteLine("Ingresa solo letras por favor");
                    }
                }

                //INGRESAR DNI

                bool dniValido = false;
                int dni = 0;


                while (!dniValido)
                {
                    Console.WriteLine("Ingresa el Dni del alumno: ");

                    string dniString = Console.ReadLine();
                    bool esNumero = int.TryParse(dniString, out dni);


                    if (esNumero)
                    {
                        dniValido = true;
                        Console.WriteLine("El Dni guardado es: " + dni);
                    }
                    else
                    {
                        Console.WriteLine("El dni no es un entero valido");
                    }
                }




                //INGRESAR CUIL

                bool validarCuil = false;

                double cuil = 0;


                while (!validarCuil)
                {

                    Console.WriteLine("Ingresa el Cuil del alumno: ");
                    string cuilString = Console.ReadLine();
                    bool esEntero = double.TryParse(cuilString, out cuil);

                    if (esEntero)
                    {
                        validarCuil = true;
                        Console.WriteLine("El cuil guardado es: " + cuil);
                    }
                    else
                    {
                        Console.WriteLine("El cuil no es un entero valido");
                    }


                }




                //INGRESAR CARRERA



                bool validarCarrera = false;
                string carrera = "";

                while (!validarCarrera)
                {
                    Console.WriteLine("Ingresa a que carrera pertenece el alumno: ");
                    carrera = Console.ReadLine();
                    validarCarrera = true;

                    if (SoloLetras(carrera))
                    {
                        Console.WriteLine($"La carrera ingresada es {carrera}");
                    }

                    else
                    {
                        Console.WriteLine("Por favor ingresa solo letras");
                    }
                }



                //ADEUDA DOCUMENTACION
                Console.WriteLine("El alumno adeuda documentacion? true/false: ");

                bool valido = false;
                bool adeudaDocumentacion = true;


                while (!valido)
                {
                    try
                    {
                        adeudaDocumentacion = bool.Parse(Console.ReadLine());
                        valido = true;
                        if (adeudaDocumentacion.Equals(true))
                        {
                            Console.WriteLine("El alumno adeuda documentacion");
                        }
                        else if (adeudaDocumentacion.Equals(false))
                        {
                            Console.WriteLine("El alumno no adeuda documentacion");
                        }

                        else
                        {
                            Console.WriteLine("Por favor ingresa true o false.");
                        }
                    }
                    catch (Exception ex)
                    {


                        Console.WriteLine("Error! intenta nuevamente.");
                    }

                }





                //ALUMNO INSCRIPTO
                bool inscriptoValid = false;
                bool inscripto = false;
                string alumnoInscripto;

                while (!inscriptoValid)
                {

                    try
                    {
                        inscriptoValid = true;
                        Console.WriteLine("El alumno esta inscripto? True/False:");
                        inscripto = bool.Parse(Console.ReadLine());

                        if (inscripto.Equals(true))
                        {
                            Console.WriteLine("El alumno esta inscripto");
                        }

                        else if (inscripto.Equals(false))
                        {
                            Console.WriteLine("El alumno debe inscribirse");
                        }

                        else
                        {
                            Console.WriteLine("Por favor ingresa true o false.");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Error! intenta nuevamente.");
                    }

                }



                //INGRESAR MATERIAS

                bool materiaValid = false;
                string materiaString = "";
                int cantMaterias = 0;
                while (!materiaValid)
                {
                    materiaValid = true;
                    Console.WriteLine("Ingrese la cantidad de materias que tiene la carrera");

                    materiaString = Console.ReadLine();

                    bool esInt = int.TryParse(materiaString, out cantMaterias);

                    if (esInt)
                    {
                        Console.WriteLine($"La cantidad de materias de la carrera {carrera} guardada es: " + cantMaterias);
                    }
                    else
                    {
                        Console.WriteLine("La cantidad de materias no es un entero valido");
                    }
                }

                //ESTADO ALUMNO REGULAR/NO REGULAR
                bool estadoValid = false;
                bool estadoBool = false;
                string estado = "";



                while (!estadoValid)
                {

                    try
                    {
                        Console.WriteLine("Ingresa true si el alumno es regular o false si el alumno es no regular: ");
                        estado = Console.ReadLine();

                        if (bool.TryParse(estado, out estadoBool))
                        {
                            estadoValid = true;
                            estadoBool = true;
                            Console.WriteLine("El alumno es regular");
                        }

                        else if (!estadoValid)
                        {
                            estadoBool = false;
                            Console.WriteLine("El alumno no es regular");
                        }
                        else
                        {
                            Console.WriteLine("Ingresa solo true o false por favor.");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Error! intenta nuevamente.");
                    }

                }





                listaAlumno.Add(new Alumno()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni.ToString(),
                    Cuil = cuil.ToString(),
                    Carrera = carrera,
                    AdeudaDocumentacion = adeudaDocumentacion,
                    cantidadDeMaterias = cantMaterias,
                    Inscripto = inscripto,
                    Estado = estadoBool,



                });

                GuardarListaEnArchivo("alumnos.txt", listaAlumno);
                Console.WriteLine("\n");
                Console.WriteLine("Datos guardados correctamente!");


            }




        }


        /// <summary>
        /// Este método verifica si una cadena de texto contiene solo letras (alfabéticas) sin ningún otro carácter.
        /// Devuelve 'true' si la cadena contiene solo letras, o 'false' si contiene al menos un carácter que no es una letra.
        /// </summary>
        /// <param name="letras">La cadena de texto que se desea verificar.</param>
        /// <returns>'true' si la cadena contiene solo letras; 'false' si contiene otros caracteres además de letras.</returns>
        static bool SoloLetras(string letras)
        {

            return Regex.IsMatch(letras, @"^[A-Za-z]+$");
        }

        /// <summary>
        /// Este método verifica si la lista de alumnos está vacía.
        /// Devuelve 'true' si la lista no contiene ningún elemento, indicando que está vacía,
        /// o 'false' si la lista contiene al menos un elemento.
        /// </summary>
        /// <returns>'true' si la lista está vacía; 'false' si la lista no está vacía.</returns>
        private bool ListaVacia()
        {
            if (listaAlumno.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Este método muestra la lista de registros de alumnos almacenados en la memoria.
        /// Si la lista está vacía, se muestra un mensaje indicando que no hay datos.
        /// Si la lista contiene registros, muestra el total de registros y los detalles de cada alumno.
        /// </summary>
        public void Lista()
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }

            else
            {
                Console.WriteLine($"Total de registros en la lista: {listaAlumno.Count}");

                Console.WriteLine("-_-_- LISTA -_-_-");

                foreach (Alumno item in listaAlumno)
                {
                    MostrarDato(item);
                }
            }


        }

        /// <summary>
        /// Este método muestra los detalles de un objeto Alumno en la consola.
        /// Muestra cada atributo del objeto Alumno, como ID, nombre, apellido, DNI, Cuil, Carrera, 
        /// Documentación, Inscripción, Cantidad de Materias y Estado, en formato de texto.
        /// </summary>
        /// <param name="dato">El objeto Alumno cuyos detalles se desean mostrar.</param>
        public void MostrarDato(Alumno dato)
        {
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine($"Id: {dato.Id},Nombre: {dato.Nombre}, Apellido: {dato.Apellido},Dni: {dato.Dni},Cuil: {dato.Cuil},Carrera: {dato.Carrera},Documentacion: {dato.AdeudaDocumentacion},Inscripto: {dato.Inscripto},Materias: {dato.CantidadDeMaterias}, Estado: {dato.Estado}");
        }


        /// <summary>
        /// Este método guarda una lista de objetos de tipo Alumno en un archivo de texto especificado.
        /// Cada objeto Alumno se convierte en una línea de texto en el archivo, con sus atributos separados por comas.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo en el que se guardarán los datos.</param>
        /// <param name="listaAlumno">La lista de objetos Alumno que se desea guardar en el archivo.</param>
        public void GuardarListaEnArchivo(string nombreArchivo, List<Alumno> listaAlumno)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nombreArchivo))
                {
                    foreach (var alumno in listaAlumno)
                    {

                        string linea = $"{alumno.Id},{alumno.Nombre},{alumno.Apellido},{alumno.Dni},{alumno.Cuil},{alumno.Carrera},{alumno.AdeudaDocumentacion},{alumno.Inscripto},{alumno.cantidadDeMaterias},{alumno.Estado}";
                        writer.WriteLine(linea);
                    }
                }

                Console.WriteLine("Datos guardados en el archivo correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar los datos en el archivo: {ex.Message}");
            }
        }



        /// <summary>
        /// Este método muestra el contenido de un archivo de texto en la consola. Lee todas las líneas
        /// del archivo especificado por su nombre y muestra cada línea en la consola.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo que se desea mostrar.</param>
        public void MostrarContenidoArchivo(string nombreArchivo)
        {
            try
            {
                // Lee el contenido del archivo
                string[] lineas = File.ReadAllLines(nombreArchivo);

                // Muestra cada línea en la consola
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            catch
            {
                Console.WriteLine($"Error al mostrar el contenido del archivo");
            }
        }



        /// <summary>
        /// Este método permite buscar un alumno en un archivo de registro por su nombre en minúsculas.
        /// Solicita al usuario que ingrese el nombre del alumno y, si se encuentra, muestra todos los
        /// detalles del alumno correspondiente.
        /// </summary>
        public void BuscarAlumnoPorNombre()
        {
            StreamReader lectura;
            string cadena, alumno;
            bool encontrado;
            string[] campos = new string[10];
            char[] separador = { ',' };
            encontrado = false;

            try
            {
                lectura = File.OpenText("alumnos.txt");
                Console.WriteLine("Ingresa el nombre del alumno que buscas en minusculas: ");
                alumno = Console.ReadLine();
                cadena = lectura.ReadLine();


                while (cadena != null && encontrado == false)
                {
                    campos = cadena.Split(separador);

                    if (campos[1].Trim().ToLower().Equals(alumno))
                    {
                        Console.WriteLine($"Id: {campos[0].Trim()}");
                        Console.WriteLine($"Nombre: {campos[1].Trim()}");
                        Console.WriteLine($"Apellido: {campos[2].Trim()}");
                        Console.WriteLine($"Dni: {campos[3].Trim()}");
                        Console.WriteLine($"Cuil: {campos[4].Trim()}");
                        Console.WriteLine($"Carrera: {campos[5].Trim()}");
                        Console.WriteLine($"Documentacion: {campos[6].Trim()}");
                        Console.WriteLine($"Inscripto: {campos[7].Trim()}");
                        Console.WriteLine($"Materias: {campos[8].Trim()}");
                        Console.WriteLine($"Estado: {campos[9].Trim()}");



                        encontrado = true;

                        Console.WriteLine("Presionen una tecla...");
                    }
                    else
                    {
                        cadena = lectura.ReadLine();
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El alumno {alumno} no fue encontrado!");
                    Console.WriteLine("Presione una tecla...");

                }

            }

            catch (FileNotFoundException fe)
            {

                Console.WriteLine("Error!" + fe.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }

            Console.ReadKey(true);




        }


        /// <summary>
        /// Este método permite eliminar un registro de alumno en un archivo según su ID. 
        /// Se solicita al usuario que ingrese el ID del alumno que desea eliminar y, 
        /// si se encuentra el registro, se elimina del archivo de registro.
        /// </summary>
        public void EliminarAlumnoPorId()
        {

            StreamReader lectura;

            StreamWriter temporal;

            string cadena, alumno;
            bool encontrado;
            string[] campos = new string[10];
            char[] separador = { ',' };
            encontrado = false;

            try
            {
                lectura = File.OpenText("alumnos.txt");
                temporal = File.CreateText("tmp.txt");
                Console.WriteLine("Ingresa el id del alumno que deseas eliminar: ");
                alumno = Console.ReadLine();
                cadena = lectura.ReadLine();


                while (cadena != null)
                {
                    campos = cadena.Split(separador);

                    if (campos[0].Trim().Equals(alumno))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        temporal.WriteLine(cadena);
                    }
                    cadena = lectura.ReadLine();
                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El alumno {alumno} no fue encontrado!");
                    Console.WriteLine("Presione una tecla...");

                }
                else
                {
                    Console.WriteLine("Registro Eliminado!");
                    Console.WriteLine("Presione una tecla...");
                }
                lectura.Close();
                temporal.Close();
                File.Delete("alumnos.txt");
                File.Move("tmp.txt", "alumnos.txt");

            }

            catch (FileNotFoundException fe)
            {

                Console.WriteLine("Error!" + fe.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }

            Console.ReadKey(true);




        }


        /// <summary>
        /// Este método permite editar la información de un alumno en un archivo de registro
        /// según su ID. Los datos del alumno se solicitan al usuario y se actualizan en el archivo.
        /// </summary>
        public void EditarAlumnoPorId()
        {

            StreamReader lectura;

            StreamWriter temporal;

            string cadena, alumno, nuevoNombre,
            nuevoApellido, nuevoDni, nuevoCuil, nuevaCarrera, nuevaDocumentacion, nuevoInscripto, nuevaMateria, respuesta, nuevoEstado;
            bool encontrado;
            string[] campos = new string[10];
            char[] separador = { ',' };
            encontrado = false;

            try
            {
                lectura = File.OpenText("alumnos.txt");
                temporal = File.CreateText("tmp.txt");
                Console.WriteLine("Ingresa el id del alumno que deseas modificar: ");
                alumno = Console.ReadLine();
                cadena = lectura.ReadLine();


                while (cadena != null)
                {
                    campos = cadena.Split(separador);

                    if (campos[0].Trim().Equals(alumno))
                    {

                        Console.WriteLine("##################################################");
                        Console.WriteLine("Registro encontrado");
                        Console.WriteLine($"Id: {campos[0].Trim()}");
                        Console.WriteLine($"Nombre: {campos[1].Trim()}");
                        Console.WriteLine($"Apellido: {campos[2].Trim()}");
                        Console.WriteLine($"Dni: {campos[3].Trim()}");
                        Console.WriteLine($"Cuil: {campos[4].Trim()}");
                        Console.WriteLine($"Carrera: {campos[5].Trim()}");
                        Console.WriteLine($"Documentacion: {campos[6].Trim()}");
                        Console.WriteLine($"Inscripto: {campos[7].Trim()}");
                        Console.WriteLine($"Materias: {campos[8].Trim()}");
                        Console.WriteLine($"Estado: {campos[9].Trim()}");

                        Console.WriteLine("###################################################");
                        encontrado = true;
                        Console.WriteLine("El registro que deseas modificar es el indicado? SI/NO");
                        respuesta = Console.ReadLine();
                        respuesta = respuesta.ToUpper();

                        if (respuesta.Equals("SI"))

                        {
                            Console.WriteLine("Ingresa el nuevo Nombre:");
                            nuevoNombre = Console.ReadLine();

                            Console.WriteLine("Ingresa el nuevo Apellido:");
                            nuevoApellido = Console.ReadLine();

                            Console.WriteLine("Ingresa el nuevo Dni:");
                            nuevoDni = Console.ReadLine();

                            Console.WriteLine("Ingresa el nuevo Cuil:");
                            nuevoCuil = Console.ReadLine();

                            Console.WriteLine("Ingresa la nueva Carrera:");
                            nuevaCarrera = Console.ReadLine();

                            Console.WriteLine("Ingresa el nuevo True/False si adeuda documentacion o no adeuda documentacion");
                            nuevaDocumentacion = Console.ReadLine();

                            Console.WriteLine("Ingresa el nuevo True/False si esta inscripto o no inscripto");
                            nuevoInscripto = Console.ReadLine();

                            Console.WriteLine("Ingresa la cantidad de materias");
                            nuevaMateria = Console.ReadLine();

                            Console.WriteLine("Ingresa True/False si es alumno regular o no regular:");
                            nuevoEstado = Console.ReadLine();






                            //Modificar Registro

                            temporal.WriteLine($"{campos[0]},{nuevoNombre}, {nuevoApellido}, {nuevoDni}, {nuevoCuil}, {nuevaCarrera}, {nuevaDocumentacion}, {nuevoInscripto}, {nuevaMateria}, {nuevoEstado}");

                            Console.WriteLine("Registro Modificado de manera correcta.");
                            Console.WriteLine("Presione una tecla...");

                        }

                        else
                        {
                            temporal.WriteLine(cadena);
                        }

                    }

                    else
                    {
                        temporal.WriteLine(cadena);
                    }

                    cadena = lectura.ReadLine();
                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El alumno {alumno} no fue encontrado!");
                    Console.WriteLine("Presione una tecla...");

                }

                lectura.Close();
                temporal.Close();
                File.Delete("alumnos.txt");
                File.Move("tmp.txt", "alumnos.txt");

            }

            catch (FileNotFoundException fe)
            {

                Console.WriteLine("Error!" + fe.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }

            Console.ReadKey(true);




        }


        /// <summary>
        /// Este método muestra un mensaje que informa al usuario que la nota de los alumnos afectará su regularidad.
        /// No realiza operaciones específicas, solo muestra un mensaje informativo en la consola.
        /// </summary>
        public void Nota()
        {
            Console.WriteLine("La nota de los alumnos afectara la regularidad del mismo");
        }
    }
}
