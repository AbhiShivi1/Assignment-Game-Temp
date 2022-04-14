using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AssignmentGame.Models
{
    public class Game
    {   [Required]
        [RegularExpression(@"\d{4}", ErrorMessage = "Use only 4 digits")]
        public int Number { get; set; }
    }
}