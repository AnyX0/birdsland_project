# Bird Lands Project

Project ini adalah project Unity 6 untuk aplikasi/game 3D bertema **Bird Lands**. Struktur project menunjukkan adanya beberapa scene utama, menu awal, splash screen, serta scene kategori seperti Herbivora, Karnivora, dan Omnivora. Project ini juga menggunakan beberapa paket Unity tambahan seperti **Vuforia**, **2D Feature**, **Timeline**, **Visual Scripting**, dan **Adaptive Performance**.

[![Download APK Terbaru](https://img.shields.io/badge/Download-APK%20Terbaru-brightgreen?style=for-the-badge)](BUILD_/APK/Bird_Lands_v1.3.apk)


## Versi Unity

- **Unity Editor**: 6000.0.47f1

## Folder yang Di-push ke GitHub

Untuk project Unity, yang perlu di-push hanya folder berikut:

- `Assets`
- `Packages`
- `ProjectSettings`


## Deskripsi Project

Project ini berisi komponen utama berikut:

- **Main Menu** untuk navigasi awal aplikasi.
- **Splash Screen** sebagai tampilan pembuka.
- **Scene kategori**: `Herbivora`, `Karnivora`, dan `Omnivora`.
- **Asset visual dan animasi** pada folder `Animated`, `3D`, `Image`, `TextMesh Pro`, dan `Resources`.
- **Script** untuk kontrol antarmuka, loading, rotasi objek, dan pembukaan panel.
- **Vuforia** untuk konfigurasi fitur augmented reality jika digunakan pada build Android.

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

## Catatan Untuk Push ke GitHub

- Pastikan hanya commit folder `Assets`, `Packages`, dan `ProjectSettings`.
- Jangan ikut commit folder hasil generate Unity seperti `Library` atau `Temp`.
- Jika ada file package lokal seperti `.tgz` di dalam `Packages`, file tersebut perlu ikut disimpan karena dipakai oleh `manifest.json`.

## Lisensi

Jika project ini akan dipublikasikan, tambahkan lisensi sesuai kebutuhan sebelum repository dibagikan secara umum.
