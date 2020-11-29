using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.ViewModels {
    public class NewClientWindowViewModel {
        public RelayCommand AddClient { get; }

        public NewClientWindowViewModel() {
            AddClient = new RelayCommand(() => AddClientMethod());
        }

        private void AddClientMethod() {
            Console.Out.WriteLine("Kunde hinzugefügt");
        }
    }
}
