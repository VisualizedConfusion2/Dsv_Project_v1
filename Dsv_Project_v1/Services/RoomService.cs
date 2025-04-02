using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Dsv_Project_v1.RoomService
{
    public class RoomService
    {
        private IRoomRepo _roomRepo; // Creates a new instance for room repository


        public RoomService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;

        }

        public List<MeetingRoom> GetAll()
        {
            return _roomRepo.GetAll();
        }

        public void Add(MeetingRoom meetingRoom)
        {
            _roomRepo.Add(meetingRoom);
        }
        public MeetingRoom Get(int id)
        {
            return _roomRepo.Get(id);
        }
    }
}
