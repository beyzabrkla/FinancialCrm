# 🧾 FinancialCrm 

## Giriş Modülü
<img width="370" height="367" alt="Ekran görüntüsü 2025-10-17 164502" src="https://github.com/user-attachments/assets/a180effb-87d5-4de1-b4cd-c6bb98065106" />

Bu proje, finansal kontrol sistemine kullanıcı girişi sağlayan bir Windows Forms uygulamasıdır. Entity Framework kullanılarak veritabanı bağlantısı kurulmuş ve kullanıcı doğrulama işlemleri gerçekleştirilmiştir.

### 📌 Özellikler
- Kullanıcı adı ve şifre ile giriş doğrulama
- Boş alan kontrolü ve kullanıcıya uyarı mesajları
- Entity Framework ile veritabanı sorgulama
- Başarılı giriş sonrası kullanıcı nesnesinin saklanması
- DialogResult.OK ile form geçiş kontrolü

## 🧠 Kullanılan Teknolojiler
-C#   Windows Forms uygulaması geliştirme dili
-Entity Framework   Veritabanı işlemleri için ORM teknolojisi
-LINQ   Veritabanı sorguları için güçlü sorgu dili


## 🚀 Giriş Akışı
- Kullanıcı adı ve şifre girilir.
- Boş alan kontrolü yapılır.
- Veritabanında eşleşen kullanıcı aranır.
- Giriş başarılıysa LoggedInUser atanır ve form kapanır.
- Giriş başarısızsa uyarı mesajı gösterilir.

## 📊 Dashboard – Genel Bakış Ekranı
<img width="962" height="569" alt="Ekran görüntüsü 2025-10-17 164516" src="https://github.com/user-attachments/assets/78d438ea-b525-4524-ba6e-40018d48991b" />

Giriş işlemi başarıyla tamamlandıktan sonra kullanıcıyı karşılayan Genel Bakış (Dashboard) ekranı, finansal verilerin özetini sunar. Kullanıcıya özel karşılama, grafiklerle görselleştirilmiş veriler ve modüllere geçiş butonlarıyla zenginleştirilmiş bir arayüz içerir.

### 🧩 Özellikler
- 👤 Kullanıcı Karşılama: Oturum açan kullanıcı adıyla dinamik karşılama (Hoş geldin, beyza)
- 💰 Toplam Bakiye: Tüm banka hesaplarındaki toplam para miktarı
- 📥 Son Havale Tutarı: En son yapılan banka işleminin tutarı
- 📊 Banka Bakiyeleri Grafiği: Bar chart ile banka bazlı para dağılımı
- 🧁 Fatura Durumları Grafiği: Doughnut chart ile fatura türlerine göre tutar analizi
- 🔄 Dinamik Fatura Bilgisi: Timer ile döngüsel olarak gösterilen fatura tutarları
- 🧭 Modül Geçişleri: Bankalar, Faturalar, Giderler, İşlemler ve Ayarlar formlarına geçiş

### 🧠 Teknik Detaylar
Entity Framework- FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - Banka ve fatura verileri sorgulanır ve grafiklere aktarılır
Chart API-  System.Windows.Forms.DataVisualization.Charting ile grafik oluşturulur
Timer - Fatura bilgileri döngüsel olarak güncellenir
Form Geçişleri - Her modül için ShowDialog() ile geçiş yapılır ve kullanıcı aktarılır

### 🚀 Kullanım Akışı
- Kullanıcı giriş yapar → FrmLogin
- FrmDashboard formu açılır ve kullanıcı nesnesi aktarılır
- Dashboard yüklenirken veriler sorgulanır ve görselleştirilir
- Kullanıcı modüller arasında geçiş yapabilir veya uygulamadan çıkabilir

