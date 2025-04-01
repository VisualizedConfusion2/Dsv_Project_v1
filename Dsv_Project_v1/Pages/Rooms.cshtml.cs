using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v1.Pages
{
    public class RoomsModel : PageModel
    {
        public List<MeetingRoom> MeetingRooms { get; set; } = new();
        public void OnGet()
        {

            MeetingRooms = new List<MeetingRoom>
            {
                new MeetingRoom { Name = "M�delokale A", Capacity = 10, Equipment = "Projektor, Whiteboard", IsAvailable = true },
                new MeetingRoom { Name = "M�delokale B", Capacity = 8, Equipment = "TV, Konferenceudstyr", IsAvailable = true },
                new MeetingRoom { Name = "M�delokale C", Capacity = 12, Equipment = "Whiteboard", IsAvailable = true }
            };
        }
    }
}
