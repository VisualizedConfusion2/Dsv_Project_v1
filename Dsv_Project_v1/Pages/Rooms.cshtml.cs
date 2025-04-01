using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;

namespace Dsv_Project_v1.Pages
{
    public class RoomsModel : PageModel
    {
        public List<MeetingRoom> MeetingRooms { get; set; } = new();
        public void OnGet()
        {

        }
    }
}
