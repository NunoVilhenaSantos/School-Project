﻿namespace ClassLibrary;

public class Courses
{
    #region Properties

    public static List<Course> ListCourses { get; set; } = new();

    #endregion

    #region Methods

    /// <summary>
    ///     Adding a new course
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="workLoad"></param>
    /// <param name="studentGrades"></param>
    public static void AddCourse(
        int id, string name, int workLoad, int credits,
        List<Enrollment>? enrollments
    )
    {
        ListCourses.Add(new Course
            {
                //Id_Course = id,
                Name = name,
                WorkLoad = workLoad,
                Credits = credits
                // Enrollments = enrollments,
                // StudentGradesList = studentGrades,
            }
        );
    }


    /// <summary>
    ///     Deleting a course
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Return an text informing if the operation was valid or not</returns>
    public static string DeleteCourse(int id)
    {
        var course = ListCourses.FirstOrDefault(a => a.IdCourse == id);

        if (course == null)
            return "O curso não existe";

        ListCourses.Remove(course);
        return "O curso foi apagado";
    }


    /// <summary>
    ///     Editing an existing course
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="workLoad"></param>
    /// <param name="studentGrades"></param>
    /// <returns>Informs if the list is empty, or the course doesn't exists or was successful editing the course</returns>
    public static string EditCourse(
        int id, string name, int workLoad,
        List<Enrollment>? enrollments
    )
    {
        if (ListCourses.Count < 1)
            return "Lista está vazia";


        var course = ListCourses.FirstOrDefault(a => a.IdCourse == id);

        if (course == null)
            return "O curso não existe";

        ListCourses.FirstOrDefault(a => a.IdCourse == id)!.Name = name;
        ListCourses.FirstOrDefault(
            a => a.IdCourse == id)!.WorkLoad = workLoad;
        ListCourses.FirstOrDefault(
            a => a.IdCourse == id)!.Enrollments = enrollments;

        return "Curso alterado com sucesso";
    }


    /// <summary>
    ///     Searching a course
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="workLoad"></param>
    /// <param name="studentGrades"></param>
    /// <returns>Returns a list of Courses by name or working hours </returns>
    public static List<Course> ConsultCourse(
        string name, int workLoad,
        List<Enrollment>? enrollments
    )
    {
        var courses = ListCourses;

        if (!string.IsNullOrWhiteSpace(name))
            courses = ListCourses.Where(a => a.Name == name).ToList();

        if (!int.IsNegative(workLoad))
            courses = ListCourses.Where(
                a => a.WorkLoad == workLoad).ToList();

        if (enrollments != null)
            courses = ListCourses.Where(
                a => a.Enrollments == enrollments).ToList();

        return courses;
    }


    public static List<Course> ConsultCourse(
        int id, string name, int workLoad,
        List<Enrollment>? enrollments)
    {
        var courses = ListCourses;

        if (!string.IsNullOrWhiteSpace(name))
            courses = courses.Where(c => c.Name == name).ToList();

        if (workLoad >= 0)
            courses = courses.Where(c => c.WorkLoad == workLoad).ToList();

        if (enrollments != null)
            courses = courses.Where(c => c.Enrollments == enrollments).ToList();

        return courses;
    }


    public static int GetLastIndex()
    {
        var lastCourse = ListCourses.LastOrDefault();
        if (lastCourse != null)
            return lastCourse.IdCourse;
        return -1;
    }


    public static int GetLastId()
    {
        var lastCourse = ListCourses.LastOrDefault();
        return lastCourse?.IdCourse ?? GetLastIndex();
        /*
        return lastCourse != null
            ? lastCourse.IdCourse
            : GetLastIndex();
        */
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
    }

    #endregion
}