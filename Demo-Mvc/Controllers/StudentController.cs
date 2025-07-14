namespace Demo_Mvc.Controllers
{
    using Demo_Mvc.Data;
    using Demo_Mvc.Models;
    using DemoMVC.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Person
        public async Task<IActionResult> Index()
        {
            return View(await _context.Persons.ToListAsync());
        }

        //create a new person
        public IActionResult Create()
        {
            //1. Lay ra ban ghi moi nhat cua Person
            var person = _context.Persons.OrderByDescending(p => p.PersonId).FirstOrDefault();
            //2. Neu person == null thi gan PersonID = PS0
            var personID = person == null ? "PS0" : person.PersonId;
            //3. Goi toi phuong thuc sinh id tu dong
            var autoGenerateId = new AutoGeneraateId();
            var newPersonID = autoGenerateId.AutoGenerateId(personID);
            var newPerson = new Person
            {
                PersonId = newPersonID
            };
            return View(newPerson);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FullName")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
    }

    internal class AutoGeneraateId
    {
        public AutoGeneraateId()
        {
        }

        internal string AutoGenerateId(string personID)
        {
            throw new NotImplementedException();
        }
    }
}