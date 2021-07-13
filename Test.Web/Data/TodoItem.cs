﻿using System;

namespace Test.Web.Data
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}