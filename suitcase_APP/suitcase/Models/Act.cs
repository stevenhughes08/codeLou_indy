using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    
    public class Act : BaseNamedEntity
    {
        ///<summary>
        /// Many to many relationship with performers
        ///</summary>
        public Guid PerformanceId { get; set; }
        [Required]
        public Performance Performance { get; set; }
        [Required]
        public ICollection<ActPerformer> ActPerformers { get; set; }
        public ICollection<ActProp> ActProps { get; set; }
        
    }

}