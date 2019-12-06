using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    class ClienteController
    {
        public bool cadastrarCliente(Cliente cliente)
        {
            ClienteDAO cliDAO = new ClienteDAO();

            bool cadastrado = cliDAO.inserirCliente(cliente);

            if (cadastrado)
            {
                return true;
            }

            return false;
        }
    }
}
