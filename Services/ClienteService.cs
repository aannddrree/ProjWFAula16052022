using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ClienteService
    {
        static List<Cliente> lst = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            lst.Add(cliente);
        }
        public List<Cliente> findAll()
        {
            return lst;
        }
    }
}
