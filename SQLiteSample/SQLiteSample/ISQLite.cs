using SQLite.Net;
namespace SQLiteSample
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(); // GetConnectionメソッドを実行すると、SQLiteConnectionのインスタンスが取得できる
    }
}