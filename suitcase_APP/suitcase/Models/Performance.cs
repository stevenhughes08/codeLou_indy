using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    ///<summary>
    /// This class has a one to many relationship with Acts
    ///</summary>
    public class Performance : BaseNamedEntity
    {
        /// <summary>
        /// One performance many acts. Each only has one performance.
        /// </summary>        
        public ICollection<Act> Acts { get; set; }
    }
}