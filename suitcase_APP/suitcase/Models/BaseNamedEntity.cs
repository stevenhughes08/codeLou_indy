using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace suitcase.Models
{
    /// <summary>
    /// All named database entities will inherit from this class.
    ///</summary>
    public class BaseNamedEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}