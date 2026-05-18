# Demo Product (ASP.NET Core CRUD & OOP Project)

Bu proje, ASP.NET Core platformu üzerinde Nesne Yönelimli Programlama (OOP) prensiplerini pekiştirmek, dinamik veri tabanı operasyonlarını (CRUD) yürütmek ve güvenli üyelik sistemlerini entegre etmek amacıyla geliştirilmiş bir web uygulaması projesidir.

## 🛠️ Kullanılan Teknolojiler & Araçlar
* **Backend:** ASP.NET Core
* **Güvenlik & Kimlik Doğrulama:** ASP.NET Core Identity
* **Veritabanı:** Entity Framework Core & MS SQL Server
* **Tasarım/Arayüz:** HTML5, CSS3, Bootstrap

## 🔐 Güvenlik ve Kimlik Doğrulama (ASP.NET Core Identity)
Projeye kullanıcı güvenliği, kayıt ve yetkilendirme süreçlerini yönetmek adına **ASP.NET Core Identity** kütüphanesi entegre edilmiştir. Bu kapsamda şu yetkinlikler pratik edilmiştir:
* **Kullanıcı Kayıt ve Giriş (Register/Login):** Güvenli şifreleme algoritmaları (Hashing) kullanılarak kullanıcı hesaplarının oluşturulması ve kimlik doğrulaması.
* **Rol Tabanlı Yetkilendirme (Role-Based Authorization):** Kullanıcıların rollerine göre (Admin, Üye vb.) sayfalara ve CRUD operasyonlarına erişim sınırlandırmalarının yapılması.
* **Oturum Yönetimi:** Güvenli çerez (Cookie) tabanlı oturum yönetimi ve çıkış (Logout) mekanizmaları.

## 🧠 Projede Pratik Edilen OOP Temelleri
Proje mimarisi inşa edilirken Nesne Yönelimli Programlamanın (OOP) temel yapı taşları aktif olarak kullanılmıştır:
* **Sınıflar ve Nesneler (Classes & Objects):** Ürünlerin, kategorilerin ve operasyonların modellenmesi.
* **Kapsülleme (Encapsulation):** Property yapıları ve veri güvenliğinin sağlanması.
* **Kalıtım (Inheritance):** Ortak özelliklerin veya metotların tek bir merkezden (Base Entity) türetilmesi.
* **Çok Biçimlilik (Polymorphism):** Metotların farklı sınıflarda esnek bir şekilde ezilmesi veya yeniden şekillendirilmesi.

## 🚀 Öne Çıkan Özellikler & CRUD Operasyonları
Uygulama üzerinde veri tabanı yönetiminin temelini oluşturan tüm CRUD işlemleri dinamik olarak simüle edilmiştir:
* **Create (Ekleme):** Yeni ürün veya kategorilerin sisteme ve veri tabanına başarılı bir şekilde kaydedilmesi.
* **Read (Listeleme):** Kayıtlı verilerin listelenmesi, filtreler oluşturulması.
* **Update (Güncelleme):** Mevcut verilerin kullanıcı paneli üzerinden dinamik olarak güncellenmesi.
* **Delete (Silme):** İhtiyaç duyulmayan verilerin sistemden kaldırılması veya pasife çekilmesi.
