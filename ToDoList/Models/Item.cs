using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool Completed {get; set; }
        public DateTime DueDate {get; set;}

        public virtual ICollection<CategoryItem> JoinEntities { get;}

        // public static void OrderByDate()
        // {
        //     IEnumerable<Item> orderedItems = items.OrderBy(item => item.DueDate);
        // }

    }
}