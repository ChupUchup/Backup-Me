#region
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace test_sct
//{
//    class Class1
//    {
//    }
//}
#endregion

using System;

//using FotoCopyKTP; /** ---------------------------------------------------------------------------------- */
//using FotoCopyIjazah; /** ------------------------------------------------------------------------------- */
//using FotoCopyTranskrip; /** ---------------------------------------------------------------------------- */
//using FotoCopySertifikat; /** --------------------------------------------------------------------------- */
//using PassFotoWarna; /** ----------------------------------------------------------------------------- */

namespace SuratLamaran
{
    class LamaranKerja
    {
        public static void main(String[] Args)
        {
            string Kepada, Alamat, Nama, TempatLahir, Pendidikan, Agama, Status, Pembuka, Isi, Penutup;
            DateTime TanggalLahir; bool dbutuhkan, hasil;

            /** ----------------------------------------------------------------------- Medan, 2 Mei 2017 */
            
            Kepada = "";
            Alamat = "";

            Pembuka = "Dengan hormat, Sesuai dengan informasi yang saya dapatkan melalui media tentang iklan lowongan kerja yang Bapak/Ibu sampaikan, maka dengan ini saya mengajukan diri untuk bergabung dengan perusahaan ataupun usaha yang sedang Bapak/Ibu pimpin atau jalankan pada posisi yang dibutuhkan. Untuk itu berikut merupakan data diri saya:";

            Nama        = "Yusuf Saleh Lubis";
            TempatLahir = "Medan"; TanggalLahir = new DateTime(1990, 09, 05);/** yyyy-mm-dd */
            Pendidikan  = "S1 Tehnik Informatika";
            Agama       = "Islam";
            Status      = "Belum Menikah";

            Isi = "Saya memiliki insterpersonal skil yang baik, penampilan yang cukup menarik" +
                "dengan tinggi proporsional, dan berkemauan mempelajari hal baru. Saya juga" +
                "memahami dasar ilmu komputer dan mampu mengoperasikan serta familiar" +
                "dengan perbaikan ataupun instalasi komputer. Saya tidak malu untuk mempelajari" +
                "hal yang diluar bidang saya karena menyadari bahwa manusia harus fleksibel." +
                "Melihat peluang yang ditampilkan pada iklan lowongan kerja tersebut saya segera" +
                "mengajukan lamaran ini untuk mencoba keberuntungan saya. ";

            Penutup = "Saya berharap agar Bapak/Ibu dapat memberikan kesempatan interview" +
                "ataupun latihan sehingga dapat menilai apakah saya layak atau tidak untuk" +
                "dipekerjakan. Demikian suran lamaran kerja ini saya sampaikan," +
                "terima kasih atas perhatiannya.";

            /** ------------------------------------------------------------------------- Hormat Saya --- */
            /** -------------------------------------------------------------------------             --- */
            /** -------------------------------------------------------------------------             --- */
            /** -------------------------------------------------------------------------             --- */
            /** -------------------------------------------------------------------------             --- */
            /** ----------------------------------------------------------------------- Yusuf Saleh Lubis */
            Console.Write("Keputusan, 1 = diterima, 0 = tidak : ");
            dibutuhkan = (Convert.ToBoolean(Console.ReadLine()) == 1) ? 1 : 0;
            hasil = dibutuhkan == 1 ? 1 : 0;
            return hasil;
            Console.Write(Pembuka + "\n" + Isi + "\n" + Penutup + "\n");
            return dibutuhkan;
        }
    }
}