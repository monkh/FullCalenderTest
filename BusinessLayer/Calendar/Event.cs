namespace BusinessLayer.Calendar
{
    public class Event
    {
        public string id { get; set; }
        public string resourceId { get; set; }
        public string title { get; set; }
        public object start { get; set; }
        public string end { get; set; }
        public bool? allDay { get; set; }
    }
}
