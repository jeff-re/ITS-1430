/*
 * Geoffrey Kio
 * ITSE 1430
 * 11/25/2019
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        protected override Product AddCore ( Product product )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("AddProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var parmName = new SqlParameter ("@name", product.Name);
                cmd.Parameters.Add (parmName);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@isDiscontinued", product.IsDiscontinued);

                conn.Open ();
                var result = (decimal)cmd.ExecuteScalar ();
                product.Id = Convert.ToInt32 (result);

                return product;
            };
        }

        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet ();

            //Create a connection and open
            using (var conn = CreateConnection ())
            {
                using (var cmd = conn.CreateCommand ())
                {
                    cmd.CommandText = "GetAllProducts";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter () {
                        SelectCommand = cmd
                    };

                    da.Fill (ds);
                };
            };

            var table = ds.Tables.OfType<DataTable> ().FirstOrDefault ();
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow> ())
                {
                    var movie = new Product () {
                        Id = (int)row[0],
                        Name = row["Name"] as string,
                        Description = row.Field<string> ("Description"),
                        Price = row.Field<decimal> ("Price"),
                        IsDiscontinued = row.Field<bool> ("IsDiscontinued"),
                    };

                    yield return movie;
                };
            };
        }

        protected override Product GetCore ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("GetProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@id", id);

                conn.Open ();
                using (var reader = cmd.ExecuteReader ())
                {

                    if (reader.Read ())
                    {
                        var isDiscontinuedIndex = reader.GetOrdinal ("IsDiscontinued");
                        var priceIndex = reader.GetOrdinal ("Price");
                        var descriptionIndex = reader.GetOrdinal ("Description");

                        var movie = new Product () {
                            Id = (int)reader[0],
                            Name = reader["name"] as string,

                            Description = !reader.IsDBNull (descriptionIndex) ? reader.GetString (descriptionIndex) : "",
                            Price = (decimal)reader.GetValue (priceIndex),
                            IsDiscontinued = reader.GetBoolean (isDiscontinuedIndex)
                        };

                        return movie;
                    };
                };
            };

            return null;
        }

        protected override void RemoveCore ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("RemoveProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add ("@id", SqlDbType.Int);
                cmd.Parameters[0].Value = id;

                conn.Open ();
                cmd.ExecuteNonQuery ();
            };
        }

        protected override Product UpdateCore ( Product existing, Product product )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("UpdateProduct", conn))
            {
                product.Id = existing.Id;

                cmd.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter ("@name", product.Name);
                cmd.Parameters.Add (parmName);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@isDiscontinued", product.IsDiscontinued);
                cmd.Parameters.AddWithValue ("@id", product.Id);

                conn.Open ();
                cmd.ExecuteNonQuery ();

                return product;
            };
        }

        private SqlConnection CreateConnection ()
        {
            var conn = new SqlConnection (_connectionString);
            return conn;
        }

        private readonly string _connectionString;
    }
}

