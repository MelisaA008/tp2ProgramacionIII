using tp2ProgramacionIII.DAL.Models;
using tp2ProgramacionIII.DAL.Repositories;

namespace tp2ProgramacionIII.BL.Services
{
    public class PersonaService
    {
        private readonly PersonaRepository _repo;

        public PersonaService(PersonaRepository repo)
        {
            _repo = repo;
        }

        public List<Persona> ObtenerPersonas()
        {
            return _repo.GetPersonas();
        }
    }
}
