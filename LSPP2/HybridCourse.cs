using System;

namespace LSPP2
{
    public class HybridCourse : Course
    {
        private readonly OnlineCourse _onlineCourse;
        private readonly OfflineCourse _offlineCourse;

        public HybridCourse(OnlineCourse onlineCourse, OfflineCourse offlineCourse)
        {
            _onlineCourse = onlineCourse;
            _offlineCourse = offlineCourse;
        }

        public override void Subscribe(Student student)
        {
            if (student.Modalidad == ModalidadAsistencia.Online)
            {
                Console.WriteLine($"El estudiante {student.Nombre} se ha registrado en el curso híbrido {Title} en modalidad en línea exitosamente.");
            }
            else if (student.Modalidad == ModalidadAsistencia.Presencial)
            {
                Console.WriteLine($"El estudiante {student.Nombre} se ha registrado en el curso híbrido {Title} en modalidad presencial exitosamente.");
            }
        }

        public override string GetCourseDetails()
        {
            return $"Curso Híbrido: {Title} (ID: {CourseId})";
        }
    }
}