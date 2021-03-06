﻿using System.Collections.Generic;

namespace StudentTestingSystem.Services.Extensions
{
    public class PageInfo<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Results { get; set; }
        public int TotalPages { get; set; }
    }
}