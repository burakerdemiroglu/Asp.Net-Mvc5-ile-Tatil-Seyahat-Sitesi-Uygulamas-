# TravelTripProject
Tatil ve Seyahat Blogu sitesi.

## Hakkında
Bu proje, Code First yaklaşımıyla ASP.NET MVC 5 çerçevesinde hazırlanmıştır.

## Kullanılan Teknolojiler
- **ASP.NET MVC 5** - Model-View-Controller (MVC) mimarisine dayalı bir web çerçevesi.
- **Entity Framework (EF)** - ADO NET için açık kaynaklı bir nesne ilişkisel eşleme (ORM) çerçevesi.
- **MSSQL** - Microsoft tarafından yayınlanan bir veritabanı yazılımı paketi.
- **Bootstrap 4** - Daha hızlı ve kolay web geliştirmeleri için ücretsiz bir ön uç çerçevesi.

## Kullanılan Teknikler
- Weakly Typed Data Types
- Partial Views
- Http Post
- Html Helpers
- Model Validation
- URL Rewriting
- Areas
- Session Operations
- PagedList

## Sayfalar

**Ana Sayfa:** Blog hakkında bir fotoğraf ve bloglarımızla ilgili bazı parçalı görünümler bulunmaktadır.
 
**Hakkımızda:** Web sitesini oluşturan kişinin biyografisini paylaşabileceği sayfadır.

**Bloglar:** 'Bizim Bloglarımız' bölümünde tüm blog yazılarımızı görüntüleyebilirsiniz. Ayrıca, en son eklenen 3 blog yazısı görebilirsiniz.

**İletişim:** E-posta yazabilir veya taleplerinizi, önerilerinizi ve şikayetlerinizi Admin'e iletebilirsiniz.

## Klasörler

- **Controller**: Bu klasörde, About.cs, Admin.cs, Blog.cs, Contact.cs, Home.cs,Default.cs , GrisYap.cs  ve TravelTripContext.cs olmak üzere çeşitli kontrolcüler bulunur. Tüm kontrolcülerde 'CRUD' işlemleri ve parçalı görünüm işlemleri bulunur.

- **Views**: Bu klasörde, 'CRUD' işlemleriyle ilgili Index ve diğer sayfalar bulunur. Ayrıca, Comment, PartialView, TakeHotel/Blog/Comment ile ilgili sayfaları görüntülemek için ilgili sayfalar da bulunur.

- **Content**: Bu klasörde, bootstrap eklentileri bulunur.

- **Login**: Bu klasörde, gerçek bir Admin'e erişmek isteyen kullanıcının doğrulanması için giriş ana sayfası bulunur.

- **Models/Classes**: Bu klasörde, veritabanı tablolarını temsil eden sınıflar bulunur.

- **Shared**: Bu klasörde, her sayfaya sabit kısımlar eklemek için kullanılan _TestLayout ve AdminPanel sabit kısımlarını düzenlemek için kullanılan _AdminLayout bulunur.

- **web ve web2**: Bu klasörlerde, web sitesi temaları bulunur.
- **weblogin** : Bu klasörde Login teması bulunur.


## Ekran Görüntüleri
Siteyi ve yönetici panelinin ekran görüntülerini aşağıda görebilirsiniz. (Kullanıcı Adı: "admin", Şifre: "123456").

**👨🏻‍💻 Kullanıcı Arayüzü**
---
https://github.com/burakerdemiroglu/TravelTripProject/assets/35409987/12f3f92d-d28e-4a9e-b9bc-5d5d809dc694

**👨🏻‍💻 Admin Arayüzü**
---
![AdminPanel](https://github.com/burakerdemiroglu/TravelTripProject/assets/35409987/acbd7870-3cd5-489f-92b2-75a7ec19defe)
