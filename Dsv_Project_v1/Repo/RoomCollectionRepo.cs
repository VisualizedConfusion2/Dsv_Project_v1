using Dsv_Project_v1.Models;

namespace Dsv_Project_v1.Repo
{
    public class RoomCollectionRepo : IRoomRepo
    {
        private readonly List<MeetingRoom> _meetingRooms = new();

        public RoomCollectionRepo()
        {
            _meetingRooms.Add(new MeetingRoom(1, "Mødelokale A", 12, "Whiteboard", true));
            _meetingRooms.Add(new MeetingRoom(2, "Mødelokale B", 12, "Whiteboard", true));
            _meetingRooms.Add(new MeetingRoom(3, "Mødelokale C", 12, "Whiteboard", true));
        }

        public void Add(MeetingRoom meetingRoom)
        {
            _meetingRooms.Add(meetingRoom);
        }

        public List<MeetingRoom> GetAll()
        {
            return _meetingRooms;
        }

        public MeetingRoom Get(int id)
        {
            //return _meetingRooms.FirstOrDefault(m => m.Id == id);
            foreach (var meetingRoom in _meetingRooms)
            {
                if (meetingRoom.Id == id)
                {
                    return meetingRoom; 
                }
            }
            return null;
        }
    }
}