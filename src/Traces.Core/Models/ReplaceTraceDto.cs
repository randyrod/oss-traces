using NodaTime;
using Optional;

namespace Traces.Core.Models
{
    public class ReplaceTraceDto
    {
        public string Title { get; set; }

        public Option<string> Description { get; set; }

        public ZonedDateTime DueDate { get; set; }

        public Option<LocalTime> DueTime { get; set; }
    }
}