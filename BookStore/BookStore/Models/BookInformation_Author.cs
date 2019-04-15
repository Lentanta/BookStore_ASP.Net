﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookInformation_Author
    {
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public int BookInfoID { get; set; }
        public virtual BookInformation BookInformation { get; set; }
    }
}