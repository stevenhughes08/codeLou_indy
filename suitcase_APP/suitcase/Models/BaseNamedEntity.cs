using System;

namespace suitcase.Models
{
    /// <summary>
    /// All named database entities will inherit from this class.
    ///</summary>
    public class BaseNamedEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}