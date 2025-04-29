using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

using rice_store.models;
using rice_store.utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.services;

public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync(CustomerFilter filter);
    Task<Customer> GetCustomerByIdAsync(int id);
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<Customer> UpdateCustomerAsync(Customer customer);
    Task DeleteCustomerAsync(int id);
    Task<int> UpdateAllCustomerRanksAsync();
}

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ISalesOrderRepository _salesOrderRepository;
    private readonly IEmailService _emailService;

    public CustomerService(ICustomerRepository customerRepository, ISalesOrderRepository salesOrderRepository, IEmailService emailService)
    {
        _customerRepository = customerRepository;
        _salesOrderRepository = salesOrderRepository;
        _emailService = emailService;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync(CustomerFilter filter)
    {
        return await _customerRepository.GetAllCustomersAsync(filter);
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _customerRepository.GetCustomerByIdAsync(id);
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        return await _customerRepository.AddCustomerAsync(customer);
    }

    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        return await _customerRepository.UpdateCustomerAsync(customer);
    }

    public async Task DeleteCustomerAsync(int id)
    {
        await _customerRepository.DeleteCustomerAsync(id);
    }

    public async Task<int> UpdateAllCustomerRanksAsync()
    {
        var customers = await _customerRepository.GetAllCustomersAsync();
        List<(Customer customer, string oldRank, string newRank)> upgradedCustomers = new List<(Customer, string, string)>();


        foreach (var customer in customers)
        {
            var totalSpent = await _salesOrderRepository.GetTotalAmountByCustomerIdAsync(customer.Id);
            string newRank = CustomerUtils.GetRankCustomer(totalSpent);

            if (customer.Rank != newRank)
            {
                string oldRank = customer.Rank;
                customer.Rank = newRank;
                upgradedCustomers.Add((customer, oldRank, newRank));
            }
        }

        await _customerRepository.SaveChangesAsync();

        // chay gui eemail o backround, khong doi
        _ = Task.Run(async () =>
        {
            foreach (var upgraded in upgradedCustomers)
            {
                await _emailService.SendRankUpgradeEmailAsync(upgraded.customer, upgraded.oldRank, upgraded.newRank);
            }
        });


        return upgradedCustomers.Count;
    }
}
