using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Model;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        readonly Habit selectedHabit;

        public DetailsPage(Habit selectedHabit)
        {
            InitializeComponent();

            this.selectedHabit = selectedHabit;

            habitName.Text = selectedHabit.Name;
            habitDescription.Text = selectedHabit.Description;
            habitStartDate.Text = selectedHabit.StartDate.ToString();
            habitEndDate.Text = selectedHabit.EndDate.ToString();
        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DateBaseLocation))
            {
                conn.CreateTable<Habit>();
                int rows = conn.Delete(selectedHabit);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Habit succesfully deleted", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Habit failed to be deleted", "Ok");
                }
            }
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            selectedHabit.Name = habitName.Text;
            selectedHabit.Description = habitDescription.Text;
            selectedHabit.StartDate = Convert.ToDateTime(habitStartDate.Text);
            selectedHabit.EndDate = Convert.ToDateTime(habitEndDate.Text);

            using (SQLiteConnection conn = new SQLiteConnection(App.DateBaseLocation))
            {
                conn.CreateTable<Habit>();
                int rows = conn.Update(selectedHabit);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Habit succesfully updated", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Habit failed to be updated", "Ok");
                }
            }
        }

    }
}

