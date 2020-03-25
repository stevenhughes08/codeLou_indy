using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Performance : BaseEntity
    {
        /// <summary>
        /// This is a many-to-many relationship between Performances, Acts, Props and Actors
        /// </summary>        
        public string PerformanceName { get; set; }
        public ICollection<Act> Acts { get; set; }
    }
}