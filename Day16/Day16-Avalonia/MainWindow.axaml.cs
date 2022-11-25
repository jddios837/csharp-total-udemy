using System.Data;
using Avalonia.Controls;
using Microsoft.Data.SqlClient;

namespace Day16_Avalonia;

public partial class MainWindow : Window
{
    private SqlConnection _sqlConnection;
    public MainWindow()
    {
        InitializeComponent();

        string connectionString =
            "Server=localhost,1433;database=Day16RazorDB;User Id=sa;Password=Tetra714217#;TrustServerCertificate=True";
        _sqlConnection = new SqlConnection(connectionString);
    }

    private void MuestraZoos()
    {
        string consulta = "select * from Zoo";

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, _sqlConnection);

        using (sqlDataAdapter)
        {
            DataTable zooTabla = new DataTable();
            sqlDataAdapter.Fill(zooTabla);
           
            zooTabla.
        }
    }
}