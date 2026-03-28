# 🧑‍💻 Dinamik CV ve Portfolyo Yönetim Sistemi

Bu proje, kişisel özgeçmiş (CV) ve portfolyo bilgilerinin dinamik olarak yönetilebildiği, arka planda kurumsal bir Admin paneli barındıran web tabanlı bir kişisel markalaşma projesidir. **ASP.NET MVC 5** mimarisiyle geliştirilmiş olup, kod tekrarını önlemek ve veri erişim katmanını soyutlamak amacıyla **Repository Design Pattern** kullanılarak inşa edilmiştir.

🌐 **Canlı Demo:** [www.mustafaalmaz.com.tr](https://www.mustafaalmaz.com.tr)

## 🚀 Öne Çıkan Özellikler ve Mimari

* **Repository Design Pattern:** Veritabanı işlemleri (CRUD) soyutlanarak daha temiz, test edilebilir ve sürdürülebilir bir kod altyapısı kuruldu.
* **Güvenli Admin Paneli:** Kullanıcı giriş (Login) sistemi ve yetkilendirme (Authorization) süreçleri ile korunan, tüm CV içeriğinin (Eğitim, Deneyim, Yetenekler vb.) yönetildiği kurumsal arayüz.
* **Modüler Ön Yüz (Frontend):** Sayfa yapısındaki tekrarları önlemek ve kod okunabilirliğini artırmak için **Partial Views** kullanımı.
* **Database First Yaklaşımı:** Mevcut veritabanı şeması üzerinden Entity Framework ile modellerin oluşturulması ve veri yönetimi.

## 🛠️ Kullanılan Teknolojiler

* **Backend:** C#, ASP.NET MVC 5
* **Mimari Desen:** Repository Design Pattern
* **Veritabanı ve ORM:** MS SQL Server, Entity Framework (Database First)
* **Frontend:** HTML5, CSS3, Bootstrap
* **Geliştirme Yaklaşımı:** Tam kapsamlı CRUD işlemleri, Partial View entegrasyonu

## 📸 Proje Görüntüleri

### Canlı Web Sitesi (Ön Yüz Arayüzü)
*(Ziyaretçilerin gördüğü kişisel web sitesi arayüzü)*
![CV Ön Yüz](CvImages/Frontend.png)

### Admin Kontrol Paneli (Arayüz)
*(Deneyim, Eğitim ve Yeteneklerin dinamik olarak yönetildiği, yetkilendirmeli kurumsal arayüz)*
![Admin Paneli](CvImages/AdminPanel.png)

### Proje Mimarisi ve Kod Yapısı (Visual Studio)
*(Projenin MVC 5 mimarisi, `Areas/Admin` kurumsal yapısı ve Solution Explorer üzerindeki dosya organizasyonunun görüntüsü)*
![Proje Mimarisi](CvImages/ProjectArchitecture.png)

---
*Geliştirici: [Mustafa Almaz](https://github.com/mustafalmazz) - .NET Developer*
