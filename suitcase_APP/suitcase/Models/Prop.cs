using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace suitcase.Models
{
    public class Prop : BaseNamedEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PropId { get; set; }
        /// <summary>
        /// This is a one to many relationship with Acts
        /// <summary>
        public string StorageLocation { get; set; }
        public ICollection<ActProp> ActProps { get; set; }
    }
}