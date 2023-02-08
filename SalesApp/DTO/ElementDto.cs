namespace SalesApp.DTO
{
    public class ElementDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int? WindowId{ get; set; }
        public string WindowName { get; set; }
    }
}
