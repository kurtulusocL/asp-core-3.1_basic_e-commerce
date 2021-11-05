using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class ToDoManager : IToDoService
    {
        private readonly IToDoDAL _toDoDAL;
        public ToDoManager(IToDoDAL toDoDAL)
        {
            _toDoDAL = toDoDAL;
        }
        public void Create(ToDo entity)
        {
            _toDoDAL.Add(entity);
        }

        public void Delete(ToDo entity)
        {
            _toDoDAL.Delete(entity);
        }

        public List<ToDo> GetAll()
        {
            return _toDoDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false && i.IsFinished == false);
        }

        public List<ToDo> GetAllTask()
        {
            return _toDoDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<ToDo> GetAllWithoutParameter()
        {
            return _toDoDAL.GetAll();
        }

        public ToDo GetById(int? id)
        {
            return _toDoDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _toDoDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _toDoDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _toDoDAL.SetDeleted(id);
        }

        public void SetFinished(int id)
        {
            _toDoDAL.SetFinished(id);
        }

        public void SetNotDeleted(int id)
        {
            _toDoDAL.SetNotDeleted(id);
        }

        public void SetNotFinished(int id)
        {
            _toDoDAL.SetNotFinished(id);
        }

        public void Update(ToDo entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _toDoDAL.Update(entity);
        }
    }
}
