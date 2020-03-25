using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Performer : BaseEntity
    {
    /// <summary> 
    /// This will have a many to many relationship with Acts
    /// </summary>
    public Guid PerformerId { get; set; }
    public string PerformerName { get; set; }
    public string HeadShotUrl { get; set; }

    public ICollection<ActPerformer> ActPerformer { get; set; }
    }
    
    
}