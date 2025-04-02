using Dsv_Project_v1.Models;
using Dsv_Project_v1.Repo;

namespace Dsv_Project_v1.RoomService
{
    public class RoomService
    {
        private readonly IRoomRepo _roomRepo;

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

