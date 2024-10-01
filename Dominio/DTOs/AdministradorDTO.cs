using MinimalAPIS.Dominio.Enums;

namespace MinimalAPIS.DTOs
{
    public record AdministradorDTO
    {
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;
        public Perfil? Perfil { get; set; }
    }
}