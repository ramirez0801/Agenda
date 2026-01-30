using Agenda.Datos;
using Agenda.Entidades;

namespace Agenda.Negocio
{
    public class ContactService
    {
        private readonly IRepository<Contacto> _repository;
        public ContactService(IRepository<Contacto> repository)
        {
            _repository = repository;
        }

        public void AddContact(string name, string email, string phone)
        {
            var contact = new Contacto
            {
                Name = name,
                Email = email,
                Phone = phone
            };

            _repository.Add(contact);
        }

        public void UpdateContact(Contacto contact) => _repository.Update(contact);

        public void DeleteContact(int id) => _repository.Delete(id);

        public Contacto GetContactById(int id) => _repository.GetById(id);

        public IEnumerable<Contacto> GetAll() => _repository.GetAll();

    }
}
