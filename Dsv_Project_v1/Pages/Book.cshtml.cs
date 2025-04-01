using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string RoomName { get; set; }

        [BindProperty]
        public string MeetingDate { get; set; }

        [BindProperty]
        public string MeetingTime { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public MeetingRoom SelectedRoom { get; set; }

        // Simuleret database
        private static List<MeetingRoom> MeetingRooms = new List<MeetingRoom>
        {
            new MeetingRoom { Name = "Mødelokale A", Capacity = 10, Equipment = "Projektor, Whiteboard", IsAvailable = true },
            new MeetingRoom { Name = "Mødelokale B", Capacity = 8, Equipment = "TV, Konferenceudstyr", IsAvailable = true },
            new MeetingRoom { Name = "Mødelokale C", Capacity = 12, Equipment = "Whiteboard", IsAvailable = true }
        };

        public void OnGet()
        {
            SelectedRoom = MeetingRooms.Find(r => r.Name == RoomName);
        }

        public IActionResult OnPost()
        {
            var room = MeetingRooms.Find(r => r.Name == RoomName);
            if (room != null)
            {
                room.IsAvailable = false; // Markér lokalet som optaget
            }

            return RedirectToPage("/Index"); // Gå tilbage til forsiden
        }
    }
}

