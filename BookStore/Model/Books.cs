﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BookStore.Data
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? DateAdded { get; set; }
        public decimal? BasePrice { get; set; }
        public int? AddedBy { get; set; }

        public virtual Users AddedByNavigation { get; set; }
    }
}