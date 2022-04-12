using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment_dojo_survey_validations.Models
{

  public class User
  {

    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [MinLength(3)]
    public string Color { get; set; }
    [Required]
    [Range(0, 10)]
    public int Number { get; set; }


  }

}