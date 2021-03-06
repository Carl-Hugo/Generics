﻿using Model.Extensions;

namespace Model
{
    public class Product : IActive, IVisible
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
    }
}
