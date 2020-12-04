using De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Logic.Ui.ViewModels {
    public class MainWindowViewModel {
        public ClientCollectionViewModel MyList { get; set; }
        public RelayCommand AddClientToList { get; }

        public MainWindowViewModel(ClientCollectionViewModel model) {
            AddClientToList = new RelayCommand(() => AddClientToListMethod());
            //MyList = new ClientCollectionViewModel();
            MyList = model;
        }

        private void AddClientToListMethod() {
            ClientCollectionViewModel list = MyList;
            if (list != null) {
                ClientViewModel clientVM = new ClientViewModel();
                //clientVM.Id = Int16.Parse(IdTextBox.Text);
                //clientVM.Name = NameTextBox.Text;
                list.Add(clientVM);
            }
        }
    }
}
