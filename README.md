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
-LINQ   Veritabanı sorguları için güçlü sorgu dili![Uploading Ekran görüntüsü 2025-10-17 170614.png…]()


## 🚀 Giriş Akışı
- Kullanıcı adı ve şifre girilir.
- Boş alan kontrolü yapılır.
- Veritabanında eşleşen kullanıcı aranır.
- Giriş başarılıysa LoggedInUser atanır ve form kapanır.
- Giriş başarısızsa uyarı mesajı gösterilir.
