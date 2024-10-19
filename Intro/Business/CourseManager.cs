using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concrete;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    // önemli kural: bir katman, diğer bir katmanı newleyemez, eğer new'lerse bağımlı olmuş olur
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {// business rules
        return _courseDal.GetAll();
    }


}
