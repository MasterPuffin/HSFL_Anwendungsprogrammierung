using De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.ViewModels {
    public class NewClientWindowViewModel {
        public int Identifier { get; set; }
        public String Name { get; set; }
        public ClientCollectionViewModel MyList { get; set; }

        public RelayCommand AddClient { get; }

        public NewClientWindowViewModel(ClientCollectionViewModel model) {
            AddClient = new RelayCommand(() => AddClientMethod());
            MyList = model;
        }

        private void AddClientMethod() {
            Console.Out.WriteLine("Kunde hinzugefügt");
        }
    }
}
