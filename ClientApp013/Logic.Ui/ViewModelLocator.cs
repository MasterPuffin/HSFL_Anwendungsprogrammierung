using De.HsFlensburg.ClientApp013.Logic.Ui.ViewModels;
using De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui {
    public class ViewModelLocator {
        public ClientCollectionViewModel MyList { get; set; }
        public ViewModelLocator() {
            //Model-Instanz erzeugen
            MyList = new ClientCollectionViewModel();

            //und den einzelnen View-Modls als Referenz übergeben
            MainWindowVM = new MainWindowViewModel(MyList);
            NewClientWindowVM = new NewClientWindowViewModel(MyList);
        }

        public MainWindowViewModel MainWindowVM { get; }
        public NewClientWindowViewModel NewClientWindowVM { get; }
    }
}
