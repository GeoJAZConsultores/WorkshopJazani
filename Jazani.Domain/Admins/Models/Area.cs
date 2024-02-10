﻿namespace Jazani.Domain.Admins.Models
{
    public class Area
    {
        public int Id { get; set; }
        public int AreaTypeId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
