using System;

namespace LSPP2
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha registrado en el curso en línea {Title} exitosamente.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso en Línea: {Title} (ID: {CourseId})";
        }
    }
}