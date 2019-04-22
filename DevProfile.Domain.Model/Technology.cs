﻿namespace DevProfile.Domain.Model
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public Skill Skill { get; set; }
    }
}