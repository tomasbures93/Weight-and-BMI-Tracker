using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BMI.models;
using Microsoft.EntityFrameworkCore;

namespace BMI.Models
{
    public class ProfilViewModel : INotifyPropertyChanged
    {
        private readonly PersonDBContext _dbContext;

        public ICommand SaveDataCommand { get; }

        public User User { get; set; }

        public ProfilViewModel(User user, PersonDBContext dbContext)
        {
            _dbContext = dbContext;
            User = user;
            SaveDataCommand = new Command(async () => await SaveDataToDatabaseAsync());
            LoadUserDataAsync();
        }

        public string UserName
        {
            get => User.UserName;
            set
            {
                if (User.UserName != value)
                {
                    User.UserName = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Weight
        {
            get => User.Weight;
            set
            {
                if (User.Weight != value)
                {
                    User.Weight = value;
                    OnPropertyChanged(nameof(Weight));
                    OnPropertyChanged(nameof(BMI));
                }
            }
        }

        public double Height
        {
            get => User.Height;
            set
            {
                if (User.Height != value)
                {
                    User.Height = value;
                    OnPropertyChanged(nameof(Height));
                    OnPropertyChanged(nameof(BMI));
                }
            }
        }

        public DateTime DateOfBirth
        {
            get => User.DateOfBirth;
            set
            {
                if (User.DateOfBirth != value)
                {
                    User.DateOfBirth = value;
                    OnPropertyChanged();
                }
            }
        }

        public double BMIcalc
        {
            get
            {
                if (Height > 0)
                {
                    return Weight / (Height/100 * Height/100); // BMI-Formel: Gewicht (kg) / Größe (m)^2
                }
                return 0;
            }
        }

        private async void LoadUserDataAsync()
        {
            var user = await _dbContext.Personen.FirstOrDefaultAsync(u => u.ID == 1);
            if (user != null)
            {
                User = user;
                OnPropertyChanged(nameof(User));
            }
        }

        public async Task SaveDataToDatabaseAsync()
        {
            try
            {
                _dbContext.Personen.Update(User); // Update the user entry
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle error (maybe log it or show a message)
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
