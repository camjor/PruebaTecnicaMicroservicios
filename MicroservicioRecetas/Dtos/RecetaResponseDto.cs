public class RecetaResponseDto {
        public int Id { get; set; }
        public string? Codigo { get; set; } // Código único
        public string? PacienteId { get; set; }

        public string? MedicoId { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; } // "Activa", "Vencida", "Entregada"
}