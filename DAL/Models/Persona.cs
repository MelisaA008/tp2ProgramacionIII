using System;

namespace tp2ProgramacionIII.DAL.Models
{
    public class Persona
    {
        public int Id { get; set; }

        // nombre completo
        public string? NombreCompleto { get; set; }

        // email
        public string? Email { get; set; }

        // domicilio
        public string? Domicilio { get; set; }

        // fecha de nacimiento
        public DateTime FechaNacimiento { get; set; }

        // ruta de imagen
        public string? RutaImagen { get; set; } = "images/persona.png";
    }
}
