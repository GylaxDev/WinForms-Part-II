# Windform Pt 2 - Praktikum WinForms (CRUD PostgreSQL)

Project lanjutan Praktikum WinForms dengan fitur CRUD data user ke PostgreSQL,
form login, dashboard, dan form utama berbasis panel.

## Struktur Penting

| File | Keterangan |
| --- | --- |
| `PraktikumWinForms/DatabaseHelper.cs` | Koneksi Npgsql + operasi CRUD |
| `PraktikumWinForms/User.cs` | Model/entity user (`id`, `nama`, `umur`, `asal`) |
| `PraktikumWinForms/FormCRUD.cs` | Form tambah/edit user |
| `PraktikumWinForms/FormDashboard.cs` | Tabel user + tombol Tambah/Edit/Hapus |
| `PraktikumWinForms/FormUtama.cs` | Form induk dengan `PanelUtama` |
| `PraktikumWinForms/LoginForm.cs` | Login, lalu membuka dashboard di panel |
| `PraktikumWinForms/Program.cs` | Entry point menjalankan `FormUtama` |
| `database.sql` | DDL tabel `users` |

## Persiapan Database

1. Pastikan service PostgreSQL berjalan.
2. Buat database bernama `db_windform_user` (bisa lewat pgAdmin).
3. Jalankan DDL berikut lewat Query Tool:

```sql
CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    nama VARCHAR(100),
    umur INT,
    asal VARCHAR(100)
);
```

Atau langsung dari terminal:

```powershell
psql -U postgres -d db_windform_user -f database.sql
```

## Konfigurasi Koneksi

Sesuaikan bagian ini di `DatabaseHelper.cs` bila username/password PostgreSQL
di komputer Anda berbeda:

```csharp
string host = "localhost";
string port = "5432";
string db = "db_windform_user";
string username = "postgres";
string password = "heisenberg";
```

## Menjalankan Aplikasi

```powershell
dotnet run --project PraktikumWinForms
```

Akun login:

- Username: `andromok`
- Password: `agusandro`

Setelah login berhasil, `FormDashboard` akan tampil di dalam `PanelUtama`.
Gunakan tombol **Tambah**, **Edit**, dan **Hapus** untuk mengelola data user.
