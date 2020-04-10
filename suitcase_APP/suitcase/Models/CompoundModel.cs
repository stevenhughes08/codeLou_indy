using System;

namespace suitcase.Models
{
    public class CompoundModel
    {
        public Guid Id { get; set; }
        public Performance Performance { get; set; }
        public Act Act { get; set; }
        public Performer Performer { get; set; }
        public Prop Prop { get; set; }
    }
}