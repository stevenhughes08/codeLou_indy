using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Prop : BaseEntity
    {
        public Guid PropId { get; set; }
        /// <summary>
        /// This is a one to many relationship with Acts
        /// <summary>
        public string PropName { get; set; }
        public string Description { get; set; } 
        public string StorageLocation { get; set; }
        public ICollection<ActProp> ActProps { get; set; }
    }
}