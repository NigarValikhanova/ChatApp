using ChatApp.CustomControlls;
using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<StatusDataModel> statusThumbsCollection;

        public ViewModel() 
        {

            // Lets bind our collection to itemscontrol
            statusThumbsCollection = new ObservableCollection<StatusDataModel>()
            {
                // Since we want to keep first status blank for the user to add own status
                new StatusDataModel()
                {
                    IsMeAddStatus=true
                }, 
                
                new StatusDataModel()
                {
                    ContactName="Elgun",
                    ContactPhoto=new Uri("/assets/1.png", UriKind.RelativeOrAbsolute),
                    StatusImage =new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus=false
                },
                new StatusDataModel()
                {
                    ContactName="Shamkhal",
                    ContactPhoto=new Uri("/assets/2.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage =new Uri("/assets/8.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus=false
                },
                new StatusDataModel()
                {
                    ContactName="Lala",
                    ContactPhoto=new Uri("/assets/3.png", UriKind.RelativeOrAbsolute),
                    StatusImage =new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus=false
                },
            };
        }
    }
}
