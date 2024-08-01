namespace LSPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cursos
            Course onlineCourse = new OnlineCourse
            {
                CourseId = 1,
                Title = "Curso Programacion Web Orientado a objetos"
            };

            Course offlineCourse = new OfflineCourse
            {
                CourseId = 2,
                Title = "Curso Ciencias Internacionales"
            };

            Course hybridCourse = new HybridCourse((OnlineCourse)onlineCourse, (OfflineCourse)offlineCourse)
            {
                CourseId = 3,
                Title = "Curso Inteligencia Artificial Avanzado"
            };

            Course hybridCourse2 = new HybridCourse((OnlineCourse)onlineCourse, (OfflineCourse)offlineCourse)
            {
                CourseId = 4,
                Title = "Curso Python Avanzado"
            };
            #endregion


            #region Estudiantes
            Student std1 = new Student(402, "Johan Bonifacio", 20, "johanbonifacio15@outlook.com", ModalidadAsistencia.Online);
            Student std2 = new Student(1507, "Edward Solano", 18, "esolano03@gmail.com", ModalidadAsistencia.Presencial);
            #endregion

            #region Suscripciones
            onlineCourse.Subscribe(std1);
            offlineCourse.Subscribe(std2);
            hybridCourse.Subscribe(std1);
            hybridCourse2.Subscribe(std2);
            #endregion

            #region Detalles
            Console.WriteLine(onlineCourse.GetCourseDetails());
            Console.WriteLine(offlineCourse.GetCourseDetails());
            Console.WriteLine(hybridCourse.GetCourseDetails());
            Console.WriteLine(hybridCourse2.GetCourseDetails());
            #endregion
        }
    }
}
