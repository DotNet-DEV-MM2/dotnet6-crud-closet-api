using System.ComponentModel.DataAnnotations;

namespace dotnet6_crud_closet_api.Entities
{
    public class ClosetItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Size Size { get; set; }
        public Season Season { get; set; }
        public ClosetItemType Type { get; set; }
        public User User { get; set; }
        
    }
}
