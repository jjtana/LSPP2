using System;

namespace LSPP2
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha registrado en el curso presencial {Title} con éxito.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso Presencial: {Title} (ID: {CourseId})";
        }
    }
}