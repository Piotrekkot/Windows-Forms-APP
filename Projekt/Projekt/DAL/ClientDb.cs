using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DAL
{
    public interface ClientDb
    {
        IList<Client> GetClient();

        IList<Client> GetRabat();

        int UpdateClient(Client changedClient);

        void DeleteClient(Client ClientToDelete);


    }
}
