using System.Collections.Generic;
using _0_Framework.Application;
using DiscountManagement.Application.Contracts.CoustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;

namespace DiscountManagement.Application;

public class CustomerDiscountApplication : ICustomerDiscountApplication
{
    private readonly ICustomerDiscountRepository _coustomerDiscountRepository;

    public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
    {
        _coustomerDiscountRepository = customerDiscountRepository;
    }

    public OperationResult Define(DefineCustomerDiscount command)
    {
        var operation = new OperationResult();
        if (_coustomerDiscountRepository.Exists(x =>
                x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var startDate = command.StartDate.ToGeorgianDateTime();
        var endDate = command.EndDate.ToGeorgianDateTime();
        var customerDiscount = new CustomerDiscount(command.ProductId, command.DiscountRate,
            startDate, endDate, command.Reason);
        _coustomerDiscountRepository.Create(customerDiscount);
        _coustomerDiscountRepository.SaveChanges();
        return operation.Succedded();
    }

    public OperationResult Edit(EditCustomerDiscount command)
    {
        var operation = new OperationResult();
        var customerDiscount = _coustomerDiscountRepository.Get(command.Id);

        if (customerDiscount == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        if (_coustomerDiscountRepository.Exists(x => x.ProductId == command.ProductId
                                                     && x.DiscountRate == command.DiscountRate && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        var startDate = command.StartDate.ToGeorgianDateTime();
        var endDate = command.EndDate.ToGeorgianDateTime();
        customerDiscount.Edit(command.ProductId, command.DiscountRate,
            startDate, endDate, command.Reason);
        _coustomerDiscountRepository.SaveChanges();
        return operation.Succedded();
    }

    public EditCustomerDiscount GetDetails(long id)
    {
        return _coustomerDiscountRepository.GetDetails(id);
    }

    public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
    {
        return _coustomerDiscountRepository.Search(searchModel);
    }
}