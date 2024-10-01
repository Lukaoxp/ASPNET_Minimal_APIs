namespace MinimalAPIS.Dominio.ModelViews
{
    public record AdministradorMovelView
    {
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}