using De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper {
    public class ClientViewModel {
        public Client myClient = new Client();

        public int Id {
            get {
                return myClient.Id;
            }
            set {
                myClient.Id = value;
            }
        }

        public string Name {
            get {
                return myClient.Name;
            }
            set {
                myClient.Name = value;
            }
        }


        public ClientViewModel(Client client) {
            this.myClient = client;
        }

        public ClientViewModel() {

        }
    }
}
