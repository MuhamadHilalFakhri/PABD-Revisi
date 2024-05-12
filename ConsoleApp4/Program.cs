using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace pendaftaran_pasien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            try
            {
                Console.Clear();
                string strKoneksi = $"Data source = LAPTOP-UI8UU9SL\\HILAL; initial catalog = v2; User ID = sa; password = hilal123";
                SqlConnection conn = new SqlConnection(strKoneksi);
                conn.Open();
                Console.Clear();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMenu Antrian Pasien");
                        Console.WriteLine("1. Pasien");
                        Console.WriteLine("2. Antrian");
                        Console.WriteLine("3. Dokter");
                        Console.WriteLine("4. Informasi Antrian");
                        Console.WriteLine("5. Keluar");
                        Console.WriteLine("\nEnter your choice (1-5): ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                pr.PasienMenu(conn);
                                break;
                            case '2':
                                pr.AntrianMenu(conn);
                                break;
                            case '3':
                                pr.DokterMenu(conn);
                                break;
                            case '4':
                                pr.JadwalAntrianPasien(conn);
                                break;
                            case '5':
                                conn.Close();
                                Console.Clear();
                                return;
                            default:
                                Console.Clear();
                                Console.WriteLine("\nInvalid option");
                                break;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("\nCheck for the value entered.");
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tidak Dapat Mengakses Database Tersebut\n");
                Console.ResetColor();
            }
        }


        // Metode untuk membuat database
      




    // Method untuk menu pasien
    public void PasienMenu(SqlConnection con)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Pasien");
                Console.WriteLine("1. Lihat Data Pasien");
                Console.WriteLine("2. Tambah Data Pasien");
                Console.WriteLine("3. Hapus Data Pasien");
                Console.WriteLine("4. Cari Data Pasien");
                Console.WriteLine("5. Edit Data Pasien");
                Console.WriteLine("6. Kembali ke Menu Utama");
                Console.WriteLine("\nEnter your choice (1-6): ");
                char choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Data Pasien\n");
                            viewPasiens(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Tambah Data Pasien\n");
                            addPasien(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("Hapus Data Pasien\n");
                            deletePasien(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Cari Data Pasien\n");
                            searchPasien(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '5':
                        {
                            Console.Clear();
                            Console.WriteLine("Edit Data Pasien\n");
                            editData(con, "pasien");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '6':
                        return; // Kembali ke menu utama
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid option");
                        break;
                }
            }
        }

        // Method untuk menu antrian
        public void AntrianMenu(SqlConnection con)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Antrian");
                Console.WriteLine("1. Lihat Data Antrian");
                Console.WriteLine("2. Tambah Data Antrian");
                Console.WriteLine("3. Hapus Data Antrian");
                Console.WriteLine("4. Cari Data Antrian");
                Console.WriteLine("5. Edit Data Antrian");
                Console.WriteLine("6. Kembali ke Menu Utama");
                Console.WriteLine("\nEnter your choice (1-6): ");
                char choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Data Antrian\n");
                            viewAntrian(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Tambah Data Antrian\n");
                            addAntrian(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("Hapus Data Antrian\n");
                            deleteAntrian(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Cari Data Antrian\n");
                            searchAntrian(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '5':
                        {
                            Console.Clear();
                            Console.WriteLine("Edit Data Antrian\n");
                            editData(con, "antrian");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '6':
                        return; // Kembali ke menu utama
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid option");
                        break;
                }
            }
        }

        // Method untuk menu dokter
        public void DokterMenu(SqlConnection con)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Dokter");
                Console.WriteLine("1. Lihat Data Dokter");
                Console.WriteLine("2. Tambah Data Dokter");
                Console.WriteLine("3. Hapus Data Dokter");
                Console.WriteLine("4. Cari Data Dokter");
                Console.WriteLine("5. Edit Data Dokter");
                Console.WriteLine("6. Kembali ke Menu Utama");
                Console.WriteLine("\nEnter your choice (1-6): ");
                char choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Data Dokter\n");
                            viewDokters(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Tambah Data Dokter\n");
                            addDokter(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("Hapus Data Dokter\n");
                            deleteDokter(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Cari Data Dokter\n");
                            searchDokter(con);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '5':
                        {
                            Console.Clear();
                            Console.WriteLine("Edit Data Dokter\n");
                            editData(con, "dokter");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case '6':
                        return; // Kembali ke menu utama
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid option");
                        break;
                }
            }
        }

        // Method untuk melihat data pasien
        public void viewPasiens(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM pasien", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("NIK: " + reader.GetString(0));
                    Console.WriteLine("Nama_Pasien: " + reader.GetString(1));
                    Console.WriteLine("Jenis_Kelamin: " + reader.GetString(2));
                    Console.WriteLine("Tgl_Lahir: " + reader.GetDateTime(3).ToString("yyyy-MM-dd"));
                    Console.WriteLine("Tujuan_Kunjungan: " + reader.GetString(4));
                    Console.WriteLine("Jalan: " + reader.GetString(5));
                    Console.WriteLine("Kota: " + reader.GetString(6));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data pasien.");
            }
            reader.Close();
        }

        // Method untuk menambah data pasien
        public void addPasien(SqlConnection con)
        {
            string NIK, Nama_Pasien, Tujuan_Kunjungan, Jalan, Kota;
            char Jenis_Kelamin;
            DateTime Tgl_Lahir;

            Console.WriteLine("Masukkan NIK: ");
            while (true)
            {
                NIK = Console.ReadLine();
                if (NIK.Length == 16 && NIK.All(char.IsDigit)) // NIK harus terdiri dari 16 digit angka
                {
                    if (!IsDataExists("NIK", NIK, con))
                        break;
                    else
                        Console.WriteLine("NIK sudah ada dalam database. Masukkan NIK yang berbeda: ");
                }
                else
                    Console.WriteLine("NIK harus terdiri dari 16 digit angka. Masukkan lagi: ");
            }

            // Periksa nama pasien
            Console.WriteLine("Masukkan Nama Pasien: ");
            while (true)
            {
                Nama_Pasien = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Nama_Pasien) && !Nama_Pasien.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Nama Pasien tidak boleh kosong dan tidak boleh mengandung angka. Masukkan nama yang sesuai: ");
            }

            // Periksa jenis kelamin
            Console.WriteLine("Masukkan Jenis Kelamin (L/P): ");
            while (true)
            {
                char input = char.ToUpper(Console.ReadKey().KeyChar);
                if (input == 'L' || input == 'P')
                {
                    Jenis_Kelamin = input;
                    break;
                }
                else
                    Console.WriteLine("\nJenis kelamin hanya boleh 'L' (Laki-laki) atau 'P' (Perempuan). Masukkan lagi: ");
            }

            // Periksa tanggal lahir
            Console.WriteLine("\nMasukkan Tanggal Lahir (yyyy-MM-dd): ");
            while (!DateTime.TryParse(Console.ReadLine(), out Tgl_Lahir))
            {
                Console.WriteLine("Format tanggal salah. Masukkan lagi (yyyy-MM-dd): ");
            }

            Console.WriteLine("Masukkan Tujuan Kunjungan: ");
            while (true)
            {
                Tujuan_Kunjungan = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Tujuan_Kunjungan) && !Tujuan_Kunjungan.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Tujuan Kunjungan tidak boleh kosong dan tidak boleh mengandung angka. Masukkan tujuan kunjungan yang sesuai: ");
            }

            Console.WriteLine("Alamat Lengkap");
            Console.WriteLine("Masukkan Jalan: ");
            while (true)
            {
                Jalan = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Jalan))
                    break;
                else
                    Console.WriteLine("Jalan tidak boleh kosong. Masukkan jalan yang sesuai: ");
            }

            Console.WriteLine("Masukkan Kota: ");
            while (true)
            {
                Kota = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Kota) && !Kota.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Kota tidak boleh kosong dan tidak boleh mengandung angka. Masukkan kota yang sesuai: ");
            }

            Console.WriteLine("\nData yang dimasukkan:");
            Console.WriteLine($"NIK: {NIK}");
            Console.WriteLine($"Nama Pasien: {Nama_Pasien}");
            Console.WriteLine($"Jenis Kelamin: {Jenis_Kelamin}");
            Console.WriteLine($"Tanggal Lahir: {Tgl_Lahir.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Tujuan Kunjungan: {Tujuan_Kunjungan}");
            Console.WriteLine($"Jalan: {Jalan}");
            Console.WriteLine($"Kota: {Kota}");

            Console.WriteLine("\nApakah data sudah benar? (y/n)");
            char confirmation = Console.ReadKey().KeyChar;
            if (confirmation == 'y' || confirmation == 'Y')
            {
                string query = "INSERT INTO pasien (NIK, Nama_Pasien, Jenis_Kelamin, Tgl_Lahir, Tujuan_Kunjungan, Jalan, Kota) " +
                               "VALUES (@NIK, @Nama_Pasien, @Jenis_Kelamin, @Tgl_Lahir, @Tujuan_Kunjungan, @Jalan, @Kota)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NIK", NIK);
                cmd.Parameters.AddWithValue("@Nama_Pasien", Nama_Pasien);
                cmd.Parameters.AddWithValue("@Jenis_Kelamin", Jenis_Kelamin);
                cmd.Parameters.AddWithValue("@Tgl_Lahir", Tgl_Lahir);
                cmd.Parameters.AddWithValue("@Tujuan_Kunjungan", Tujuan_Kunjungan);
                cmd.Parameters.AddWithValue("@Jalan", Jalan);
                cmd.Parameters.AddWithValue("@Kota", Kota);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nData Pasien berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Pasien.");
                }
            }
            else
            {
                Console.WriteLine("\nPengisian data dibatalkan.");
            }
        }

        // Fungsi untuk memeriksa apakah data sudah ada dalam database
        private bool IsDataExists(string columnName, string value, SqlConnection con)
        {
            string query = $"SELECT COUNT(*) FROM pasien WHERE {columnName} = @value";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@value", value);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }



        // Method untuk menghapus data pasien
        public void displayPasienList(SqlConnection con)
        {
            string query = "SELECT NIK, Nama_Pasien FROM pasien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("====================================================================");
            Console.WriteLine("|            NIK            |           Nama Pasien            ");
            Console.WriteLine("====================================================================");

            while (reader.Read())
            {
                Console.WriteLine($"| {reader["NIK"],-26} | {reader["Nama_Pasien"],-34} ");
            }
            reader.Close();
        }

        public void deletePasien(SqlConnection con)
        {
            // Menampilkan daftar Pasien
            Console.WriteLine("Daftar Pasien:");
            displayPasienList(con);

            Console.WriteLine("\nMasukkan NIK Pasien yang ingin dihapus: ");
            string NIK = Console.ReadLine();

            // Menampilkan data yang akan dihapus
            string query = "SELECT NIK, Nama_Pasien FROM pasien WHERE NIK = @NIK";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NIK", NIK);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Console.WriteLine($"Data yang akan dihapus:");
                Console.WriteLine($"NIK: {reader["NIK"]} - Nama Pasien: {reader["Nama_Pasien"]}");
                Console.WriteLine("Apakah data yang akan dihapus sudah benar? (y/n)");
                char confirmation = Convert.ToChar(Console.ReadLine());

                if (confirmation == 'y' || confirmation == 'Y')
                {
                    reader.Close(); // Tutup pembacaan data sebelum eksekusi penghapusan

                    // Menghapus data
                    string deleteQuery = "DELETE FROM pasien WHERE NIK = @NIK";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@NIK", NIK);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data Pasien berhasil dihapus.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data Pasien.");
                    }
                }
                else if (confirmation == 'n' || confirmation == 'N')
                {
                    Console.WriteLine("Penghapusan data dibatalkan.");
                }
                else
                {
                    Console.WriteLine("Input tidak valid.");
                }
            }
            else
            {
                Console.WriteLine("Data Pasien tidak ditemukan.");
            }

            reader.Close();
        }


        // Method untuk mencari data pasien
        public void displayPasienList1(SqlConnection con)
        {
            string query = "SELECT NIK, Nama_Pasien FROM pasien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("====================================================================");
            Console.WriteLine("|          NIK          |          Nama Pasien           |");
            Console.WriteLine("====================================================================");

            while (reader.Read())
            {
                Console.WriteLine($"| {reader["NIK"],-22} | {reader["Nama_Pasien"],-31} |");
            }
            reader.Close();
        }

        public void searchPasien(SqlConnection con)
        {
            // Menampilkan daftar Pasien
            displayPasienList(con);

            Console.WriteLine("\nMasukkan NIK atau nama Pasien yang ingin dicari: ");
            string keyword = Console.ReadLine();

            // Validasi input tidak boleh kosong
            while (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("Input tidak boleh kosong. Masukkan NIK atau nama Pasien yang ingin dicari: ");
                keyword = Console.ReadLine();
            }

            string query = "SELECT * FROM pasien WHERE Nama_Pasien LIKE @keyword OR NIK LIKE @keyword";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:");
                while (reader.Read())
                {
                    Console.WriteLine($"NIK: {reader["NIK"]}");
                    Console.WriteLine($"Nama Pasien: {reader["Nama_Pasien"]}");
                    Console.WriteLine($"Jenis Kelamin: {reader["Jenis_Kelamin"]}");
                    Console.WriteLine($"Tanggal Lahir: {reader.GetDateTime(3).ToString("yyyy-MM-dd")}");
                    Console.WriteLine($"Tujuan Kunjungan: {reader["Tujuan_Kunjungan"]}");
                    Console.WriteLine($"Alamat: {reader["Jalan"]}, {reader["Kota"]}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Data pasien tidak ditemukan.");
            }
            reader.Close();
        }




        // Method untuk melihat data antrian
        public void viewAntrian(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Antrian", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("ID_Antrian: " + reader.GetString(0));
                    Console.WriteLine("Status: " + reader.GetString(1));
                    Console.WriteLine("No_Antrean: " + reader.GetString(2));
                    Console.WriteLine("NIK: " + reader.GetString(3));
                    Console.WriteLine("ID_Dokter: " + reader.GetString(4));
                    Console.WriteLine("Tanggal_Periksa: " + reader.GetDateTime(5).ToString("yyyy-MM-dd"));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data antrian.");
            }
            reader.Close();
        }

        public void displayAntrianList(SqlConnection con)
        {
            string query = "SELECT ID_Antrian, NIK, Nama_Pasien FROM antrian INNER JOIN pasien ON antrian.ID_Pasien = pasien.ID_Pasien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Daftar Antrian:");
            while (reader.Read())
            {
                Console.WriteLine($"ID Antrian: {reader["ID_Antrian"]} - NIK: {reader["NIK"]} - Nama Pasien: {reader["Nama_Pasien"]}");
            }
            reader.Close();
        }
        public void addAntrian(SqlConnection con)
        {
            string Status, NIK, ID_Dokter;
            DateTime Tanggal_Periksa = DateTime.Today; // Tanggal Periksa diisi otomatis dengan tanggal hari ini

            // Display list of patient NIKs
            Console.WriteLine("Daftar NIK Pasien:");
            DisplayNIKList(con);

            Console.WriteLine("\nMasukkan NIK: ");
            while (true)
            {
                NIK = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(NIK))
                    break;
                else
                    Console.WriteLine("NIK tidak boleh kosong. Masukkan NIK yang sesuai: ");
            }

            // Display list of doctor IDs
            Console.WriteLine("\nDaftar ID Dokter:");
            DisplayDoctorIDList(con);

            Console.WriteLine("\nMasukkan ID_Dokter: ");
            while (true)
            {
                ID_Dokter = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ID_Dokter))
                    break;
                else
                    Console.WriteLine("ID Dokter tidak boleh kosong. Masukkan ID Dokter yang sesuai: ");
            }

            Console.WriteLine("Masukkan Status Antrian: ");
            while (true)
            {
                Status = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Status) && !Status.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Status Antrian tidak boleh kosong dan tidak boleh mengandung angka. Masukkan status yang sesuai: ");
            }

            // Generate ID_Antrian
            string ID_Antrian = GenerateIDAntrian(con);

            // Generate No_Antrean
            string No_Antrean = GenerateNoAntrean(con);

            Console.WriteLine("\nData yang dimasukkan:");
            Console.WriteLine($"ID_Antrian: {ID_Antrian}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"No Antrean: {No_Antrean}");
            Console.WriteLine($"NIK: {NIK}");
            Console.WriteLine($"ID_Dokter: {ID_Dokter}");
            Console.WriteLine($"Tanggal Periksa: {Tanggal_Periksa.ToString("yyyy-MM-dd")}");

            Console.WriteLine("\nApakah data sudah benar? (y/n)");
            char confirmation = Console.ReadKey().KeyChar;
            if (confirmation == 'y' || confirmation == 'Y')
            {
                string query = "INSERT INTO Antrian (ID_Antrian, Status, No_Antrean, NIK, ID_Dokter, Tanggal_Periksa) " +
                               "VALUES (@ID_Antrian, @Status, @No_Antrean, @NIK, @ID_Dokter, @Tanggal_Periksa)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Antrian", ID_Antrian);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@No_Antrean", No_Antrean);
                cmd.Parameters.AddWithValue("@NIK", NIK);
                cmd.Parameters.AddWithValue("@ID_Dokter", ID_Dokter);
                cmd.Parameters.AddWithValue("@Tanggal_Periksa", Tanggal_Periksa);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nData Antrian berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Antrian.");
                }
            }
            else
            {
                Console.WriteLine("\nPengisian data dibatalkan.");
            }
        }

        // Function to display list of patient NIKs
        private void DisplayNIKList(SqlConnection con)
        {
            string query = "SELECT NIK, Nama_Pasien FROM pasien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["NIK"]} - {reader["Nama_Pasien"]}");
            }
            reader.Close();


        }

        // Function to display list of doctor IDs
        private void DisplayDoctorIDList(SqlConnection con)
        {
            string query = "SELECT ID_Dokter, Nama_Dokter, Spesialis FROM dokter";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["ID_Dokter"]} - {reader["Nama_Dokter"]} ({reader["Spesialis"]})");
            }
            reader.Close();
        }


        // Function to generate ID Antrian
        private string GenerateIDAntrian(SqlConnection con)
    {
        string ID_Antrian = "A00001"; // You can choose any initial ID
        string query = "SELECT MAX(ID_Antrian) FROM Antrian";
        SqlCommand cmd = new SqlCommand(query, con);
        object result = cmd.ExecuteScalar();
        if (result != null && result != DBNull.Value)
        {
            string maxID = result.ToString();
            int maxInt;
            if (int.TryParse(maxID.Substring(1), out maxInt)) // Parse the numeric part
            {
                maxInt++; // Increment
                ID_Antrian = "A" + maxInt.ToString("00000"); // Format back to 6 characters
            }
        }
        return ID_Antrian;
    }

        // Function to generate No Antrean
        private string GenerateNoAntrean(SqlConnection con)
        {
            string No_Antrean = "";
            string query = "SELECT MAX(CAST(No_Antrean AS INT)) FROM Antrian";
            SqlCommand cmd = new SqlCommand(query, con);
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int count = Convert.ToInt32(result) + 1;
                No_Antrean = count.ToString("0000000000"); // Format No Antrean as 10 digits
            }
            else
            {
                No_Antrean = "0000000001"; // Jika tabel Antrian kosong, nomor antrian pertama
            }
            return No_Antrean;
        }





        public void deleteAntrian(SqlConnection con)
        {
            string queryData = "SELECT ID_Antrian, No_Antrean FROM Antrian";
            SqlCommand cmdData = new SqlCommand(queryData, con);

            using (SqlDataReader reader = cmdData.ExecuteReader())
            {
                Console.WriteLine("Data Antrian yang tersedia:");
                Console.WriteLine("ID_Antrian\tNo_Antrean");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ID_Antrian"]}\t\t{reader["No_Antrean"]}");
                }
            }

            Console.WriteLine("\nMasukkan ID_Antrian yang ingin dihapus: ");
            string ID_Antrian = Console.ReadLine();

            // Validasi input tidak boleh kosong
            while (string.IsNullOrWhiteSpace(ID_Antrian))
            {
                Console.WriteLine("Input tidak boleh kosong. Masukkan ID_Antrian yang ingin dihapus: ");
                ID_Antrian = Console.ReadLine();
            }

            // Validasi penghapusan data
            Console.WriteLine("Apakah data yang akan dihapus sudah benar? (y/n)");
            char confirmation = Convert.ToChar(Console.ReadLine());

            if (confirmation == 'y' || confirmation == 'Y')
            {
                string query = "DELETE FROM Antrian WHERE ID_Antrian = @ID_Antrian";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Antrian", ID_Antrian);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data Antrian berhasil dihapus.");
                }
                else
                {
                    Console.WriteLine("Gagal menghapus data Antrian.");
                }
            }
            else if (confirmation == 'n' || confirmation == 'N')
            {
                Console.WriteLine("Penghapusan data dibatalkan.");
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }
        }




        public void searchAntrian(SqlConnection con)
        {
            string queryData = "SELECT ID_Antrian, No_Antrean FROM Antrian";
            SqlCommand cmdData = new SqlCommand(queryData, con);

            using (SqlDataReader readerData = cmdData.ExecuteReader())
            {
                Console.WriteLine("Data Antrian yang tersedia:");
                Console.WriteLine("ID_Antrian\tNo_Antrean");
                while (readerData.Read())
                {
                    Console.WriteLine($"{readerData["ID_Antrian"]}\t\t{readerData["No_Antrean"]}");
                }
            }

            Console.WriteLine("\nMasukkan ID Antrian yang ingin dicari: ");
            string keyword = Console.ReadLine();

            string query = "SELECT * FROM Antrian WHERE ID_Antrian = @keyword";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@keyword", keyword);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("ID_Antrian: " + reader.GetString(0));
                    Console.WriteLine("Status: " + reader.GetString(1));
                    Console.WriteLine("No_Antrean: " + reader.GetString(2));
                    Console.WriteLine("NIK: " + reader.GetString(3));
                    Console.WriteLine("ID_Dokter: " + reader.GetString(4));
                    Console.WriteLine("Tanggal_Periksa: " + reader.GetDateTime(5).ToString("yyyy-MM-dd"));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Data antrian tidak ditemukan.");
            }
            reader.Close();
        }




        // Method untuk melihat data dokter
        public void viewDokters(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dokter", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("ID_Dokter: " + reader.GetString(0));
                    Console.WriteLine("Nama_Dokter: " + reader.GetString(1));
                    Console.WriteLine("Spesialis: " + reader.GetString(2));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data dokter.");
            }
            reader.Close();
        }

        // Method untuk menambah data dokter
        public void addDokter(SqlConnection con)
        {
            Console.WriteLine("Masukkan ID_Dokter (8 karakter): ");
            string ID_Dokter;
            while (true)
            {
                ID_Dokter = Console.ReadLine();
                if (ID_Dokter.Length == 8) // ID_Dokter harus terdiri dari 8 karakter
                    break;
                else
                    Console.WriteLine("ID_Dokter harus terdiri dari 8 karakter. Masukkan lagi: ");
            }

            Console.WriteLine("Masukkan Nama Dokter: ");
            string Nama_Dokter;
            while (true)
            {
                Nama_Dokter = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Nama_Dokter) && !Nama_Dokter.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Nama Dokter tidak boleh kosong dan tidak boleh mengandung angka. Masukkan nama dokter yang sesuai: ");
            }

            Console.WriteLine("Masukkan Spesialis: ");
            string Spesialis;
            while (true)
            {
                Spesialis = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Spesialis) && !Spesialis.Any(char.IsDigit))
                    break;
                else
                    Console.WriteLine("Spesialis tidak boleh kosong dan tidak boleh mengandung angka. Masukkan spesialis yang sesuai: ");
            }

            Console.WriteLine("\nData yang dimasukkan:");
            Console.WriteLine($"ID_Dokter: {ID_Dokter}");
            Console.WriteLine($"Nama Dokter: {Nama_Dokter}");
            Console.WriteLine($"Spesialis: {Spesialis}");

            Console.WriteLine("\nApakah data sudah benar? (y/n)");
            char confirmation = Console.ReadKey().KeyChar;
            if (confirmation == 'y' || confirmation == 'Y')
            {
                string query = "INSERT INTO dokter (ID_Dokter, Nama_Dokter, Spesialis) " +
                               "VALUES (@ID_Dokter, @Nama_Dokter, @Spesialis)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Dokter", ID_Dokter);
                cmd.Parameters.AddWithValue("@Nama_Dokter", Nama_Dokter);
                cmd.Parameters.AddWithValue("@Spesialis", Spesialis);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nData Dokter berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Dokter.");
                }
            }
            else
            {
                Console.WriteLine("\nPengisian data dibatalkan.");
            }
        }

        public void DisplayDokterList(SqlConnection con)
        {
            string query = "SELECT ID_Dokter, Nama_Dokter, Spesialis FROM dokter";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("ID Dokter\tNama Dokter\t\tSpesialis");

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ID_Dokter"]}\t\t{reader["Nama_Dokter"]}\t\t{reader["Spesialis"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }




        // Method untuk menghapus data dokter
        public void deleteDokter(SqlConnection con)
        {
            // Display list of doctors
            Console.WriteLine("Daftar Dokter:");
            DisplayDokterList(con);

            string ID_Dokter;

            Console.WriteLine("\nMasukkan ID_Dokter yang ingin dihapus: ");
            while (true)
            {
                ID_Dokter = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ID_Dokter))
                    break;
                else
                    Console.WriteLine("ID Dokter tidak boleh kosong. Masukkan ID Dokter yang ingin dihapus: ");
            }

            // Validasi penghapusan data
            Console.WriteLine("Apakah data yang akan dihapus sudah benar? (y/n)");
            char confirmation = Convert.ToChar(Console.ReadLine());

            if (confirmation == 'y' || confirmation == 'Y')
            {
                string query = "DELETE FROM dokter WHERE ID_Dokter = @ID_Dokter";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Dokter", ID_Dokter);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data Dokter berhasil dihapus.");
                }
                else
                {
                    Console.WriteLine("Gagal menghapus data Dokter.");
                }
            }
            else if (confirmation == 'n' || confirmation == 'N')
            {
                Console.WriteLine("Penghapusan data dibatalkan.");
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }
        }


        public void DisplayDokterList1(SqlConnection con)
        {
            string query = "SELECT ID_Dokter, Nama_Dokter FROM dokter";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("ID Dokter\tNama Dokter");

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ID_Dokter"]}\t\t{reader["Nama_Dokter"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method untuk mencari data dokter
        public void searchDokter(SqlConnection con)
        {
            Console.WriteLine("Daftar Dokter:");
            DisplayDokterList1(con);

            string keyword;
            Console.WriteLine("\nMasukkan ID Dokter yang ingin dicari: ");
            while (true)
            {
                keyword = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(keyword))
                    break;
                else
                    Console.WriteLine("ID Dokter tidak boleh kosong. Masukkan ID Dokter yang ingin dicari: ");
            }

            string query = "SELECT * FROM dokter WHERE Nama_Dokter = @keyword OR ID_Dokter LIKE @keyword";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("ID_Dokter: " + reader.GetString(0));
                        Console.WriteLine("Nama_Dokter: " + reader.GetString(1));
                        Console.WriteLine("Spesialis: " + reader.GetString(2));
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Data dokter tidak ditemukan.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // Method untuk mengubah data pasien, dokter, atau antrian






        public void displayPasienList2(SqlConnection con)
        {
            string query = "SELECT NIK, Nama_Pasien FROM pasien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Daftar Pasien:");
            while (reader.Read())
            {
                Console.WriteLine($"NIK: {reader["NIK"]} - Nama Pasien: {reader["Nama_Pasien"]}");
            }
            reader.Close();
        }

        public void displayAntrianList1(SqlConnection con)
        {
            string query = "SELECT antrian.ID_Antrian, pasien.NIK, pasien.Nama_Pasien, dokter.Nama_Dokter, antrian.Status " +
                           "FROM antrian " +
                           "INNER JOIN pasien ON antrian.NIK = pasien.NIK " +
                           "INNER JOIN dokter ON antrian.ID_Dokter = dokter.ID_Dokter";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Daftar Antrian:");
            while (reader.Read())
            {
                Console.WriteLine($"ID Antrian: {reader["ID_Antrian"]} - NIK: {reader["NIK"]} - Nama Pasien: {reader["Nama_Pasien"]} - Nama Dokter: {reader["Nama_Dokter"]} - Status: {reader["Status"]}");
            }
            reader.Close();
        }

        public void displayDoctorList1(SqlConnection con)
        {
            string query = "SELECT ID_Dokter, Nama_Dokter, Spesialis FROM dokter";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Daftar Dokter:");
            while (reader.Read())
            {
                Console.WriteLine($"ID Dokter: {reader["ID_Dokter"]} - Nama Dokter: {reader["Nama_Dokter"]} - Spesialis: {reader["Spesialis"]}");
            }
            reader.Close();
        }

        public void editData(SqlConnection con, string tableName)
        {
            switch (tableName)
            {
                case "pasien":
                    // Menampilkan daftar Pasien
                    displayPasienList2(con);
                    break;
                case "antrian":
                    // Menampilkan daftar Antrian
                    displayAntrianList1(con);
                    break;
                case "dokter":
                    // Menampilkan daftar Dokter
                    displayDoctorList1(con);
                    break;
                default:
                    Console.WriteLine("Invalid table name.");
                    return;
            }

            string id;
            do
            {
                Console.WriteLine("Masukkan ID yang ingin diedit: ");
                id = Console.ReadLine();

                if (string.IsNullOrEmpty(id))
                {
                    Console.WriteLine("ID tidak boleh kosong. Silakan masukkan ID.");
                }

            } while (string.IsNullOrEmpty(id));

            // Konfirmasi dari pengguna
            Console.WriteLine("Apakah Anda yakin ingin mengedit data dengan ID ini? (y/n)");
            char confirm = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Membuat baris kosong setelah input user

            // Memeriksa konfirmasi pengguna
            if (confirm != 'y' && confirm != 'Y')
            {
                Console.WriteLine("Pengeditan data dibatalkan.");
                return; // Keluar dari method jika pengguna membatalkan
            }

            switch (tableName)
            {
                case "pasien":
                    // Pilihan kolom yang ingin diubah
                    Console.WriteLine("Pilih kolom yang ingin diubah: ");
                    Console.WriteLine("1. Nama Pasien");
                    Console.WriteLine("2. Jenis Kelamin");
                    Console.WriteLine("3. Tanggal Lahir");
                    Console.WriteLine("4. Tujuan Kunjungan");
                    Console.WriteLine("5. Jalan");
                    Console.WriteLine("6. Kota");
                    Console.Write("Pilihan Anda (1-6): ");
                    int option = int.Parse(Console.ReadLine());

                    string query = "";
                    SqlCommand cmd = new SqlCommand();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Masukkan Nama Pasien baru: ");
                            string nama = Console.ReadLine();
                            if (string.IsNullOrEmpty(nama))
                            {
                                Console.WriteLine("Nama tidak boleh kosong.");
                                return;
                            }
                            query = "UPDATE pasien SET Nama_Pasien = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", nama);
                            break;
                        case 2:
                            Console.WriteLine("Masukkan Jenis Kelamin baru (L/P): ");
                            string gender = Console.ReadLine();
                            if (string.IsNullOrEmpty(gender))
                            {
                                Console.WriteLine("Jenis kelamin tidak boleh kosong.");
                                return;
                            }
                            query = "UPDATE pasien SET Jenis_Kelamin = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", gender);
                            break;
                        case 3:
                            Console.WriteLine("Masukkan Tanggal Lahir baru (yyyy-MM-dd): ");
                            string birthDateString = Console.ReadLine();
                            if (!DateTime.TryParse(birthDateString, out DateTime birthDate))
                            {
                                Console.WriteLine("Format tanggal tidak valid.");
                                return;
                            }
                            query = "UPDATE pasien SET Tgl_Lahir = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", birthDate);
                            break;
                        case 4:
                            Console.WriteLine("Masukkan Tujuan Kunjungan baru: ");
                            string purpose = Console.ReadLine();
                            if (string.IsNullOrEmpty(purpose))
                            {
                                Console.WriteLine("Tujuan kunjungan tidak boleh kosong.");
                                return;
                            }
                            query = "UPDATE pasien SET Tujuan_Kunjungan = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", purpose);
                            break;
                        case 5:
                            Console.WriteLine("Masukkan Jalan baru: ");
                            string street = Console.ReadLine();
                            if (string.IsNullOrEmpty(street))
                            {
                                Console.WriteLine("Jalan tidak boleh kosong.");
                                return;
                            }
                            query = "UPDATE pasien SET Jalan = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", street);
                            break;
                        case 6:
                            Console.WriteLine("Masukkan Kota baru: ");
                            string city = Console.ReadLine();
                            if (string.IsNullOrEmpty(city))
                            {
                                Console.WriteLine("Kota tidak boleh kosong.");
                                return;
                            }
                            query = "UPDATE pasien SET Kota = @value WHERE NIK = @id";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@value", city);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            return;
                    }
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data Pasien berhasil diupdate.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal mengupdate data Pasien.");
                    }
                    break;
                case "antrian":
                    // Pilihan kolom yang ingin diubah
                    Console.WriteLine("Pilih kolom yang ingin diubah: ");
                    Console.WriteLine("1. Status");
                    Console.Write("Pilihan Anda : ");
                    int optionAntrian = int.Parse(Console.ReadLine());

                    string queryAntrian = "";
                    SqlCommand cmdAntrian = new SqlCommand();
                    switch (optionAntrian)
                    {
                        case 1:
                            Console.WriteLine("Masukkan Status Antrian baru: ");
                            string status = Console.ReadLine();
                            if (string.IsNullOrEmpty(status))
                            {
                                Console.WriteLine("Status tidak boleh kosong.");
                                return;
                            }
                            queryAntrian = "UPDATE antrian SET Status = @value WHERE ID_Antrian = @id";
                            cmdAntrian = new SqlCommand(queryAntrian, con);
                            cmdAntrian.Parameters.AddWithValue("@value", status);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            return;
                    }
                    cmdAntrian.Parameters.AddWithValue("@id", id);
                    int rowsAffectedAntrian = cmdAntrian.ExecuteNonQuery();
                    if (rowsAffectedAntrian > 0)
                    {
                        Console.WriteLine("Data Antrian berhasil diupdate.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal mengupdate data Antrian.");
                    }
                    break;
                case "dokter":
                    // Pilihan kolom yang ingin diubah
                    Console.WriteLine("Pilih kolom yang ingin diubah: ");
                    Console.WriteLine("1. Nama Dokter");
                    Console.WriteLine("2. Spesialis");
                    Console.Write("Pilihan Anda (1-2): ");
                    int optionDokter = int.Parse(Console.ReadLine());

                    string queryDokter = "";
                    SqlCommand cmdDokter = new SqlCommand();
                    switch (optionDokter)
                    {
                        case 1:
                            Console.WriteLine("Masukkan Nama Dokter baru: ");
                            string namaDokter = Console.ReadLine();
                            if (string.IsNullOrEmpty(namaDokter))
                            {
                                Console.WriteLine("Nama dokter tidak boleh kosong.");
                                return;
                            }
                            queryDokter = "UPDATE dokter SET Nama_Dokter = @value WHERE ID_Dokter = @id";
                            cmdDokter = new SqlCommand(queryDokter, con);
                            cmdDokter.Parameters.AddWithValue("@value", namaDokter);
                            break;
                        case 2:
                            Console.WriteLine("Masukkan Spesialis baru: ");
                            string spesialis = Console.ReadLine();
                            if (string.IsNullOrEmpty(spesialis))
                            {
                                Console.WriteLine("Spesialis tidak boleh kosong.");
                                return;
                            }
                            queryDokter = "UPDATE dokter SET Spesialis = @value WHERE ID_Dokter = @id";
                            cmdDokter = new SqlCommand(queryDokter, con);
                            cmdDokter.Parameters.AddWithValue("@value", spesialis);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            return;
                    }
                    cmdDokter.Parameters.AddWithValue("@id", id);
                    int rowsAffectedDokter = cmdDokter.ExecuteNonQuery();
                    if (rowsAffectedDokter > 0)
                    {
                        Console.WriteLine("Data Dokter berhasil diupdate.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal mengupdate data Dokter.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid table name.");
                    break;
            }
        }


        // Metode menu untuk jadwal antrian baru
        public void JadwalAntrianPasien(SqlConnection con)
        {
            Console.Clear();
            Console.WriteLine("Jadwal Antrian Baru");

            // Query SQL untuk mengambil data dari tabel pasien
            string queryPasien = "SELECT a.ID_Antrian, p.Nama_Pasien, p.NIK, a.No_Antrean, a.Status, d.Nama_Dokter " +
                                 "FROM pasien p " +
                                 "INNER JOIN Antrian a ON p.NIK = a.NIK " +
                                 "INNER JOIN dokter d ON a.ID_Dokter = d.ID_Dokter";
            SqlCommand cmdPasien = new SqlCommand(queryPasien, con);
            SqlDataReader readerPasien = cmdPasien.ExecuteReader();

            // Tampilkan header tabel
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("|  ID Antrian  |     Nama Pasien     |     NIK     |   No Antrian   |     Status     |     Nama Dokter     |");
            Console.WriteLine("==============================================================================================================");

            // Tampilkan data dalam format tabel
            while (readerPasien.Read())
            {
                string idAntrian = (string)readerPasien["ID_Antrian"];
                string namaPasien = (string)readerPasien["Nama_Pasien"];
                string nik = (string)readerPasien["NIK"];
                string noAntrian = (string)readerPasien["No_Antrean"];
                string status = (string)readerPasien["Status"];
                string namaDokter = (string)readerPasien["Nama_Dokter"];

                // Menambahkan spasi tambahan untuk mengatur lebar kolom
                Console.WriteLine($"| {idAntrian,-12} | {namaPasien,-20} | {nik,-10} | {noAntrian,-14} | {status,-14} | {namaDokter,-20} ");
            }
            Console.WriteLine("==============================================================================================================");

            readerPasien.Close();
        }
    }
}
