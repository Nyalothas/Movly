﻿using Movly.Models;
using System.Collections.Generic;

namespace Movly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}