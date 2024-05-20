namespace ConsoleApp_2024C1_12C_EF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EscuelaDBContexto())
            {
                var estudiante = from s in context.Estudiantes
                                 orderby s.nombreEstudiante
                                 select s;
                foreach (var item in estudiante)
                {
                    Console.WriteLine("Estudiante {0} ", item.nombreEstudiante);
                }
                Console.ReadKey();

                Console.WriteLine("Agregar nuevo alumno..");
                var nuevoAlumno = new Estudiante()
                {
                    nombreEstudiante = "Martin",
                    dniEstudiante = 44345678
                };
                context.Estudiantes.Add(nuevoAlumno);
                context.SaveChanges();
            }
         }
    }
}
