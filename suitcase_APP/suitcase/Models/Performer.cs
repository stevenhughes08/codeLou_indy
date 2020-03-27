using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Performer : BaseNamedEntity
    {
    /// <summary> 
    /// This will have a many to many relationship with Acts
    /// </summary>
    public string HeadShotUrl { get; set; }
    public ICollection<ActPerformer> ActPerformers { get; set; }
    }
    
    
}