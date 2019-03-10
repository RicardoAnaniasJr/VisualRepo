using MySql.Data.MySqlClient;

namespace TesteRepo
{
    class Connection
    {
        MySqlConnection cnn = new MySqlConnection("Server=localhost;" + "Database=pessoa;" + "Uid=root;" + "Pwd=Ricardo47;");




    }
}
