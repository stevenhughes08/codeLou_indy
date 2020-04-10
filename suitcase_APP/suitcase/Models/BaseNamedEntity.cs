using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace suitcase.Models
{
    /// <summary>
    /// All named database entities will inherit from this class.
    ///</summary>
    public class BaseNamedEntity
    {
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
=======
        public Guid Id { get; set; }      
>>>>>>> 7b2da25f559d15f7d614acfee6616dc49ed91c7c
        public string Name { get; set; }
    }
}