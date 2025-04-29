using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomersAsync(CustomerFilter filter);
    Task<Customer> GetCustomerByIdAsync(int id);
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<Customer> UpdateCustomerAsync(Customer customer);
    Task DeleteCustomerAsync(int id);
    Task<IEnumerable<Customer>> GetAllCustomersAsync();
    Task SaveChangesAsync();
}
