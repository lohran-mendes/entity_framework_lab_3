using System.ComponentModel.DataAnnotations;

namespace entity_framework_lab_3.Models;

public class Professor
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O nome do professor é obrigatório.")]
    public required string Nome { get; set; }
    
    public ICollection<Turma>? Turmas { get; set; }
}