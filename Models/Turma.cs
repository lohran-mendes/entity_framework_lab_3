using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework_lab_3.Models;

public class Turma
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O nome da turma é obrigatório.")]
    public required string Nome { get; set; }
    
    [ForeignKey("Professor")]
    public int ProfessorId { get; set; }
    
    public Professor? Professor { get; set; }
}