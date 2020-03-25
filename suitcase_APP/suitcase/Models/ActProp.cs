using System;
namespace suitcase.Models{
    ///<summary>
    /// This is a bridge class for a many to many relationship
    ///</summary>
    public class ActProp{
    public Guid ActId { get; set; }
    public string Act { get; set; }
    public Guid PropId { get; set; }
    public string Prop { get; set; }
    
}
}

