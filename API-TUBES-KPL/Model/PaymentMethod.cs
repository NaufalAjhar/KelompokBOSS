namespace API_TUBES_KPL.Model
{
    public class PaymentMethod
    {
        public string ID_Payment { get; set; }
        public string Nama_Pembeli { get; set; }
        public string Metode_Pembayaran { get; set; }
        public int Jumlah { get; set; }
        public int Biaya_Admin { get; set; }

        public PaymentMethod(string ID_Payment, string Nama_Pembeli, string Metode_Pembayaran, int Jumlah, int Biaya_Admin)
        {
            this.ID_Payment = ID_Payment;
            this.Nama_Pembeli = Nama_Pembeli;
            this.Metode_Pembayaran = Metode_Pembayaran;
            this.Jumlah = Jumlah;
            this.Biaya_Admin = Biaya_Admin;
        }
    }
}
