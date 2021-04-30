using System;
using System.Collections.Generic;
using SQLite;
using EveryDay.View;

namespace EveryDay.Model
{
    public class NoteRepository
    {
        SQLiteConnection database;
        public NoteRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<ModelClass>();
        }
        public IEnumerable<ModelClass> GetItems()
        {
            return database.Table<ModelClass>().ToList();
        }
        public ModelClass GetItem(int id)
        {
            return database.Get<ModelClass>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<ModelClass>(id);
        }
        public int SaveItem(ModelClass item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}