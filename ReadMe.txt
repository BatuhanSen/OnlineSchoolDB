Visual Studio 2019 ve MS SQL Server 2014 sürüm kullanılarak proje tamamlanmıştır.

•Online ve normal okul yapısı düşünülerek veritabanı tasarlandı.
•Tablo standartlarının çok dışına çıkmadan bazı otomatik artan alan veya primary olarak integer alan kullanılması tercih edildi.
•Ekleme ve güncelleme işlemlerinin sql tarafına yapılmasını sağlamak için her tabloya 1 adet procedure yazıldı.
•Menüde tablo yapımıza göre tüm formlarımız oluşturuldu.
•Formlarda ilgili alanları kaydetme,güncelleme,silme ve temizleme işlemleri desteklendi.
•Silme işlemi öncesinde mevcut kayıt tabloda varmı kontrolü desteklendi.
•Eski bir kayıt güncellenmek için grid üzerinde çift tıklama yapısı desteklendi.
•Integer format alanlarda sadece sayı girişi desteklendi.
•Foreign key olan alanlar sql tarafından try-catch yapısı desteklenerek mesaj döndürülmesi sağlandı.

---Projeyi Çalıştırmak İçin---
•VT_TABLE.sql dosyası çalıştırılarak veritabanı ve tablolar oluşturulur.
•VT_PROC.sql dosyası çalıştırılarak procedureler oluşturulur.
•Menu formda bulunan ConnectionString değişkenindeki SQL Server ismi değiştirilmelidir.