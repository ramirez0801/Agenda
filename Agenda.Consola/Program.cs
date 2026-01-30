using System;
using Agenda.Negocio;
using Agenda.Datos;

namespace Agenda.Consola
{
    class Program
    {
        static void Main()
        {
            var repository = new ContactRepository();
            var service = new ContactService(repository);
            var facade = new AgendaFacade(service);

            while(true)
            {
                Console.WriteLine("\nAgenda de Contactos");
                Console.WriteLine("1 Agregar Contactos");
                Console.WriteLine("2 Ver contactos");
                Console.WriteLine("3 Eliminar");
                Console.WriteLine("4 Salir");
                Console.Write("Elige una opcion: ");
                var opc = Console.ReadLine();

                switch(opc)
                {
                    case "1":
                        Console.WriteLine("Nombre: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        var email = Console.ReadLine();
                        Console.WriteLine("Telefono: ");
                        var phone = Console.ReadLine();

                        facade.AddContact(name, email, phone);
                        Console.WriteLine("Contacto agregado");
                        break;
                    case "2":
                        Console.WriteLine("\nContactos");
                        foreach (var c in facade.GetAllContacts())
                            Console.WriteLine($"{c.Id}. {c.Name} - {c.Email} - {c.Phone}");
                        break;
                    case "3":
                        Console.WriteLine("\nContactos");
                        foreach (var c in facade.GetAllContacts())
                            Console.WriteLine($"{c.Id}. {c.Name} - {c.Email} - {c.Phone}");

                        Console.Write("\nID a eliminar: ");
                        int id = int.Parse(Console.ReadLine());
                        while (true)
                        {
                            var c = facade.GetContactById(id);
                            Console.WriteLine($"Esta seguro de eliminar el contacto {c.Id}. {c.Name}? (y/n)");
                            var conf = Console.ReadLine();

                            if (conf == "y")
                            {
                                facade.DeleteContact(id);
                                Console.WriteLine("Contacto eliminado");
                                break;
                            }
                            else if (conf == "n")
                                break;
                            else
                                Console.WriteLine("Opcion no valida");
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break; 
                }
            }
        }
    }
}