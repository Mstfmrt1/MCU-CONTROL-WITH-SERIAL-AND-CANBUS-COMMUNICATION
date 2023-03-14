# MCU-CONTROL-WITH-SERIAL-AND-CANBUS-COMMUNICATION-
C# MCU CONTROL WITH SERIAL AND CANBUS COMMUNICATION 
Bu proje basit şekilde isteğe göre CanBus ve Seri haberleşme yaparak farklı mikrokontrolcülere komutlar yollar ve mikrokontrolcüler gelen komutlara göre işlemler yapar ve mesaj yollar.

C# ile hazırlanan arayüzünde ilk olarak MCU ile hangi iletişimi kuracağımız seçilmelidir.
Canbus seçildi ise mikrokontrolcümüze bağlı olan USB/CAN ile , seri haberleşme seçildi mikrokontrolcünüzün RX ve TX pinlerine bağlı USB TTL dönüştürücü yardımıyla haberleşebilirsiniz.
<img width="278" alt="1" src="https://user-images.githubusercontent.com/104312094/224974006-8b413a6e-3768-4c35-90e4-aa4e82683360.PNG">


Seri haberleşme kontrol ünitesinde gerekli ayarlamaları MCU'ya uygun olarak yaptıktan sonra basit şekilde mesaj alma ve gönderme, PWM değeri yollama, çıkışlara HIGH, LOW komutları gönderme, analog değer okuma gibi işlemleri uygulayabiliriz. Bu arayüzde yaptığımız işlemler sonucu UART hattımızdan mikrokontrolcünüze bazı mesajlar gidecektir. MCU üzerinde bu mesajları alıp çözdükten sonra kodumuza entegre ederek istediğiniz işlemleri gerçekleştirebilir ayrıca uygulamayı geliştiredebilirsiniz. Basit bir şekilde STM32F407 kartında arayüzden aldığımız mesajlarla işlemler gerçekleştirildi..
<img width="543" alt="2" src="https://user-images.githubusercontent.com/104312094/224974007-3f82c383-d9a3-469c-af4f-7c51cf556391.PNG">


CanBus ünitesinde ise gerekli bağlantılar sonrası Input değerlerini okuyabilir , Outputları kontrol edebiliriz. Bu arayüzü ise LPC11C24 kontrolcü kartıyla haberleştirerek basit bir deneme yapılmıştır.
<img width="528" alt="3" src="https://user-images.githubusercontent.com/104312094/224973995-54c3b857-a859-4f7d-9756-3ba2836cb179.PNG">


