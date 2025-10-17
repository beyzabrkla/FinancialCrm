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

### 🧠 Kullanılan Teknolojiler
-C#   Windows Forms uygulaması geliştirme dili
-Entity Framework   Veritabanı işlemleri için ORM teknolojisi
-LINQ   Veritabanı sorguları için güçlü sorgu dili


### 🚀 Giriş Akışı
- Kullanıcı adı ve şifre girilir.
- Boş alan kontrolü yapılır.
- Veritabanında eşleşen kullanıcı aranır.
- Giriş başarılıysa LoggedInUser atanır ve form kapanır.
- Giriş başarısızsa uyarı mesajı gösterilir.

# 📊 Dashboard – Genel Bakış Ekranı
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
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - Banka ve fatura verileri sorgulanır ve grafiklere aktarılır
Chart API - System.Windows.Forms.DataVisualization.Charting ile grafik oluşturulur
Timer - Fatura bilgileri döngüsel olarak güncellenir
Form Geçişleri - Her modül için ShowDialog() ile geçiş yapılır ve kullanıcı aktarılır

### 🚀 Kullanım Akışı
- Kullanıcı giriş yapar → FrmLogin
- FrmDashboard formu açılır ve kullanıcı nesnesi aktarılır
- Dashboard yüklenirken veriler sorgulanır ve görselleştirilir
- Kullanıcı modüller arasında geçiş yapabilir veya uygulamadan çıkabilir

# 🏦 Bankalar – Hesap Özeti Modülü
<img width="956" height="578" alt="Ekran görüntüsü 2025-10-17 164735" src="https://github.com/user-attachments/assets/535d054a-896a-4396-a8b9-4ef1a65e7844" />

Bu ekran, kullanıcının sahip olduğu banka hesaplarını ve her birinin bakiyesini görsel olarak sunar. Renkli kutucuklarla sadeleştirilmiş arayüz, finansal durumu hızlıca analiz etmeyi sağlar.

### 🧩 Özellikler
- 👤 Kullanıcı Karşılama: Oturum açan kullanıcı adıyla dinamik selamlama (Hoş geldin, beyza)
- 💳 Banka Bazlı Bakiye Gösterimi: Her banka için ayrı kutucukta bakiye bilgisi
- 🎨 Renk Kodlaması: Görsel ayrım için farklı renklerde kutucuklar
- 🔄 Veritabanı Entegrasyonu: Entity Framework ile canlı veri çekimi
- 🧭 Modül Geçişleri: Faturalar, Giderler, İşlemler, Dashboard ve Ayarlar formlarına geçiş

### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - Her banka için bakiye sorgusu yapılır
Nullable Kontrolü - ?.ToString("N2") ile null değerler güvenli biçimde işlenir
Formlar Arası Geçiş - ShowDialog() ile kullanıcı nesnesi aktarılır ve geçiş sağlanır

### 🚀 Kullanım Akışı
- Kullanıcı dashboard üzerinden Bankalar ekranına geçer
- FrmBanks_Load ile veriler sorgulanır ve kutucuklara aktarılır
- Kullanıcı diğer modüllere geçiş yapabilir veya uygulamadan çıkabilir

# 💸 Faturalar – Ödeme ve Yönetim Modülü
<img width="960" height="570" alt="Ekran görüntüsü 2025-10-17 164840" src="https://github.com/user-attachments/assets/55e5f87a-cd2d-4aab-90eb-5fc2bcd4aa41" />

Bu ekran, kullanıcıların çeşitli fatura işlemlerini gerçekleştirebildiği kapsamlı bir arayüz sunar. Yeni fatura ekleme, mevcut faturaları listeleme, silme ve güncelleme gibi işlemler Entity Framework üzerinden doğrudan veritabanına bağlanarak yapılır.

### 🧩 Özellikler
- 📋 Fatura Listesi: Tüm fatura kayıtları DataGridView ile listelenir
- ➕ Yeni Fatura Ekleme: Başlık, tutar ve periyot bilgileriyle kayıt oluşturulur
- 🗑️ Fatura Silme: ID’ye göre fatura silinir
- ✏️ Fatura Güncelleme: Mevcut fatura bilgileri düzenlenebilir
- 🧭 Modül Geçişleri: Bankalar, Giderler, İşlemler, Dashboard ve Ayarlar formlarına geçiş

### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - Her banka için bakiye sorgusu yapılır
Validation - Boş alan, sayı kontrolü ve kayıt varlığı denetlenir
UI Güncelleme - Her işlem sonrası tablo otomatik yenilenir
Formlar Arası Geçiş - ShowDialog() ile kullanıcı nesnesi aktarılır ve geçiş sağlanır

### 🚀 Kullanım Akışı
- Kullanıcı faturalar ekranına geçer
- Tüm faturalar tabloya yüklenir (FrmBilling_Load)
- Kullanıcı yeni fatura ekleyebilir, mevcutları silebilir veya güncelleyebilir
- Her işlem sonrası tablo güncellenir ve alanlar temizlenir
- Kullanıcı diğer modüllere geçiş yapabilir veya uygulamadan çıkabilir


# 💼 Giderler – Havale ve İşlem Yönetimi Modülü

<img width="963" height="568" alt="Ekran görüntüsü 2025-10-17 164914" src="https://github.com/user-attachments/assets/e6a74aef-40e1-4ff4-93c1-a48f2298948c" />

Bu ekran, kullanıcıların banka hesapları üzerinden para transferi yapabildiği ve geçmiş işlemleri görüntüleyebildiği bir modüldür. Hem işlem oluşturma hem de işlem silme gibi temel finansal operasyonlar Entity Framework üzerinden gerçekleştirilir.

### 🧩 Özellikler
- 🏦 Banka Bilgileri: Ekran açıldığında tüm banka hesapları ve bakiyeleri listelenir
- 📋 İşlem Listesi: “Listele” butonuna basıldığında yapılan tüm havale işlemleri detaylı şekilde gösterilir
- 💸 Para Gönderme: Seçilen banka ve alıcıya açıklama ile birlikte havale yapılabilir
- 🗑️ İşlem Silme: Kullanıcı kendi yaptığı işlemleri seçerek silebilir
- 🔍 Alıcı Doğrulama: Kullanıcı adı ve ID eşleşmesi kontrol edilir
- 🧭 Modül Geçişleri: Diğer ekranlara geçiş sağlanabilir (Dashboard, Bankalar, Faturalar vb.)

### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - Banka ve kullanıcı sorgulları yapılır
Validation - Boş alan, sayı kontrolü, kullanıcı eşleşmesi ve bakiye kontrolü yapılır
UI Güncelleme - Her işlem sonrası tablo otomatik yenilenir
Güvenlik Kontrolü - Kullanıcı kendine para gönderemez, alıcı doğrulaması yapılır

### 🚀 Kullanım Akışı
- Ekran açıldığında banka bilgileri listelenir
- Kullanıcı “Listele” butonuna basarak işlem geçmişini görüntüler
- Para gönderme işlemi için gerekli alanlar doldurulur ve doğrulamalar yapılır
- İşlem başarıyla kaydedilir ve bakiye güncellenir
- Kullanıcı isterse kendi işlemlerini seçerek silebilir


# 🔁 Giderler – Havale İşlemleri ve Banka Bakiye Takib

<img width="959" height="567" alt="Ekran görüntüsü 2025-10-17 170409" src="https://github.com/user-attachments/assets/aa78988a-961a-423b-8491-35023acad551" />


Bu ekran, kullanıcıların gerçekleştirdiği para transferlerini detaylı şekilde listeleyen ve işlem yönetimi sağlayan bir modüldür. Her işlemde gönderici, alıcı, açıklama, tutar, tarih ve işlem yapılan banka bilgileri yer alır. Aynı zamanda işlem sonrası bankada kalan bakiye de takip edilir.

### 🧩 Özellikler
- 📋 İşlem Listesi: Gönderilen tüm havale işlemleri detaylı şekilde listelenir
- 👤 Gönderici ve Alıcı Bilgisi: Her işlemde hem gönderen hem de alıcının adı görünür
- 🏦 Banka Bilgisi: İşlemin yapıldığı banka adı ve işlem sonrası kalan bakiye (Point) gösterilir
- 🗓️ Tarih ve Açıklama: Her işlem için tarih ve açıklama bilgisi yer alır
- 🗑️ İşlem Silme: Kullanıcı kendi yaptığı işlemleri seçerek silebilir
- 🔄 Liste Güncelleme: Silme veya yeni işlem sonrası tablo otomatik güncelleni


### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - İşlem listesi, kullanıcı ve banka bilgileri sorgulanır
Projection - Select ile işlem detayları tabloya özel formatta aktarılır
UI Güncelleme - Her işlem sonrası tablo yenilenir ve alanlar temizlenir
Güvenlik Kontrolü - Kullanıcı kendine para gönderemez, alıcı adı ve ID eşleşmesi yapılır

### 🚀 Kullanım Akışı
- Kullanıcı “Listele” butonuna basar → tüm işlemler detaylı şekilde listelenir
- Her işlemde gönderici, alıcı, açıklama, tutar, tarih ve banka bilgisi görünür
- Kullanıcı isterse kendi işlemlerini seçerek silebilir
- Tablo otomatik güncellenir ve alanlar temizlenir


# 🔄 Banka Hareketleri – Havale ve Ödeme Geçmişi
<img width="962" height="656" alt="Ekran görüntüsü 2025-10-17 170531" src="https://github.com/user-attachments/assets/f25a786e-e093-4e70-b2d6-7473d0cf469d" />

Bu modül, kullanıcının gerçekleştirdiği son havale ve ödeme işlemlerini ayrı panellerde göstererek finansal geçmişin hızlıca analiz edilmesini sağlar. Her işlem için tutar, tarih ve açıklama bilgileri görsel olarak sunulur.

### 🧩 Özellikler
- 💸 Son Havale Hareketleri: En son 10 havale işlemi, tutar ve tarih bilgisiyle birlikte listelenir
- 🧾 Son Ödeme Hareketleri: En son 10 harcama işlemi, açıklama ve tutar bilgisiyle birlikte gösterilir
- 📅 Tarih Formatlama: Tarihler ToShortDateString() ile okunabilir biçimde sunulur
- 🧠 Açıklama Gösterimi: Her işlem için açıklama bilgisi ayrı bir label’da gösterilir
- 🔍 Veri Güvenliği: Null değerler kontrol edilerek uygulama kararlılığı sağlanır

### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - OrderBy ve Take/Skip ile sıralı veri çekimi yapılır
Null Kontrolü - ?.ToShortDateString() ve ?? ile eksik veri güvenle işlenir
UI Güncelleme - HHer işlem ayrı label’a yazdırılır
Görsel Ayrıştırma - Havale ve ödeme işlemleri ayrı bölümlerde sunulur


# ⚙️ Ayarlar – Kullanıcı Bilgileri Güncellem
<img width="373" height="327" alt="Ekran görüntüsü 2025-10-17 170614" src="https://github.com/user-attachments/assets/82b4e50b-b755-43cc-bb1e-31fd162f2c20" />

Bu modül, kullanıcının giriş bilgilerini (kullanıcı adı ve şifre) güncellemesini sağlar. Basit ve kullanıcı dostu arayüzüyle, güvenli ve doğrulanmış bir şekilde değişiklik yapılmasına olanak tanır.

### 🧩 Özellikler
- ✏️ Kullanıcı Adı ve Şifre Güncelleme: Yeni bilgiler girilerek mevcut kullanıcı hesabı güncellenebilir
- 🔐 Boş Alan Kontrolü: Alanlar boş bırakıldığında uyarı verilir
- 🧠 Bilgi Eşleşme Kontrolü: Girilen bilgiler mevcut kayıtla aynıysa güncelleme yapılmaz
- ✅ Veritabanı Güncelleme: Entity Framework ile doğrudan Users tablosu güncellenir
- 📢 Kullanıcıya Geri Bildirim: Başarılı veya hatalı işlemler için bilgilendirme mesajları gösterilir

### 🧠 Teknik Detaylar
Entity Framework - FinancialCrmDbEntities ile veritabanı bağlantısı sağlanır
LINQ - FirstOrDefault ile kullanıcı sorgulanır
Validation - Boş alan ve bilgi eşleşme kontrolleri yapılır
UI Feedback - MessageBox ile kullanıcıya işlem durumu bildirilir

### 🚀 Kullanım Akışı
- Kullanıcı yeni bilgileri girer
- Sistem boş alan ve eşleşme kontrolü yapar
- Bilgiler farklıysa veritabanı güncellenir
- Kullanıcıya işlem sonucu bildirilir

# 🚪 Çıkış – Uygulamadan Güvenli Ayrılma
Uygulamanın sol menüsünde yer alan “Çıkış Yap” butonu, kullanıcıların oturumu sonlandırarak uygulamadan güvenli şekilde çıkmasını sağlar. Bu işlem, form geçişleriyle değil doğrudan uygulamanın kapanmasıyla gerçekleştirilir.

### 🧩 Özellikler
- 🔒 Oturum Sonlandırma: Kullanıcı uygulamayı kapatarak oturumunu sonlandırır
- 🧼 Bellek Temizliği: Formlar kapatılır, kaynaklar serbest bırakılır
- 🧭 Kolay Erişim: Sol menüde sabit konumda yer alı
