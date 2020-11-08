using De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper {
    public class ClientViewModel {
        private Client myClient = new Client();

        public ClientViewModel(Client client) {
            this.myClient = client;
        }

        public ClientViewModel() {

        }
    }
}
