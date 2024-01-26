using DevExpress.Mvvm;
using OrgChartBindingExample.Model;
using System.Collections.Generic;

namespace OrgChartBindingExample.ViewModels {
    public class MainViewModel : ViewModelBase {

        public IList<Contact> Contacts { get; protected set; }

        public MainViewModel() {

            if (!IsInDesignMode)
                InitializeInRuntime();
            else
                InitializeInDesingMode();
        }
        void InitializeInRuntime() {

            Contacts = new ContactContextInitializer().Generate();
        }
        void InitializeInDesingMode() {
            Contacts = new List<Contact>() {
                new Contact("FirstName", "LastName") {
                    Gender = Gender.Female, Email = "email", Phone = "(555)555-0000",
                    Address = "Address", City = "City", State = "AA", Zip = "11111",
                },
            };
        }
    }
}