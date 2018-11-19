namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Room { get; set; }
        public byte Inhabited { get; set; } //заселен
        public byte Envicted { get; set; } //выселен
        public byte RoomType { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; } 
    }
}
