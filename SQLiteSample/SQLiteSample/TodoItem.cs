using System;
using SQLite.Net.Attributes;

namespace SQLiteSample
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }             // <-1
        public string Text { get; set; }        // <-2
        public DateTime CreatedAt { get; set; } // <-3
        public bool Delete { get; set; }        // <-4
    }

    public static void InsertUser(string name)
    {
        //データベースに接続
        using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
        {

            try
            {
                //データベースにUserテーブルを作成します
                db.CreateTable<UserModel>();

                //Userテーブルに行追加します
                db.Insert(new UserModel() { Name = name });

                db.Commit();

            }
            catch (Exception e)
            {

                db.Rollback();
                System.Diagnostics.Debug.WriteLine(e);

            }
        }
    }
}