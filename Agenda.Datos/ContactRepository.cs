using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entidades;
using Agenda.Datos;

namespace Agenda.Datos
{
    public class ContactRepository : IRepository<Contacto>
    {
        private readonly List<Contacto> _contacts = new List<Contacto>();
        public static int contContacts;
        public void Add(Contacto c) => _contacts.Add(c);
        public IEnumerable<Contacto> GetAll() => _contacts;
        public Contacto GetById(int id) => _contacts.FirstOrDefault(x => x.Id == id);
        public void Update(Contacto c)
        {
            var existing = GetById(c.Id);
            if(existing != null)
            {
                existing.Name = c.Name;
                existing.Email = c.Email;
                existing.Phone = c.Phone;
                existing.City = c.City;
                existing.Address = c.Address;
            }
            
        }
        public void Delete(int id) => _contacts.RemoveAll(x => x.Id == id);
    }
}
