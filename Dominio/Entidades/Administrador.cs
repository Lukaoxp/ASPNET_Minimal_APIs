using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MinimalAPIS.Dominio.Enums;

namespace MinimalAPIS.Dominio.Entidades;

public class Administrador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; } = default!;

    [Required]
    [StringLength(255)]
    public string Email { get;set; } = default!;

    [Required]
    [StringLength(50)]
    public string Senha { get;set; } = default!;

    public Perfil Perfil { get;set; }
}