using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ViewModel.CourseVM;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        private readonly UniversityContext _context;
        public CourseController
            (
                UniversityContext context
            )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var course = _context.Courses
                .Select(c => new CourseIndexViewModel
                {
                    CourseId = c.CourseId,
                    Credits = c.Credits,
                    Title = c.Title,
                    DepartmentId = c.DepartmentId,
                    Department = new CourseDepartmentIndexViewModel
                    {
                        DepartmentName = c.Departments.Name
                    }
                });

            return View(course);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vm = await _context.Courses
                .Where(c => c.CourseId == id)
                .Select(c => new CourseUpdateViewModel
                {
                    CourseId = c.CourseId,
                    Credits = c.Credits,
                    Title = c.Title,
                    Department = new CourseDepartmentIndexViewModel
                    {
                        DepartmentName = c.Departments != null ? c.Departments.Name : null
                    }
                })
                .FirstOrDefaultAsync();

            return View(vm);
        }
    }
}
