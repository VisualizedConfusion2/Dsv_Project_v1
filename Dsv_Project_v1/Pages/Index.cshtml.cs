using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;

namespace Dsv_Project_v1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<MeetingRoom> MeetingRoom { get; set; } = new();

        public void OnGet()
        {
            //// Simulated meeting room data
            //MeetingRoom = new List<MeetingRoom>
            //{
            //new MeetingRoom { Name = "Mødelokale A", Capacity = 10, Equipment = "Projektor, Whiteboard", IsAvailable = true, Id=1},
            //new MeetingRoom { Name = "Mødelokale B", Capacity = 8, Equipment = "TV, Konferenceudstyr", IsAvailable = true, Id=2},
            //new MeetingRoom { Name = "Mødelokale C", Capacity = 12, Equipment = "Whiteboard", IsAvailable = true, Id=3 }
            //};
        }
    }
}

