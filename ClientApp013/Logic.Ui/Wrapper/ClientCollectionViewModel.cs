using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper {
    public class ClientCollectionViewModel {
        private Client myClient = new Client();

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
    }
}
