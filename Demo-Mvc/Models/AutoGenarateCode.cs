using Demo_Mvc.Data;
using System.Linq;

namespace DemoMVC.Models
{
    public static class AutoGenerateCode
    {
        public static string GeneratePersonId(ApplicationDbContext context)
        {
            var lastPerson = context.Person
                .OrderByDescending(p => p.PersonId)
                .FirstOrDefault();

            string newPersonId = "PS001";

            if (lastPerson != null)
            {
                string numberPart = lastPerson.PersonId.Substring(2);
                if (int.TryParse(numberPart, out int number))
                {
                    number += 1;
                    newPersonId = "PS" + number.ToString("D3");
                }
            }

            return newPersonId;
        }
    }
}
