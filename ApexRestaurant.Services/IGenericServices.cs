using System.Collections.Generic;
//IGS
namespace ApexRestaurant.Services
{
public interface IGenericService<T>
{
IList<T> GetAll();

T GetById(int id);

void Insert(T entity);

void Update(T entity);

void Delete(T entity);
}
}