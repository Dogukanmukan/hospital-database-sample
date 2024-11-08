# MedipolHastane - Hastane Veritabanı Örneği

Bu proje, hastane bilgi sistemleri geliştirenler için örnek bir veritabanı yapısı sunmaktadır. MedipolHastane dizini, hasta kayıtları, doktor bilgileri, randevu takibi ve tedavi geçmişi gibi temel hastane işlemlerini kapsayan tablolar ve ilişkiler içermektedir.

## İçindekiler
- [Özellikler](#özellikler)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Veritabanı Yapısı](#veritabanı-yapısı)
- [Kullanım](#kullanım)
- [Katkı](#katkı)
- [Lisans](#lisans)

## Özellikler
- Hasta, doktor ve personel kayıtlarının tutulması
- Randevu takibi ve yönetimi
- Tedavi geçmişi ve hasta sağlık durumu kaydı
- JSON formatında veri alışverişi desteği

## Kullanılan Teknolojiler
- **Veritabanı Yönetim Sistemi:** Microsoft SQL Server
- **Programlama Dili:** C#
- **Geliştirme Ortamı:** Visual Studio
- **Veri Formatı:** JSON
- **Yazılım Mimarisi:** Nesne Yönelimli Programlama (OOP)
- **Versiyon Kontrol:** Team Foundation Server (TFS)

Bu teknolojiler, hastane bilgi sistemlerinin etkin, güvenli ve esnek bir yapıda geliştirilmesine olanak tanır.

## Kurulum
1. Bu projeyi yerel makinenize klonlayın:
    ```bash
    git clone https://github.com/Dogukanmukan/hospital-database-sample.git
    ```
2. Microsoft SQL Server'da `MedipolHastane.sql` dosyasını çalıştırarak gerekli tabloları ve ilişkileri oluşturun.

3. Visual Studio'da projeyi açın ve veritabanı bağlantılarını kontrol edin.

## Veritabanı Yapısı
Veritabanı aşağıdaki temel tabloları içerir:
- **Hastalar**: Hasta bilgileri (ad, soyad, doğum tarihi vb.)
- **Doktorlar**: Doktor bilgileri (isim, uzmanlık alanı vb.)
- **Randevular**: Hastalar ve doktorlar arasındaki randevu ilişkisi
- **Tedavi Geçmişi**: Hastaların tedavi geçmişi kayıtları

## Kullanım
1. Visual Studio'da projeyi derleyip çalıştırın.
2. SQL Server Management Studio kullanarak SQL sorgularıyla veritabanı işlemlerini gerçekleştirin.

## Katkı
Projeye katkıda bulunmak için:
1. Bu projeyi forkladıktan sonra geliştirmelerinizi yapın.
2. Değişikliklerinizi `main` branch'ine göndermeden önce bir `pull request` oluşturarak önerilerinizi paylaşabilirsiniz.

## Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Ayrıntılar için `LICENSE` dosyasına bakabilirsiniz.
