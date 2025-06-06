﻿namespace SalesCet97.Web.Data.Entities;

using System.ComponentModel.DataAnnotations;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "Pais")]
    [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string? Name { get; set; }

}
