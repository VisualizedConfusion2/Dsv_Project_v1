namespace Dsv_Project_v1.Models
{
    public class MeetingRoom
    {
        // MeetingRoom Model
    
    
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Equipment { get; set; }
        public bool IsAvailable { get; set; }
        public int Id { get; set; }
    
        public MeetingRoom(int id, string name, int capacity, string equipment, bool isAvailable)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Equipment = equipment;
            IsAvailable = isAvailable;
        }

    }
}
