using System;

namespace suitcase.Models
{
    ///<summary>
    /// This is a bridge class for a many to many relationship 
    ///</summary>
    public class ActPerformer {
        public Guid PerformerId { get; set; }
        public string Performer { get; set; }
        public Guid ActId { get; set;}
        public string Act { get; set; }

    }
}