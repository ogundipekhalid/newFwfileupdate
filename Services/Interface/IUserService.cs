using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_File_Project.Models.Entities;

namespace My_File_Project.Services.Interface
{
    public interface IUserService
    {
        User? CreateUser(string firstName, string lastName, DateTime dob, string email, string password, string role);
        User? Get(Func<User, bool> pred);
        List<User> GetSelected(Func<User, bool> pred);
        void Delete(User user);
        (bool, List<User>) Login(string email, string password);
        void UpdateFile();
        void UpdateList();
    }
}