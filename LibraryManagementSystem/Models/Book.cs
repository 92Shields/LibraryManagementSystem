﻿namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int AuthorId {  get; set; }
        public int PublishedYear { get; set; }
        public string ISBN { get; set; } = string.Empty;
    }
}