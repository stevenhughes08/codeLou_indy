using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace suitcase.Models
{
    ///<summary>
    /// This is a bridge class for a many to many relationship 
    ///</summary>
    public class ActPerformer {
      public Guid PerformerId { get; set; }
        [ForeignKey("PerformerId")]
        public Performer Performer { get; set; }
        public Guid ActId { get; set; }
        [ForeignKey("ActId")]
        public Act Act { get; set; }

    }
}