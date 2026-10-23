-- Database dan tabel untuk Praktikum WinForms (Windform Pt 2)
-- Jalankan lewat pgAdmin Query Tool atau psql:
--   psql -U postgres -d db_windform_user -f database.sql

CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY,
    nama VARCHAR(100),
    umur INT,
    asal VARCHAR(100)
);
