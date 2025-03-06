using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using stokYönetimi.Entities;


namespace stokYönetimi.DAL
{
    public class DatabaseHelper
    {
        //  private static readonly string ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\hyare\\OneDrive\\Masaüstü\\stokYönetimi\\stokYönetimi.PL\\bin\\Release\\STOK.accdb";       // private static readonly string ConnectionString =
        // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\stokYönetimi\\stokYöetimi.PL\\bin\\Release\\STOK.accdb;";
        // private static readonly string ConnectionString =
        // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\STOK.accdb;";

        private static readonly string ConnectionString =
    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "STOK.accdb;";


        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }


        public int GetIcecekStok(int icecekId)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT icecek_stok FROM Icecekler WHERE icecek_ID = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@icecek_ID", icecekId);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public int GetNohutStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT bakliyat_stok FROM Bakliyatlar WHERE bakliyat_ID = 1"; // Nohut'un ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetMercimekStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT bakliyat_stok FROM Bakliyatlar WHERE bakliyat_ID = 2"; // Mercimek'in ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateMercimekStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Bakliyatlar SET bakliyat_stok = ? WHERE bakliyat_ID = 2"; // Mercimek'in ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@bakliyat_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public int GetFasulyeStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT bakliyat_stok FROM Bakliyatlar WHERE bakliyat_ID = 3"; // Fasulye'nin ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateFasulyeStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Bakliyatlar SET bakliyat_stc = ? WHERE bakliyat_ID = 3"; // Fasulye'nin ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@bakliyat_stc", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateNohutStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Bakliyatlar SET bakliyat_stok = ? WHERE bakliyat_ID = 1"; // Nohut'un ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@bakliyat_stc", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateIcecekStok(int icecekId, int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Icecekler SET icecek_stok = ? WHERE icecek_ID = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@icecek_stok", yeniStok);
                command.Parameters.AddWithValue("@icecek_ID", icecekId);
                command.ExecuteNonQuery();
            }
        }

        public int GetCipsStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT atistirmalik_stok FROM Atistirmaliklar WHERE atistirmalik_ID = 2"; // Cips'in ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public int GetDondurmaStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT atistirmalik_stok FROM Atistirmaliklar WHERE atistirmalik_ID = 3"; // Dondurma'nın ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateDondurmaStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Atistirmaliklar SET atistirmalik_stok = ? WHERE atistirmalik_ID = 3";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@atistirmalik_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }


        public int GetKolaStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT icecek_stok FROM Icecekler WHERE icecek_ID = 2"; // Kola'nın ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetSuStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT icecek_stok FROM Icecekler WHERE icecek_ID = 1"; // Su'nun ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateSuStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Icecekler SET icecek_stok = ? WHERE icecek_ID = 1"; // Su'nun ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@icecek_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public int GetSodaStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT icecek_stok FROM Icecekler WHERE icecek_ID = 3"; // Soda'nın ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateSodaStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Icecekler SET icecek_stok = ? WHERE icecek_ID = 3"; // Soda'nın ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@icecek_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public int GetCifStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT malzeme_stok FROM TemizlikUrunleri WHERE Kimlik = 1"; // CIF'in ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateCifStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE TemizlikUrunleri SET malzeme_stok = ? WHERE Kimlik = 1"; // CIF'in ID'si 1
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@malzeme_st", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public int GetCamasirSuyuStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT malzeme_stok FROM TemizlikUrunleri WHERE Kimlik = 2"; // Çamaşır Suyu'nun ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetYagCozucuStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT malzeme_stok FROM TemizlikUrunleri WHERE Kimlik = 3"; // Yağ Çözücü'nün ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void UpdateYagCozucuStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE TemizlikUrunleri SET malzeme_stok = ? WHERE Kimlik = 3"; // Yağ Çözücü'nün ID'si 3
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@malzeme_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCamasirSuyuStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE TemizlikUrunleri SET malzeme_stok = ? WHERE Kimlik = 2"; // Çamaşır Suyu'nun ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@malzeme_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }


        public void UpdateKolaStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Icecekler SET icecek_stok = ? WHERE icecek_ID = 2"; // Kola'nın ID'si 2
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@icecek_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }


        public void UpdateCipsStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Atistirmaliklar SET atistirmalik_stok = ? WHERE atistirmalik_ID = 2";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@atistirmalik_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCikolataStok(int yeniStok)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Atistirmaliklar SET atistirmalik_stok = ? WHERE atistirmalik_ID = 1";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@atistirmalik_stok", yeniStok);
                command.ExecuteNonQuery();
            }
        }

        public int GetCikolataStok()
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT atistirmalik_stok FROM Atistirmaliklar WHERE atistirmalik_ID = 1", connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }


        public List<TemizlikUrunleri> GetTemizlikUrunleri()
        {
            List<TemizlikUrunleri> temizlikUrunleriList = new List<TemizlikUrunleri>();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM TemizlikUrunleri", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    temizlikUrunleriList.Add(new TemizlikUrunleri
                    {
                        TemizlikUrunID = Convert.ToInt32(reader["Kimlik"]),
                        TemizlikUrunAd = reader["malzeme_ad"].ToString(),
                        TemizlikUrunStok = Convert.ToInt32(reader["malzeme_stok"])
                    });
                }
            }

            return temizlikUrunleriList;
        }
        public List<Icecekler> GetIcecekler()
        {
            List<Icecekler> iceceklerList = new List<Icecekler>();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Icecekler", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    iceceklerList.Add(new Icecekler
                    {
                        IcecekID = Convert.ToInt32(reader["icecek_ID"]),
                        IcecekAd = reader["icecek_ad"].ToString(),
                        IcecekStok = Convert.ToInt32(reader["icecek_stok"])
                    });
                }
            }

            return iceceklerList;
        }
        public List<Bakliyatlar> GetAllBakliyatlar()
        {
            List<Bakliyatlar> bakliyatlarList = new List<Bakliyatlar>();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Bakliyatlar"; // Veritabanınızda Bakliyatlar tablosu olduğunu varsayıyoruz.
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bakliyatlarList.Add(new Bakliyatlar
                        {
                            BakliyatAd = reader["bakliyat_ad"].ToString(),
                            BakliyatStok = Convert.ToInt32(reader["bakliyat_stok"])
                        });
                    }
                }
            }

            return bakliyatlarList;
        }
        public List<Bakliyatlar> GetBakliyatlar()
        {
            var bakliyatlar = new List<Bakliyatlar>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var command = new OleDbCommand("SELECT * FROM Bakliyatlar", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bakliyatlar.Add(new Bakliyatlar
                    {
                        BakliyatID = (int)reader["bakliyat_ID"],
                        BakliyatAd = reader["bakliyat_ad"].ToString(),
                        BakliyatStok = (int)reader["bakliyat_stok"]
                    });
                }
            }
            return bakliyatlar;
        }
        public List<Atistirmalik> GetAtistirmaliklar()
        {
            var atistirmaliklar = new List<Atistirmalik>();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new OleDbCommand("SELECT * FROM Atistirmaliklar", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                atistirmaliklar.Add(new Atistirmalik
                                {
                                    ID = reader["atistirmalik_ID"] != DBNull.Value ? (int)reader["atistirmalik_ID"] : 0,
                                    Ad = reader["atistirmalik_ad"]?.ToString(),
                                    Stok = reader["atistirmalik_stok"] != DBNull.Value ? (int)reader["atistirmalik_stok"] : 0
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya kullanıcıya mesaj gönderme işlemi yapılabilir
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

            return atistirmaliklar;
        }
    }
}


