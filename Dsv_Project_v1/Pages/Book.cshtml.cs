using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dsv_Project_v1.Repo;
using Dsv_Project_v1.RoomService;
using Dsv_Project_v1.Models;
using System.Diagnostics;

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
        public string EndMeetingTime { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public MeetingRoom SelectedRoom { get; set; }


        public MeetingRoom meetingRoom { get; set; }
        
        public void OnGet()
        {
            //SelectedRoom = MeetingRoom.Find(r => r.Name == RoomName);
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("efwef" + meetingRoom.Name);
            _roomRepo.Add(meetingRoom);

            return RedirectToPage("/index");
        }
    }
}

