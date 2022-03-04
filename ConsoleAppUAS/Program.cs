using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUAS
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>merupakan suatu program kuesioner untuk siswa</remarks>
    class Kuesioner
    {
        //deklarasi variabel 
        public string NamaSiswa, Kelas, Dampak, Manfaat;
        public double NIS;
        public int pilih;

        /// <summary>
        /// method Identitas untuk menginput identitas mahasiswa sebelum mengisi kuesioner
        /// </summary>
        public void Identitas()
        {
            Console.Write("Nama Siswa = ");
            NamaSiswa = Convert.ToString(Console.ReadLine());
            Console.Write("NIS = ");
            NIS = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kelas = ");
            Kelas = Convert.ToString(Console.ReadLine());
        }

        /// <summary>
        /// method yg akan muncul jika siswa memilih opsi "Ya" pada pertanyaan pertama
        /// </summary>
        /// <remarks>pertanyaan di method ini hanya untuk siswa yang menyukai pelajaran eksakta</remarks>
        public void Menyukai()
        {
            Console.WriteLine("2. Apa mata pelajaran eksakta yang Anda sukai?");
            Console.WriteLine("A. Matematika" + "\nB. Fisika" + "\nC. Biologi" + "\nD. Kimia");
            Console.Write("Pilihan (A/B/C/D) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("3. Mengapa Anda menyukai pelajaran tersebut?");
            Console.WriteLine("A. Mudah dipahami" + "\nB. Suka atau gampang menghafal" + "\nC. Menyukai hitungan dibanding teori" + "\nD. Agar terlihat pintar");
            Console.Write("Pilihan (A/B/C/D) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("4. Apa dampak yang Anda rasakan karena menyukai pelajaran tersebut?");
            Dampak = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n5. Menurut Anda, apa manfaat pelajaran eksakta?");
            Console.WriteLine("A. Menambah rasa percaya diri" + "\nB. Membantu melatih otak dalam ilmu pasti " + "\nC. Hanya untuk membantu ujian jika ingin memasuki sekolah yang lebih tinggi");
            Console.Write("Pilihan (A/B/C) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
        }

        /// <summary>
        /// method yg akan muncul jika siswa memilih opsi "Tidak" pada pertanyaan pertama
        /// </summary>
        /// <remarks>pertanyaan di method ini hanya untuk siswa yang tidak menyukai pelajaran eksakta</remarks>
        public void TidakMenyukai()
        {
            Console.WriteLine("2. Mengapa Anda tidak menyukai pelajaran eksakta?");
            Console.WriteLine("A. Tidak menyukai hitungan" + "\nB. Susah menghafal" + "\nC. Tidak menyukai pengajar / Pengajar galak" + "\nD. Tidak menyukai ilmu pasti" + "\nE. Alasan lain");
            Console.Write("Pilihan (A/B/C/D/E) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("3. Apa dampak yang Anda rasakan karena tidak menyukai pelajaran eksakta?");
            Dampak = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n4. Menurut Anda, adakah manfaat mempelajari pelajaran eksakta?");
            Manfaat = Convert.ToString(Console.ReadLine());
        }

        /// <summary>
        /// method yg akan muncul jika siswa memilih opsi "Beberapa" pada pertanyaan pertama
        /// </summary>
        /// <remarks>pertanyaan di method ini hanya untuk siswa yang menyukai beberapa pelajaran eksakta saja</remarks>
        public void Beberapa()
        {
            Console.WriteLine("2. Mengapa Anda hanya menyukai beberapa pelajaran eksakta saja?");
            Console.WriteLine("A. Tidak menyukai hitungan" + "\nB. Tidak menyukai hafalan" + "\nC. Yang lainnya tidak berhubungan dengan cita-cita");
            Console.Write("Pilihan (A/B/C) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("3. Apa dampak yang Anda rasakan karena menyukai pelajaran eksakta tersebut?");
            Dampak = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n4. Menurut Anda, apa manfaat mempelajari pelajaran eksakta tersebut?");
            Console.WriteLine("A. Menambah rasa percaya diri" + "\nB. Membantu melatih otak dalam ilmu pasti " + "\nC. Hanya untuk membantu ujian jika ingin memasuki sekolah yang lebih tinggi");
            Console.Write("Pilihan (A/B/C) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
        }

        /// <summary>
        /// Method soal untuk pertanyaan pertama
        /// </summary>
        public void Soal()
        {
            Console.WriteLine("1. Apakah anda menyukai pelajaran eksakta?");
            Console.WriteLine("A. Ya" + "\nB. Tidak" + "\nC. Beberapa");
            Console.Write("Pilihan (A/B/C) : ");
            pilih = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");

            //switch untuk memilih jawaban yang berupa A/B/C/D
            switch (pilih)
            {
                case 'A'|'a':
                    Menyukai(); //jika menjawab A, maka method Menyukai akan muncul selanjutnya
                    break;
                case 'B'|'b':
                    TidakMenyukai(); //jika menjawab B, maka method TidakMenyukai akan muncul selanjutnya
                    break;
                case 'C'|'c':
                    Beberapa(); //jika menjawab C, maka method Beberapa akan muncul selanjutnya
                    break;

                default: //jika menjawab selain opsi diatas maka akan muncul peringatan dan aplikasi berakhir
                    Console.WriteLine("Pilihan salah!");
                    Console.ReadKey();
                    break;
            }
        }

        /// <summary>
        /// Tampilan awal pengisian kuesioner setelah mengisi identitas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Kuesioner k = new Kuesioner();
            k.Identitas(); //siswa mengisi identitas terlebih dahulu
            Console.WriteLine("\n\n----------KUESIONER----------" +
                    "\n");
            Console.WriteLine("Dalam pengerjaan karya tulis ilmiah yang berjudul 'Tingkat Ketertarikan Siswa terhadap Mata Pelajaran Eksakta beserta Dampaknya', penulis membutuhkan partisipasi siswa menjawab kuesioner di bawah ini" +
                    "\n\n");
            Console.WriteLine("Petunjuk Pengerjaan Kuesioner");
            Console.WriteLine("Jawablah dengan memilih satu jawaban yang paling Anda setujui");
            Console.WriteLine("Apabila ada pertanyaan tanpa pilihan jawaban, jawablah dengan uraian singkat dan jelas\n");
            k.Soal(); //soal akan muncul
            Console.WriteLine("\nTerimakasih atas partisipasi Anda mengisi kuesioner ini!");
            Console.ReadKey();
        }
    }
}
