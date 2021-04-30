using System;
using SQLite;
using EveryDay.View;
namespace EveryDay.Model
{
    [Table("Notes")]
    public class ModelClass
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
