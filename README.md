# Overview

## User Story
Kim Ji-Won, seorang kasir yang bekerja di sebuah apotek, memiliki keinginan untuk meningkatkan efisiensi proses transaksi sehingga dapat memberikan pelayanan yang lebih baik kepada pelanggan. Dengan memperhatikan kebutuhan sehari-hari, Kim Ji-Won memutuskan untuk menggunakan aplikasi desktop khusus yang akan membantunya dalam mengelola transaksi penjualan.

Ketika Kim Ji-Won membuka aplikasi tersebut, dia disambut dengan antarmuka yang bersih dan mudah dipahami. Di layar utama aplikasi, terdapat kolom-kolom yang memungkinkannya untuk memasukkan kode barang dan jumlah yang akan dibeli oleh pelanggan.

Dengan cepat dan akurat, Kim Ji-Won memasukkan informasi tersebut. Aplikasi secara otomatis menghitung total belanjaan dan kembaliannya, memastikan bahwa setiap transaksi dihitung dengan tepat. Setelah selesai, Kim Ji-Won dengan mudah dapat melihat ringkasan transaksi dan mencetak struk pembayaran untuk pelanggan.

Selain membantu dalam proses transaksi secara real-time, aplikasi ini juga memiliki fitur penyimpanan data ke dalam database. Setiap transaksi yang dilakukan oleh Kim Ji-Won akan secara otomatis tersimpan, memungkinkan untuk diakses kembali jika diperlukan. Hal ini membantu Kim Ji-Won dalam melakukan pelacakan inventaris dan analisis penjualan secara efisien.

Dengan menggunakan aplikasi ini, Kim Ji-Won merasa bahwa tugasnya sebagai kasir menjadi lebih mudah dan terorganisir. Dia dapat fokus pada pelayanan kepada pelanggan tanpa khawatir tentang kesalahan perhitungan atau kesulitan dalam mengelola data transaksi. Dengan demikian, Kim Ji-Won berhasil mengoptimalkan proses transaksi di apotek, meningkatkan efisiensi dan kualitas pelayanan secara keseluruhan.

Tech Stack :
- [x] .NET 8
- [x] MsSQL
- [x] EntityFramework

NB : backup database terdapat pada directory Resources

Features :
- [x] Auto Generate Faktur Number
- [x] Auto Fill Detail Item based On Selected ID
- [ ] Reporting
## entity

### m_stuffs
- id : string
- name : varchar
- price : integer
### m_users
- id : integer
- username : varchar
- password : varchar
### t_orders
- id : integer
- faktur_no : varchar
- faktur_date : datetime
### t_order_details
- id (PK) : integer
- order_id (FK)
- stuff_id (FK)
- price : integer
- qty : integer

#dotnet #desktop