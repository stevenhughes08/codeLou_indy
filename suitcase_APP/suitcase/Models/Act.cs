using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    
    public class Act : BaseEntity
    {
        /// <summary>
        /// This is a one to many relationship with Props and Actors
        ///<summary>
        public string ActName { get; set; }
        public Performance ActPerformance { get; set; }
        public Guid PerformanceId { get; set; }
        public Music Music { get; set; }
        public ICollection<Performer> ActPerformer { get; set; }
        public ICollection<Prop> ActProp { get; set; }
        
    }

}