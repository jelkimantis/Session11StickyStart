using System;
using System.ComponentModel.DataAnnotations;

namespace stickynotes.Models
{
    public class Sticky
    {
        public int ID {get;set;}
        public string NoteTitle {get;set;}
        public string NoteText {get;set;}
        public int Order {get;set;}
        [DataType(DataType.Date)]
        public DateTime NoteDate { get; set; }
    }
}