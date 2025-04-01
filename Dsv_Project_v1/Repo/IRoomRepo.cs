using Dsv_Project_v1.Pages;
using Dsv_Project_v1.Models;

namespace Dsv_Project_v1.Repo
{
    public interface IRoomRepo
    {
        public List<MeetingRoom> GetAll();
        public void Add(MeetingRoom meetingroom);
        public MeetingRoom Get(int id);
    }
}
