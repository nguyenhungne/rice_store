using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync(CustomerFilter filter)
    {
        var query = _context.Customer.AsQueryable();

        // Apply filter for Name if provided
        if (!string.IsNullOrEmpty(filter.Name))
        {
            query = query.Where(c => c.Name.Contains(filter.Name));
        }

        // Apply filter for Phone if provided
        if (!string.IsNullOrEmpty(filter.Phone))
        {
            query = query.Where(c => c.Phone.Contains(filter.Phone));
        }

        // Apply filter for Email if provided
        if (!string.IsNullOrEmpty(filter.Email))
        {
            query = query.Where(c => c.Email.Contains(filter.Email));
        }

        return await query.ToListAsync();
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _context.Customer
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        if (!string.IsNullOrWhiteSpace(customer.Email) &&
            _context.Customer.Any(c => c.Email == customer.Email))
        {
            throw new InvalidOperationException("Customer with this email already exists.");
        }

        _context.Customer.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        var existingCustomer = await _context.Customer.FindAsync(customer.Id);
        if (existingCustomer == null)
        {
            throw new InvalidOperationException($"Customer with ID {customer.Id} not found.");
        }

        existingCustomer.Name = customer.Name;
        existingCustomer.Phone = customer.Phone;
        existingCustomer.Email = customer.Email;
        existingCustomer.Address = customer.Address;
        existingCustomer.Rank = customer.Rank;

        await _context.SaveChangesAsync();
        return existingCustomer;
    }

    public async Task DeleteCustomerAsync(int id)
    {
        var customer = await _context.Customer.FindAsync(id)
            ?? throw new InvalidOperationException($"Customer with ID {id} not found.");

        customer.IsDeleted = true;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        return await _context.Customer.ToListAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<Customer> GetCustomerByEmailAsync(string email)
    {
        return await _context.Customer
            .FirstOrDefaultAsync(c => c.Email == email);
    }

    public async Task<Customer> GetCustomerByPhoneAsync(string phone)
    {
        return await _context.Customer
            .FirstOrDefaultAsync(c => c.Phone == phone);
    }


}
