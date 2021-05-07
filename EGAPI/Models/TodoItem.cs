using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGAPI.Models
{
    public class TodoItem : TodoItemDTO // Para nao duplicar atributos (Herança)
    {
        public string Secret { get; set; }
    }

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
