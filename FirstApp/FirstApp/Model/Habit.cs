using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Model
{
    public class Habit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
