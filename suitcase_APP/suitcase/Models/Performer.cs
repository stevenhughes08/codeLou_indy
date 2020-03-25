using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Performer : BaseEntity
    {
    /// <summary> 
    /// This will have a one to many relationship with Acts
    /// </summary>
    public Guid PerformerId { get; set; }
    public string Name { get; set; }
    public string HeadShotUrl { get; set; }

    public ICollection<Act> PerformerAct { get; set; }
    }
    
    
}