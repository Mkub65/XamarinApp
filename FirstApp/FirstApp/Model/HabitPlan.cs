using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Model
{
    public class HabitPlan : Habit
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
