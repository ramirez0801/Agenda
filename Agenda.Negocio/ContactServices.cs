using Agenda.Datos;
using Agenda.Entidades;
namespace Agenda.Negocio
{
    public class ContactServices
    {
        private readonly IRepository<Contacto> _repo;

        public ContactServices(IRepository<Contacto> repo)
        {
            _repo = repo;
        }

        public void CreateContact(string name, string email, string phone, string adress, string city)
        {
            var contac = new Contacto
            {
                Id = ++ContactRepository.contContacts,
                Name = name,
                Email = email,
                Phone = phone,
                Address = adress,
                City = city
            };

            _repo.Add(contac);
        }

        public void GetAll()
        {
            _repo.GetAll();
        }

        public Contacto GetContacto(Contacto contacto)
        {
            if (contacto == null)
            {
                Console.WriteLine("Contacto NULO");
                return null;
            }
            return _repo.GetById(contacto.Id);
        }

        public void Update(Contacto contacto)
        {
            if(contacto == null)
            {
                Console.WriteLine("Contacto NULO");
                return;
            }
            _repo.Update(contacto);
        }
    }
}
