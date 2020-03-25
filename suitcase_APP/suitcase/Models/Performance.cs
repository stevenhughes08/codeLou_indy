using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    ///<summary>
    /// This class has a one to many relationship with Acts
    ///</summary>
    public class Performance : BaseEntity
    {
        /// <summary>
        /// This is a many-to-many relationship between Performances, Acts, Props and Actors
        /// </summary>        
        public string PerformanceName { get; set; }
        public ICollection<Act> Acts { get; set; }
    }
}