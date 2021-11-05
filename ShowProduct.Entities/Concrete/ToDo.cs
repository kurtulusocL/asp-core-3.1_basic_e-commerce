using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class ToDo : EntityBase, IToDo
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string NameSurname { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsFinished { get; set; }
        public void SetFinished()
        {
            IsFinished = false;
        }

        public ToDo()
        {
            SetFinished();
        }
    }
}