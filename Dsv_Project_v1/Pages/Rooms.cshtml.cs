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

            MeetingRooms = new List<MeetingRoom>
            {
                new MeetingRoom {  Name = "Mødelokale A", Capacity = 10, Equipment = "Projektor, Whiteboard", IsAvailable = true, Id=1 },
                new MeetingRoom {  Name = "Mødelokale B", Capacity = 8, Equipment = "TV, Konferenceudstyr", IsAvailable = true, Id=2 },
                new MeetingRoom {  Name = "Mødelokale C", Capacity = 12, Equipment = "Whiteboard", IsAvailable = true, Id=3 }
            };
        }
    }
}
