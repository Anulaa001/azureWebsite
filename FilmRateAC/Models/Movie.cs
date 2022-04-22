using System;
using System.Collections.Generic;

namespace FilmRateAC.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Picture { get; set; } = null!;
    }
}
