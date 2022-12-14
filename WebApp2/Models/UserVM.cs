using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp2.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public int Password { get; set; }
        public int RoleId { get; set; }
        public int EmployeeId { get; set;}
        public List<SelectListItem> Roles { get; set; }
        public List<SelectListItem> Employees { get; set; }

    }
}
