﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Управление общими сведениями о сборке осуществляется с помощью 
// набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
// связанные со сборкой.
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("Данное расширение позволяет: \r\n - создать учетную запись пользователя в Active Directory согласно правилам транслитерации ГОСТ  \r\n - создать окружение для сетевой папки сканирования, для последующей регистрации network share на МФУ \r\n Создает: группу доступа к указываемой сетевой папке, пользователя scan с номером МФУ, добавляет пользователя scan в группу, политику монтирующую указанный сетевой диск искомого файлового сервера для сканирования (в политике в Security Filtering прописывается созданная группа доступа, в параметрах политики прописывается путь к сетевой шаре для монтирования сетевого диска и ярлыка на рабочий стол)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Active Directory: add-on")]
[assembly: AssemblyCopyright("© Буталов Андрей 2022, butalov.a@ya.ru")]
[assembly: AssemblyTrademark("Буталов Андрей")]
[assembly: AssemblyCulture("")]

// Параметр ComVisible со значением FALSE делает типы в сборке невидимыми 
// для COM-компонентов.  Если требуется обратиться к типу в этой сборке через 
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("f3f3a285-2f54-4be5-9315-a30eaae6e1e2")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии 
//   Номер сборки
//      Редакция
//
// Можно задать все значения или принять номера сборки и редакции по умолчанию 
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.0.0")]