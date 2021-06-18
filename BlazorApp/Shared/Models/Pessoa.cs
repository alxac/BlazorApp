using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório ({1}{2}{3})")]
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }

        public Pessoa() { }
    }
}
