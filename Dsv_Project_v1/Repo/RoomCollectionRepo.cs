using Dsv_Project_v1.Repo;
using Dsv_Project_v1.Models;
using System.Xml.Linq;
namespace Dsv_Project_v1.Repo
{
    public class RoomCollectionRepo : IRoomRepo
    {
        List<MeetingRoom> _meetingRoom = new List<MeetingRoom>();

        public void Add(MeetingRoom meetingRoom)
        {
            _meetingRoom.Add(meetingRoom);
        }
        public List<MeetingRoom> GetAll()
        {
            return _meetingRoom;
        }
        public MeetingRoom Get(int id)
        {
            foreach (MeetingRoom meetingRoom in _meetingRoom)
            {
                if (meetingRoom.Id == id)
                {
                    return meetingRoom;
                }
            }
            return null;
        }
        public RoomCollectionRepo()
        {
            _meetingRoom.Add(new MeetingRoom(1, "Mødelokale A", 12, "Whiteboard", true ));
            _meetingRoom.Add(new MeetingRoom(2, "Mødelokale B", 12, "Whiteboard", true ));
            _meetingRoom.Add(new MeetingRoom(3, "Mødelokale C", 12, "Whiteboard", true ));
        }

    }
}

