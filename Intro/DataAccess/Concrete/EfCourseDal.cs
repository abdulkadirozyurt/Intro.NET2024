using Intro.DataAccess.Abstract;
using Intro.Entities;

namespace Intro.DataAccess.Concrete;

// polymorphism
public class EfCourseDal : ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = "ES6";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 21";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Pyhton 3.10";
        course3.Price = 0;

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
