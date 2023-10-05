﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaDB.model.Models;

public partial class Livros
{
    [HiddenInput(DisplayValue = false)]
    [DisplayName("Codigo")]
    public int LivroId { get; set; }

    [DisplayName("Titulo Do Livro")]
    public string Titulo { get; set; }


    [DisplayName("ISBM Do Livro")]
    [Required(ErrorMessage = "O ISBM Do Livro é Obrigatória")]
    public string Isbn { get; set; }


    [DisplayName("Ano De Publicação")]
    public int AnoPublicacao { get; set; }

    [HiddenInput(DisplayValue = false)]
    public int AutorId { get; set; }

    public virtual Autores Autor { get; set; }

    public virtual ICollection<Emprestimos> Emprestimos { get; set; } = new List<Emprestimos>();
}