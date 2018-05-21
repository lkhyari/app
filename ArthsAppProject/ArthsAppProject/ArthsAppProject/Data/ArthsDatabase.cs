﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using System.Security.Cryptography;

namespace ArthsAppProject
{
    public class ArthsDatabase
    {
		readonly SQLiteAsyncConnection database;
		private User admin;
		public ArthsDatabase(string dbPath)
        {
			admin = new User();
			admin.Login_u = "test";
            admin.Pass_u = Hash.HashSHA512("test");
            database = new SQLiteAsyncConnection(dbPath);
            database.DropTableAsync<User>().Wait();
            database.CreateTableAsync<User>().Wait();
            SaveUserAsync(admin);
        }

       

        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id_u != 0)
            {
                return database.UpdateAsync(user);
            }
            else
            {
                return database.InsertAsync(user);
            }
        }

        public Task<User> GetUserAsync(int id)
        {
			return database.Table<User>().Where(i => i.Id_u.Equals(id)).FirstOrDefaultAsync();
        }

		public Task<User> GetUserByLogin(String login){

			return database.Table<User>().Where(i => i.Login_u.Equals(login)).FirstOrDefaultAsync();
		}


    }
}
