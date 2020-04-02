using System;
using System.Collections.Generic;
namespace suitcase.Models
{
    public class Prop : BaseNamedEntity
    {
        public Guid PropId { get; set; }
        /// <summary>
        /// This is a one to many relationship with Acts
        /// <summary>
        public string StorageLocation { get; set; }
        [Required]
        public ICollection<ActProp> ActProps { get; set; }
    }
}