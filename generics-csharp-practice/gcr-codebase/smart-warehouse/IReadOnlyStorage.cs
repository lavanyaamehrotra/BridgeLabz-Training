using System.Collections.Generic;
// interface
public interface IReadOnlyStorage<out T>{
    IEnumerable<T> GetAllItems();
}
