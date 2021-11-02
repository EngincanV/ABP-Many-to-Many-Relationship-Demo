﻿using System;
using Volo.Abp.Auditing;

namespace BookStore.Books
{
    public class BookDto : IHasCreationTime
    {
        public string AuthorName { get; set; }

        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public string[] CategoryNames { get; set; }
        
        public DateTime CreationTime { get; }
    }
}