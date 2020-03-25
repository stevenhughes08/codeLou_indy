using System;

namespace suitcase.Models
{
    public class ActPerformer {
        public Guid PerformerId { get; set; }
        public string Performer { get; set; }
        public Guid ActId { get; set;}
        public string Act { get; set; }

    }
}