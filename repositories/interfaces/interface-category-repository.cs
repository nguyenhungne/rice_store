using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
}
