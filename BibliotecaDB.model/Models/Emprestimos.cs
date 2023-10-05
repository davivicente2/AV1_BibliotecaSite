using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDB.model.Models
{
    public partial class Emprestimos
    {
        [HiddenInput(DisplayValue = false)]
        [DisplayName("Código")]
        public int EmprestimoId { get; set; }

        [Required(ErrorMessage = "O Livro é obrigatório")]
        public int LivroId { get; set; }

        [DisplayName("Data de Entrega")]
        [Required(ErrorMessage = "A Data de Entrega é obrigatória")]
        [DataType(DataType.DateTime)]
        public DateTime DataEmprestimo { get; set; }

        [DisplayName("Data de Devolução")]
        [DataType(DataType.DateTime)]
        public DateTime? DataDevolucao { get; set; }

        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O Nome do Cliente é obrigatório")]
        [StringLength(255, ErrorMessage = "O Nome do Cliente deve ter no máximo 255 caracteres")]
        public string NomePessoa { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um Email válido")]
        [StringLength(255, ErrorMessage = "O Email deve ter no máximo 255 caracteres")]
        public string EmailPessoa { get; set; }

        public virtual Livros Livro { get; set; }
    }
}
