using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Slide2
{
    public  interface ISlide2Application
    {
        OperationResult Create(CreateSlide2 command);
        OperationResult Edit(EditSlide2 command);    
        OperationResult Remove(long id);
        OperationResult Restore(long id);   
        EditSlide2 GetDetails(long id);
        List<Slide2ViewModel> Getlist();
    }
}
