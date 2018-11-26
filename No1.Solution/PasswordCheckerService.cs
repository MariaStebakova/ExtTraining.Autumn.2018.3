using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private readonly Func<string, bool>[] validationConditions;

        public PasswordCheckerService(IRepository repository, params Func<string, bool>[] validationCases)
        {
            this.repository = repository;
            this.validationConditions = validationCases;
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return (false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return (false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return (false, $"{password} length too long");

            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return (false, $"{password} hasn't alphanumerical chars");

            // check if password contains at least one digit character 
            if (!password.Any(char.IsNumber))
                return (false, $"{password} hasn't digits");

            if (validationConditions == null)
            {
                repository.Create(password);

                return (true, "Password is Ok. User was created");
            }

            //check if password correspond custom conditions
            foreach (var func in validationConditions)
            {
                if (!func(password))
                    return (false, $"{password} doesn't correspond some of custom conditions");
            }

            repository.Create(password);

            return (true, "Password is Ok. User was created");
        }
    }

    //Интерфейс необходим для устранения привязки к определенному репозиторию
    //Массив делегатов выбран, потому что в условиии сказано что может быть несколько дополнительных условий
    //проверки пароля
}
