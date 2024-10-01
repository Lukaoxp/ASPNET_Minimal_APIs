using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPIS.Dominio.Entidades;

public class Veiculo
{
    private string _nome = default!;
    private string _marca = default!;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(150)]
    public string Nome { get => _nome; set => _nome = value.ToUpper(); }

    [Required]
    [StringLength(100)]
    public string Marca { get => _marca; set => _marca = value.ToUpper(); }

    [Required]
    public int Ano { get; set; } = default!;
}