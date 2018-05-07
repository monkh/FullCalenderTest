namespace BusinessLayer.Calendar
{
    public class Event
    {
// Supressed name style warnings because object serialized 
#pragma warning disable IDE1006 // Naming Styles
        public string id { get; set; }
        public string resourceId { get; set; }
        public string title { get; set; }
        public object start { get; set; }
        public string end { get; set; }
        public bool? allDay { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
