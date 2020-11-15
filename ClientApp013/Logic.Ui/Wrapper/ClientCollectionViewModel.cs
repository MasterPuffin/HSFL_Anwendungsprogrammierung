using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper {
    public class ClientCollectionViewModel: List<ClientViewModel> {
        private ClientCollection myClients;

        public ClientCollectionViewModel() {
            //eigene Model-Collection instatiieren
            myClients = new ClientCollection();

            //Alle Listenelemente des Models holen und Wrappen
            foreach(Client client in myClients) {
                this.Add(new ClientViewModel(client));
            }
        }
    }
}
