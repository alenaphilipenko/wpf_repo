using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DB.Interfaces;

namespace Shop.DB.Repositoties
{
    public class BaseRepository<T> where T : IEntity
    {
        private T[] array;

        public void Add(T entity) { }
        public void Delete(T entity) { }
        public void Update(T entity) { }
        public T FindById(int Id) { return array[Id]; }
    }
}
