using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    public class FuncionarioController
    {
        public bool efetuarLogin(Funcionario func)
        {
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            bool autenticado = false;
            
            autenticado = funcDAO.Logar(func);

            if (autenticado)
            {
                return true;
            }
            return false;
        }
        
        public bool cadastrarFuncionario(Funcionario novoFunc)
        {
            FuncionarioDAO funDao = new FuncionarioDAO();

            bool cadastrado = funDao.InserirFuncionario(novoFunc);
            if (cadastrado)
            {
                return true;
            }
            return false;
        }
    }
}
