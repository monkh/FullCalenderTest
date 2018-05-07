using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Calendar
{
    public class RootObject
    {
// Supressed name style warnings because object serialized 
#pragma warning disable IDE1006 // Naming Styles
        public bool selectable { get; set; }
        public Header header { get; set; }
        public string defaultView { get; set; }
        public string resourceGroupField { get; set; }
        public BusinessHours businessHours { get; set; }
        public List<Resource> resources { get; set; }
        public List<Event> events { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
