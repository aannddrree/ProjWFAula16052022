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
            //Banco de dados
        }
        public List<Cliente> findAll()
        {
            return lst;
            //Banco de dados
        }
    }
}
