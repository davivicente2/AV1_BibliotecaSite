using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDB.model.Models;

namespace BibliotecaDB.model.Repositories
{
    public class RepositoryEmprestimos : RepositoryBase<Emprestimos>
    {
        public RepositoryEmprestimos(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}