using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.Slide2;

public interface ISlide2Application
{
    OperationResult Create(CreateSlide2 command);
    OperationResult Edit(EditSlide2 command);
    OperationResult Remove(long id);
    OperationResult Restore(long id);
    EditSlide2 GetDetails(long id);
    List<Slide2ViewModel> Getlist();
}