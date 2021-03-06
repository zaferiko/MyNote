﻿using AFirmasi.Core.Entities;
using System;
using System.Text;

namespace AFirmasi.MyNotes.Entities
{
    public class Note : IEntity
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteDescription { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    
}
