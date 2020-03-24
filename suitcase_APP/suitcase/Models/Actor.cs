using System;
namespace suitcase.Models
{
    public class Actor : BaseEntity
    {
    /// <summary> 
    /// This will have a one to many relationship with Acts
    /// </summary>
    public Guid ActorId { get; set; }
    public string ActorName { get; set; }
    public string CharacterName { get; set; }
    }
    
    
}