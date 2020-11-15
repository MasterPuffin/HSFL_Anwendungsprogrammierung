using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects {
    public class ClientCollection : ObservableCollection<Client> {
        public ClientCollection() {
            Client client1 = new Client();
            client1.Id = 345;
            client1.Name = "Samson";
            this.Add(client1);
        }
    }
}
