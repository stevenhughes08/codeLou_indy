using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    
    public class Act : BaseEntity
    {
        /// <summary>
        /// This is a one to many relationship with Props and Actors
        ///<summary>
        public Guid ActId { get; set; }
        public string ActName { get; set; }
        public Music Music { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Prop> Props { get; set; }
        
    }

}