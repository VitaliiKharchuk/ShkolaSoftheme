using System;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;


namespace Serialization
{
    [Serializable]
    [ProtoContract]
    public class Book
    {
        [Required]
        [ProtoMember(1)]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [ProtoMember(2)]
        public int Id { get; set; }
        
        [Required]
        [ProtoMember(3)]
        public BookType Type { get; set; }
    }
}
