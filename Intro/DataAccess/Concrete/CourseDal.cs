using Intro.DataAccess.Abstract;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concrete;

// polymorphism
public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course
        {
            Id = 1,
            Name = "C#",
            Description = ".NET 8",
            Price = 0
        };

        Course course2 = new Course
        {
            Id = 2,
            Name = "Java",
            Description = "Java 17",
            Price = 0
        };

        Course course3 = new Course
        {
            Id = 3,
            Name = "Python",
            Description = "Pyhton 3.12",
            Price = 0
        };

        courses = new List<Course> { course1, course2, course3 };
    }

    public List<Course> GetAll()
    {
        // database operations
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

}
