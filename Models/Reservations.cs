using System;
using System.Collections.Generic;

namespace ccd.Models
{
    public partial class Reservations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int TotalPeople { get; set; }
        public string Email { get; set; }
    }
}
