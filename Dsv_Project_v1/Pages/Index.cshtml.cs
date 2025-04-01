using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<MeetingRoom> MeetingRooms { get; set; } = new();

        public void OnGet()
        {
            // Simulated meeting room data
            MeetingRooms = new List<MeetingRoom>
        {
            new MeetingRoom { Name = "Mødelokale A", Capacity = 10, Equipment = "Projektor, Whiteboard", IsAvailable = true },
            new MeetingRoom { Name = "Mødelokale B", Capacity = 8, Equipment = "TV, Konferenceudstyr", IsAvailable = true },
            new MeetingRoom { Name = "Mødelokale C", Capacity = 12, Equipment = "Whiteboard", IsAvailable = true }
        };
        }
    }

    // MeetingRoom Model
    public class MeetingRoom
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Equipment { get; set; }
        public bool IsAvailable { get; set; }
    }
}

