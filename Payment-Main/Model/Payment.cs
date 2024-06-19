namespace Payment_API.Model
{
    public class Payment
    {
        public int ID_Payment { get; set; }

        public int ID_User { get; set; }
        public string Nama_Pembeli { get; set; }
        public string Metode_Pembayaran { get; set; }
        public int Jumlah { get; set; }
        public int Biaya_Admin { get; set; }

        public Payment(int ID_Payment, int ID_User, string Nama_Pembeli, string Metode_Pembayaran, int Jumlah, int Biaya_Admin)
        {
            this.ID_Payment = ID_Payment;
            this.ID_User = ID_User;
            this.Nama_Pembeli = Nama_Pembeli;
            this.Metode_Pembayaran = Metode_Pembayaran;
            this.Jumlah = Jumlah;
            this.Biaya_Admin = Biaya_Admin;
        }
    }
}
