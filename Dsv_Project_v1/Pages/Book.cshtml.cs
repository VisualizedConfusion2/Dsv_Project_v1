using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;
using System.Diagnostics;

namespace Dsv_Project_v1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IRoomRepo _roomRepo;

        public PrivacyModel(ILogger<PrivacyModel> logger, IRoomRepo roomRepo)
        {
            _logger = logger;
            _roomRepo = roomRepo;
        }

        [BindProperty(SupportsGet = true)]
        public string RoomName { get; set; }

        [BindProperty]
        public string MeetingDate { get; set; }

        [BindProperty]
        public string MeetingTime { get; set; }

        [BindProperty]
        public string EndMeetingTime { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public MeetingRoom SelectedRoom { get; set; }

        [BindProperty]
        public MeetingRoom meetingRoom { get; set; } = new();

        public void OnGet()
        {
            SelectedRoom = _roomRepo.GetAll().FirstOrDefault(r => r.Name == RoomName);
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("Booking Room: " + meetingRoom.Name);
            _roomRepo.Add(meetingRoom);
            return RedirectToPage("/Index");
        }
    }
}
