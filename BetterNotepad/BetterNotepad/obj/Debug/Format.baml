   M S B A M L   `   `   `  ����H  DBetterNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BetterNotepadBetterNotepad  5   	       BetterNotepad.Format   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BetterNotepad     5   	     � Title$  Format��5   	   $	��300��6   $	��500��6(    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterOwner=�6M   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��5��6    $��Center=�6-   .��6I   
Preview:6S   �� 5   
   -   5        $��example_label��5   -   $��1��6   $��5��6    $��Center=�5      $��Center=�6+   .��6H   Ala ma kota6U   �� 5   
   $��0��6   .��6    
FontFamily6,   �� 5   
   -   5        $��cb_fontFamily��5      $��1��5       �� SelectedIndex$ 0��6#   ��65   ��    System.Windows.Media.Fonts   SystemFontFamilies �� Source# Z 5   (   �� 5    
   -   5        $��
size_label��5    .   $��0��6   $��1��6!   .��6@   	Size: 96I   �� 5!   
   -   5        $��slider_size��5!   L   $��1��6   $��1��6!   $��Stretch=�6.   $��5q�5"       � Minimum$ 5Q�6   	 � Maximum$		 120Q�6(   68   �� 5$   
   -   5        $��chckBox_bold��5$   Z   $��2��6   $��2��6'   $��5q�64   $��Center=�6?   .��5%   U   Bold6[   �� 5&   
   -   5        $��chckBox_italic��5&   Z   $��2��6   $��3��6'   $��5q�64   $��Center=�6?   .��5'   Y   Italic6a   �� 5+      
 �� Orientation$
 
Horizontal=�6   $��Right=�62   $��Center=�6N   $��2��6i   $��6��6}   $��2q�6�   .+�5,      �� -   5        $��btn_save_format��5,   )   $��	20,0,20,0q�6   .��6_   SAVE6e   �� 5-      -   5        $��
btn_cancel��5-   )   $��	20,0,20,0q�6   .��6T   CANCEL6\   5.      50      51      