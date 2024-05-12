using System.Runtime.InteropServices;
using TABLE_DRIVEN_TUBES_KPL;
internal class CariHistoryPayment
{
    private List<PaymentMethodModel> DataPayment = new List<PaymentMethodModel>
    {
        new PaymentMethodModel("001", "Ammar", "Virtual Account", 100000, 2500),
        new PaymentMethodModel("002", "Rapip", "Virtual Account", 50000, 2500),
        new PaymentMethodModel("003", "Sadra", "Virtual Account", 75000, 2500)
    };

    private PaymentMethodModel[] DataPaymentArray;
    public void toArray()
    {
        DataPaymentArray = DataPayment.ToArray();
    }

    public int returnIndex(string Nama_Pembeli)
    {
        int index = -1;

        for (int i = 0; i < DataPaymentArray.Length; i++)
        {
            if (Nama_Pembeli == DataPaymentArray[i].Nama_Pembeli)
            {
                return index = i;
                break;
            }
        }
        return index;
    }

    public void cariByNama(string Nama_Pembeli)
    {

        for (int i = 0; i < DataPaymentArray.Length; i++)
        {
            if (Nama_Pembeli == DataPaymentArray[i].Nama_Pembeli)
            {
                Console.WriteLine("ID Payment: " + DataPaymentArray[i].ID_Payment);
                Console.WriteLine("Nama Pembeli: " + DataPaymentArray[i].Nama_Pembeli);
                Console.WriteLine("Metode Pembayaran: " + DataPaymentArray[i].Metode_Pembayaran);
                Console.WriteLine("Jumlah: " + DataPaymentArray[i].Jumlah);
                Console.WriteLine("Biaya Admin: " + DataPaymentArray[i].Biaya_Admin);
            } else
            {
                Console.WriteLine("Data Tidak Ada");
                break;
            }
        }
    }
}