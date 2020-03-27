using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace suitcase.Models{
    ///<summary>
    /// This is a bridge class for a many to many relationship
    ///</summary>
    public class ActProp{
   public Guid ActId { get; set; }
        [ForeignKey("ActId")]
        public Act Act { get; set; }
        public Guid PropId { get; set; }
        [ForeignKey("PropId")]
        public Prop Prop { get; set; }
    
}
}

