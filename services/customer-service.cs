using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync(CustomerFilter filter);
    Task<Customer> GetCustomerByIdAsync(int id);
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<Customer> UpdateCustomerAsync(Customer customer);
    Task DeleteCustomerAsync(int id);
}

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
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
}
