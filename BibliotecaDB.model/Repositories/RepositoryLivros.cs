using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDB.model.Models;

namespace BibliotecaDB.model.Repositories
{
    public class RepositoryLivros : RepositoryBase<Livros>
    {
        public RepositoryLivros(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}