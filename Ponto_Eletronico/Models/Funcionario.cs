//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ponto_Eletronico.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            this.Funcionario_Cargo = new HashSet<Funcionario_Cargo>();
            this.Ponto = new HashSet<Ponto>();
        }

        public Funcionario(string nome, string cpf, string email, string usuario, string senha)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.usuario = usuario;
            this.senha = senha;
        }

        public Funcionario(int id, string nome, string cpf, string email, string usuario, string senha)
        {
            this.Id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.usuario = usuario;
            this.senha = senha;
        }

        [Key]
        public int Id { get; set; }

        [Column(Order = 0)]
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "O tamanho m�ximo da senha s�o 50 caracteres.")]
        [Required(ErrorMessage = "Digite o nome do Funcion�rio.")]
        public string nome { get; set; }

        [Column(Order = 1)]
        [Display(Name = "Cpf")]
        [DisplayFormat(DataFormatString = "000.000.000-00")]
        [Required(ErrorMessage = "Digite o cpf do Funcion�rio.")]
        public string cpf { get; set; }

        [Column(Order = 2)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email v�lido...")]
        [Required(ErrorMessage = "Digite o e-mail do Funcion�rio.")]
        public string email { get; set; }

        [Column(Order = 3)]
        [Display(Name = "Usu�rio")]
        [MinLength(5, ErrorMessage = "O tamanho m�nimo do usu�rio s�o 5 caracteres.")]
        [StringLength(15, ErrorMessage = "O tamanho m�ximo da senha s�o 15 caracteres.")]
        [Required(ErrorMessage = "Digite o usu�rio do Funcion�rio.")]
        public string usuario { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "O tamanho m�nimo da senha s�o 5 caracteres.")]
        [StringLength(10, ErrorMessage = "O tamanho m�ximo da senha s�o 10 caracteres.")]
        [Required(ErrorMessage = "Digite o senha do Funcion�rio.")]
        public string senha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario_Cargo> Funcionario_Cargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ponto> Ponto { get; set; }
    }
}
