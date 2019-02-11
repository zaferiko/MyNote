
using AFirmasi.Core.Entities;
using System.Collections.Generic;

namespace AFirmasi.MyNotes.Entities
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Note> Notes { get; set; }
    }

    
}
