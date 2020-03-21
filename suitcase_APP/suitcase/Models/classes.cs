using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace suitcase.Models
{
    public class Base
    {
        public Guid Id { get; set; }
    }
    public class Prop : Base
    {
        public string Name { get; set; }
        public string StorageLocation { get; set;}
        public ICollection<Act> Acts {get; set;}
    }

    public class Act : Base 
    {
        public string Title { get; set; }
        public ICollection<Performer> Performers {get; set; }
        public ICollection<Prop> Props { get; set; }
    }

    public class Performer : Base
    {
        public string ActorName { get; set; }
        public string CharacterName { get; set; }

    }

    public class Performance : Base
    {
        public string Title { get; set; }
        public ICollection<Act> Acts { get; set; }
    }
}