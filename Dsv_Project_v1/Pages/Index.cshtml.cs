using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;

namespace Dsv_Project_v1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRoomRepo _roomRepo;

        public IndexModel(ILogger<IndexModel> logger, IRoomRepo roomRepo)
        {
            _logger = logger;
            _roomRepo = roomRepo;
        }

        public List<MeetingRoom> MeetingRoom { get; set; } = new();

        public void OnGet()
        {
            MeetingRoom = _roomRepo.GetAll();
        }
    }
}

