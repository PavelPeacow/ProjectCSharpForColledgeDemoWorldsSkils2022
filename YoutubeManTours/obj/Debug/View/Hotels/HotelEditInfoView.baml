   M S B A M L   `   `   `  ????J  FYoutubeManTours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YoutubeManTours.ViewYoutubeManTours.View  5   	   ,    &YoutubeManTours.View.HotelEditInfoView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:YoutubeManTours.View     5   	     ? Title$-  'Редактирование отеля??5   	   $	??400??6&   $	??300??63   .??5	      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $#??Название отеля: ??6   ?? 5   
   $??1??6   $'??!Количество звезд: ??6   ?? 5   
   $??2??6   $#??Описание отеля: ??6   ?? 5   
   $??3??6   $??Страна: ??6   ?? 5   
   -   5         ??Name$ TxtNameHotel??5      $??0??6(   $??1??65   ?? 5   
   -   5        $ TxtCountStars??5      $??1??6)   $??1??66   ?? 5   
   -   5        $ TxtDescriptionHotel??5      $??2??6/   $??1??6<   ?? 5    
   -   5        $??CmbNameCountry??5    ,    ?? DisplayMemberPath$
 Name??6   $??3??6B   $??1??6O   ?? 5"   
   -   5         ??Name$ BtnDeleteHotel??5"      $??Удалить??6F   $??4??6X   $??0??6e   ?? 5#   
   -   5        $ BtnUpdateHotel??5#      $??Обновить??6F   $??4??6Y   $??1??6f   5%      5&      