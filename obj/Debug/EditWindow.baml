   M S B A M L   `   `   `  ����E  AMagazynApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MagazynApp
MagazynApp  5   	       MagazynApp.EditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MagazynApp     5   	     � Title$  
EditWindow��5   	   $	��300��6   $	��300��6)   .��5	      � -   5         �Name$ editProd��5	       � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��ID��6   $��0��6   $��0��6*   �� 5   
   -   5         ��Name$ txtbID��5      $��0��6"   $��1��6/   ��6?   �� *ID+�� 5   
   $��Nazwa��6   $��1��6    $��0��6-   �� 5   
   -   5        $ txtbName��5      $��1��6$   $��1��61   ��6A   �� *Nazwa+�� 5   
   $��Liczba sztuk��6   $��2��6'   $��0��64   �� 5   
   -   5        $ 	txtbCount��5      $��2��6%   $��1��62   ��6B   �� *LiczbaSztuk+�� 5   
   $��Lokalizacja��6   $��3��6&   $��0��63   �� 5   
   -   5        $ txtbLocation��5      $��3��6(   $��1��65   ��6E   �� *Lokalizacja+�� 5   
   -   5         ��Name$ btAccept��5      $��Center=�6#   $��
Zatwierdź��6G   $��4��6[   $��2��6h   6|   5      5      