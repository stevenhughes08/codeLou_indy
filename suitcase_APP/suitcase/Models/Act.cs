using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    
    public class Act : BaseEntity
    {
        ///<summary>
        /// Many to many relationship with performers
        ///</summary>

        public string ActName { get; set; }
        public Guid PerformanceId { get; set; }
        public Performance Performances { get; set; }
        public Music Music { get; set; }
        public ICollection<ActPerformer> ActPerformers { get; set; }
        public ICollection<ActProp> ActProps { get; set; }
        
    }

}