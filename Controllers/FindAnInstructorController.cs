using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheFinalSheDriverTrainingHub.Models.DB;
using Newtonsoft.Json;

namespace TheFinalSheDriverTrainingHub.Controllers
{
    public class FindAnInstructorController : Controller
    {
        private readonly TheFinalSheDriverTrainingHubContext _context;
        public FindAnInstructorController(TheFinalSheDriverTrainingHubContext context)
        {
            _context = context;
        }
        // GET: /FindAnInstructor/Index?searchString=Lilly
        public IActionResult Index(string searchString)
        {
            string sql = "SELECT * FROM AspNetUsers WHERE FirstName LIKE @p0 OR City LIKE @p0 OR Suburb LIKE @p0 OR PricePerHour LIKE @p0";
            searchString = "%" + searchString + "%";
            List<AspNetUsers> instructors = _context.AspNetUsers.FromSql(sql, searchString).ToList();
            return View(instructors);
        }
        public async Task<IActionResult> instructorIndex()
        {
            return View(await _context.AspNetUsers.ToListAsync());
        }

        // GET: AspNetUsers/instructorEdit/5
        public async Task<IActionResult> instructorEdit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }
            return View(aspNetUsers);
        }

        // GET: AspNetUsers/instructorDetails/5
        public async Task<IActionResult> instructorDetail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return View(aspNetUsers);
        }

        // Adding an Auto Search Suggestion
        public string IndexAJAX(string searchString)
        {
            string sql = "SELECT * FROM AspNetUsers WHERE FirstName LIKE @p0";
            string _searchString = "%" + searchString + "%";
            List<AspNetUsers> instructors = _context.AspNetUsers.FromSql(sql, _searchString).ToList();

            List<string> searchList = new List<string>();
            foreach (AspNetUsers item in instructors)
            {
                if (item.FirstName.ToLower().Contains(searchString.ToLower())
                    && !(searchList.Contains(item.FirstName)))
                {
                    searchList.Add(item.FirstName);
                }
            }
            string json = JsonConvert.SerializeObject(searchList);
            return json;
        }
        // GET: FindAnInstructor/Details/1
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        private bool ProductExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}