# Demo Product (ASP.NET Core CRUD & OOP Project)

Bu proje, ASP.NET Core platformu üzerinde Nesne Yönelimli Programlama (OOP) prensiplerini pekiştirmek, dinamik veri tabanı operasyonlarını (CRUD) yürütmek ve güvenli üyelik sistemlerini entegre etmek amacıyla geliştirilmiş bir web uygulaması projesidir.

## 🛠️ Kullanılan Teknolojiler & Araçlar
* **Backend:** ASP.NET Core
* **Güvenlik & Kimlik Doğrulama:** ASP.NET Core Identity
* **Veritabanı:** Entity Framework Core & MS SQL Server
* **Tasarım/Arayüz:** HTML5, CSS3, Bootstrap

## 🔐 Güvenlik ve Kimlik Doğrulama (ASP.NET Core Identity)
Sistemdeki kullanıcı yönetimi ve oturum güvenliği **ASP.NET Core Identity** kütüphanesi entegre edilerek sağlanmıştır. Projede şu temel güvenlik yapıları pratik edilmiştir:
* **Kimlik Doğrulama (Authentication):** Kullanıcı kayıt (Register) ve giriş (Login) mekanizmalarının kurulması.
* **Şifre Güvenliği:** Kullanıcı şifrelerinin veri tabanında düz metin olarak değil, Identity'nin sunduğu güvenli şifreleme (Password Hashing) algoritmalarıyla kriptolanarak saklanması.
* **Oturum Yönetimi (Cookie Authentication):** Kullanıcıların sisteme giriş yaptıktan sonra güvenli bir şekilde çerezler (Cookies) üzerinden oturumlarının takibi ve çıkış (Logout) işlemlerinin yapılması.

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
