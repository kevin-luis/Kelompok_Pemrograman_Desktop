# 📚 ReadNest - Aplikasi Manajemen Buku Pribadi

## 🤝 Kelompok 3

Anggota:

* 👤 [**Kevin Luis Banamtuan (71210764)**](https://github.com/kevin-luis)
* 👤 [**Caesar Tresna Andika (71220834)**](https://github.com/caesartresnaandika)
* 👤 [**Andrea Marie Baikole (71220954)**](https://github.com/AndreaB54)

---

## 📖 Deskripsi

**ReadNest** adalah aplikasi desktop berbasis **VB.NET** yang dirancang untuk membantu pengguna mengelola koleksi buku pribadi mereka. Aplikasi ini memungkinkan pengguna menyimpan daftar buku, melacak status bacaan, mencatat waktu membaca, dan membuat koleksi favorit/wishlist.

---

## 🎯 Fitur Program

* ✅ **Manajemen Buku** (Tambahkan, edit, atau hapus data buku dengan mudah)
* ✅ **Pencarian Buku** (Cari buku berdasarkan judul, penulis, atau kategori)
* ✅ **Status Bacaan & Report Statistik** (Pantau progres membaca dan lihat laporan statistik per minggu)
* ✅ **Fitur Koleksi** (Simpan buku sebagai favorit/wishlist)
* ✅ **Timer Bacaan** (Catat durasi membaca dengan timer otomatis)
* ✅ **Manajemen Peminjaman** (Tambah data peminjam secara manual)
* ✅ **Fitur Login, Logout, Create Account**
* ✅ **Fitur Read PDF**
* ✅ **Fitur Notes**
* ✅ **Fitur Admin**

---

## 🛠️ Teknologi yang Digunakan

* **Bahasa Pemrograman**: VB.NET
* **Framework**: Windows Forms (WinForms)
* **Database**: MySQL

---

## 📦 Cara Install dan Download Aplikasi

1. Klik link berikut untuk mendownload installer aplikasi:
   🔗 [Download Setup ReadNest](https://drive.google.com/drive/folders/1Mp1qWXiNpcnIqCjD-TAuXfejW3Wv23z-?usp=sharing)

2. Ekstrak file ZIP (jika dalam bentuk ZIP) dan jalankan file `Setup.exe`.

---

## 📝 Petunjuk Instalasi

1. Jalankan `setup.exe`.
2. Tekan **Next**.
3. Pilih lokasi folder instalasi (disarankan **selain drive C**).
4. Pilih **Just Me** atau **Everyone** sesuai kebutuhan.
5. Tekan **Next** hingga instalasi selesai, lalu pilih **Close**.

---

## ❗ Troubleshooting Masalah Instalasi

1. Jalankan `ReadNest.exe` dari shortcut di Desktop.
2. Jika muncul permintaan install runtime seperti gambar di bawah ini, klik "Install" atau akses manual:
   👉 [Windows Desktop Runtime 8.0.16 (x64)](https://builds.dotnet.microsoft.com/dotnet/WindowsDesktop/8.0.16/windowsdesktop-runtime-8.0.16-win-x64.exe)

   ![Runtime Error](https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop/raw/main/assets/.net%20runtime.jpg)

3. Setelah runtime terpasang, jalankan kembali programnya.
4. Untuk keperluan testing cepat, gunakan akun berikut:

   * **Username**: `andrea`
   * **Password**: `andrea`

---

## 🛠️ Troubleshooting Database

Jika aplikasi tersimpan di **drive C** dan terjadi error saat akses database:

   ![Database Error](https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop/raw/main/assets/database%20failed.jpg)

1. Buka folder:
   `C:\Program Files (x86)\<NAMA_DEVICE>`
2. Klik kanan folder `ReadNest` → **Properties**
3. Buka tab **Security** → klik **Edit**

   ![Security Tab](https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop/raw/main/assets/security%20settings.jpg)

4. Pilih **Users** → centang opsi **Full Control (Allow)**

   ![Full Control](https://github.com/kevin-luis/Kelompok_Pemrograman_Desktop/raw/main/assets/security%20settings%202.jpg)

5. Klik **Apply**, lalu jalankan kembali aplikasinya.

---

## 📌 Catatan

> Disarankan untuk menyimpan aplikasi di folder **selain drive C** agar tidak terjadi error permission saat akses file database lokal.
