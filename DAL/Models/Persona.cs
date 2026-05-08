using System;
using System.ComponentModel.DataAnnotations;

namespace tp2ProgramacionIII.DAL.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre y Apellido es obligatorio")]
        public required string NombreCompleto { get; set; }
        public required string Email { get; set; }
        public required string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string RutaImagen { get; set; } = "images/persona.png";
    }
} 
    