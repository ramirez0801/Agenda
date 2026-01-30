using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Negocio
{
    public class AgendaFacade
    {
        private readonly ContactService _contactService;

        public AgendaFacade(ContactService contactService) => _contactService = contactService;

        public void AddContact(string name, string email, string phone) => _contactService.AddContact(name, email, phone);

        public void DeleteContact(int id) => _contactService.DeleteContact(id);

        public IEnumerable<Contacto> GetAllContacts() => _contactService.GetAll();
        public Contacto GetContactById(int id) => _contactService.GetContactById(id);
    }
}
