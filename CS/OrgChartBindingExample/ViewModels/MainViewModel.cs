using OrgChartBindingExample.Model;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OrgChartBindingExample.ViewModels
{
    [POCOViewModel]
    public class MainViewModel {

        public virtual IList<Contact> Contacts { get; protected set; }

        protected MainViewModel() {

            if (!ViewModelBase.IsInDesignMode)
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