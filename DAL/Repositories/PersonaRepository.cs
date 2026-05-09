using tp2ProgramacionIII.DAL.Models;
using System;
using System.Collections.Generic;

namespace tp2ProgramacionIII.DAL.Repositories
{
    public class PersonaRepository
    {
        // Lista en memoria que se mantiene viva mientras corre la app
        private readonly List<Persona> personas = new List<Persona>
        {
            new Persona { Id = 1, NombreCompleto = "Juan Pérez", Email = "juan@mail.com", Domicilio = "Calle 123", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1995, 5, 10) },
            new Persona { Id = 2, NombreCompleto = "María Gómez", Email = "maria@mail.com", Domicilio = "Av. Siempre Viva 742", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(2000, 3, 22) },
            new Persona { Id = 3, NombreCompleto = "Pedro López", Email = "pedro@mail.com", Domicilio = "Boulevard Central 456", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1986, 11, 5) },
            new Persona { Id = 4, NombreCompleto = "Lucía Fernández", Email = "lucia@mail.com", Domicilio = "Ruta Provincial 7", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1991, 7, 14) },
            new Persona { Id = 5, NombreCompleto = "Carlos Ramírez", Email = "carlos@mail.com", Domicilio = "Pasaje Norte 88", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1997, 1, 19) },
            new Persona { Id = 6, NombreCompleto = "Ana Martínez", Email = "ana@mail.com", Domicilio = "Diagonal Sur 321", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1993, 9, 30) },
            new Persona { Id = 7, NombreCompleto = "Diego Suárez", Email = "diego@mail.com", Domicilio = "Camino Real 12", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1981, 12, 2) },
            new Persona { Id = 8, NombreCompleto = "Sofía Torres", Email = "sofia@mail.com", Domicilio = "Plaza Mayor 55", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(2004, 6, 18) },
            new Persona { Id = 9, NombreCompleto = "Martín Castro", Email = "martin@mail.com", Domicilio = "Barrio Nuevo 101", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1988, 4, 27) },
            new Persona { Id = 10, NombreCompleto = "Valentina Rojas", Email = "valentina@mail.com", Domicilio = "Callejón Este 77", RutaImagen = "images/persona.png", FechaNacimiento = new DateTime(1996, 8, 15) }
        };

        // Obtener todas las personas
        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        // Agregar una nueva persona
        public void AgregarPersona(Persona persona)
        {
            persona.Id = personas.Count + 1; // Id automático
            personas.Add(persona);
        }
    }
}


