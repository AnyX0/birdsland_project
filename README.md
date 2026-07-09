# Bird Lands Project
![](PosterBirdsLands.png)

Project ini adalah project Unity 6 untuk aplikasi/game 3D bertema **Bird Lands**. Struktur project menunjukkan adanya beberapa scene utama, menu awal, splash screen, serta scene kategori seperti Herbivora, Karnivora, dan Omnivora. Project ini juga menggunakan beberapa paket Unity tambahan seperti **Vuforia**, **2D Feature**, **Timeline**, **Visual Scripting**, **LeanTouch**, dan **Adaptive Performance**.


<p align="center">
  <a href="https://github.com/AnyX0/birdsland_project/releases/latest"><img src="https://img.shields.io/badge/Download-APK%20Terbaru-brightgreen?style=for-the-badge" alt="Download APK Terbaru" /></a><img src="data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7" width="60" height="1" />&nbsp;&nbsp;<a href="https://drive.google.com/drive/folders/1stU9DpmN6C-6XVHgQEvEWIGHkEf_tAiX?usp=sharing" target="_blank" rel="noopener noreferrer"><img src="https://img.shields.io/badge/Download-Image%20Target-blue?style=for-the-badge" alt="Download Image Target" /></a>
</p>



Atau kunjungi halaman [Releases](https://github.com/AnyX0/birdsland_project/releases) untuk versi lainnya.

## Versi Unity

- **Unity Editor**: 6000.0.47f1


## Deskripsi Project

Project ini berisi komponen utama berikut:
- **Sistem Augmented Reality (AR)**: Menggunakan **Vuforia Engine** untuk melacak *Image Target* dan memunculkan model 3D satwa burung secara *real-time* dan stabil di dunia nyata.
- **Interaksi 3D Responsif (LeanTouch)**: Pengguna memiliki kendali penuh untuk berinteraksi dengan objek 3D melalui gestur layar sentuh, seperti memutar (rotasi) dan mengubah ukuran (skala) model burung.
- **Navigasi Kategori Edukatif**: Pengelompokan spesies yang terstruktur dan dibagi ke dalam *scene* khusus berdasarkan jenis makanannya: **Karnivora**, **Herbivora**, dan **Omnivora**, guna mempermudah proses pembelajaran.
- **Ensiklopedia Digital & Audio**: Setiap objek 3D dilengkapi dengan panel *pop-up* informasi yang memuat nama ilmiah, deskripsi spesies, status konservasi, serta fitur pemutar suara (audio) asli dari burung tersebut.
- **Antarmuka Pengguna (UI) Lengkap**: Menyediakan alur aplikasi yang utuh, mulai dari *Splash Screen*, *Main Menu*, *Instruction*, hingga *About* yang berisi profil tim pengembang.
- **Optimasi Mobile**: Terintegrasi dengan **Adaptive Performance** untuk memastikan aplikasi berjalan dengan mulus (lancar) dan stabil saat di-*build* ke platform Android.

## Struktur Folder Penting

- `Assets/Scenes` - berisi scene utama project.
- `Assets/Script` - berisi script C# untuk logika aplikasi.
- `Assets/StreamingAssets` - berisi file yang dibaca langsung saat runtime.
- `Assets/Resources` - berisi resource yang bisa diakses melalui script.
- `Packages/manifest.json` - daftar package Unity yang dipakai project.
- `ProjectSettings/ProjectVersion.txt` - versi Unity yang digunakan.

## Instalasi

1. Install **Unity Hub**.
2. Install versi **Unity 6000.0.47f1** lewat Unity Hub.
3. Clone repository ini dari GitHub.
4. Buka folder project di Unity Hub, lalu pilih folder root yang berisi `Assets`, `Packages`, dan `ProjectSettings`.
5. Tunggu proses import asset dan restore package selesai.
6. Jika ada package yang belum terpasang, pastikan koneksi internet aktif agar Unity bisa mengunduh dependensi dari `Packages/manifest.json`.
7. Buka scene dari folder `Assets/Scenes` sesuai kebutuhan.

## Cara Menjalankan Project

1. Buka project di Unity.
2. Pastikan scene awal sudah ada di **Build Settings**.
3. Jalankan project melalui tombol **Play** di Unity Editor.
4. Jika ingin build ke Android, atur platform build ke Android dan pastikan konfigurasi Vuforia atau package lain sudah sesuai.


## Lisensi

Project ini menggunakan lisensi [MIT](LICENSE) dan boleh dimodifikasi.
