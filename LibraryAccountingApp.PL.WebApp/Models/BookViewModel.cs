﻿using LibraryAccountingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAccountingApp.PL.WebApp.Models
{
    public class BookViewModel
    {
        [HiddenInput]
        public long Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Enter the title")]
        public string Title { get; set; }

        [DisplayName("Author name")]
        [Required(ErrorMessage = "Enter the author name")]
        public string AuthorName { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        public GenreViewModel Genre { get; set; }
    }
}
