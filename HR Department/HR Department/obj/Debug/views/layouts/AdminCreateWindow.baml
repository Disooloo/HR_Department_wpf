   M S B A M L   `   `   `  ����H  DHR Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HR_Department.views.layoutsHR_Department.views.layouts  5   	   3    -HR_Department.views.layouts.AdminCreateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HR_Department.views.layouts     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          � Icon$  /Assets/img/logo.png��5   	      MaterialDesignBody#���   5	   	    � Title$3 -Добавление пользователя��5   	   $	��685��6)   $
��1030��66    � AllowsTransparency .  � WindowStyle$
 None=�5   #    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5         � ColumnDefinitions 5   
   �� 5      $��8* �6   6,   �� 5      $��7* �6   6,   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $
��148* �6    �� 5      $
��177* �6    .+�5      � $��Stretch=�6   $��Stretch=�61   .+�5      �� $*��$/Assets/img/meeting-1453895_1280.png��6   5      #  MaterialDesignThemes.Wpf.Card  5      $��1��6"   $��Center=�5   "   $	��Top=�5   "   .��5!      � .+�5"      �� $��Отдел кадров: ��6    $��30(�66   $��0��6D   $��0��6Q   $
��Left=�5#       $
��10 0q�6;    $  MaterialDesignHeadline4TextBlock#��[ 5$       &   System.Windows.Controls.DataGrid  5&      -   5        $��DBlist��5&         AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�5)      $
��Auto=�5*      	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   Header$
 #��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   ��  �� Path$ id�  5.      $
 Имя��61   $ * 6>    6H   �� $ lastName�  5/      $
 Фамилия��61   $ * 6B    6L   �� $ 	firstName�  50      $
 Должность��61   $ * 6D    6N   �� $
 post�  51      $
 
Логин��61    6@   �� $ login�53      54      55      58      '  !MaterialDesignThemes.Wpf.PackIcon  5;   
   -   5           Kind$ close=�5;   "   $��25��6/   $��25��6:    � Cursor$
 Hand��5<   "   $��5,5,0,0q�5=   "   5?      � 5B   
   $��0��6   $��Center=�6   $	��280��6:   .+�5C      �� $��Отдел кадров: ��6   $��30(�6.   $��0��6<   $��0��6I   $
��Left=�5D      $
��10 0q�63   #��[ 5E      �� 5F      -   5        $��	logotitle��5F   ,   $��Пользователи��6   $��30(�6=   $��0��6K   $��0��6X   $��Right=�5G      $
��20 0q�64   $
��Bold"�6B   ���#673AB7#��[ 5H      � 5K      $��50 -80q�6   $
��Left=�6#   $	��Top=�6>   .+�5L      ��  �� Orientation$ 
Horizontal=�6   $��0��66   $	��234��6C   .+�5M        $��1��6.   $��0��6;   $ Person=�5N   .   $��Center=�5P   .   ��5O   .   ��  �� ElementName$ lastName��$ BorderBrush�5R      �� 5S      -   5        $��lastName��5T       % !MaterialDesignFloatingHintTextBox#��[ 5U      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Имя��5V      $	��199��5W      $��40��6%   ��5X      �� $ lastName�.��68   5Y      5Z      �� 5[      $ 
Horizontal=�6   $��1��66   $��1��6C   $��	0 100 0 0q�6S   $	��234��6f   .+�5\        $��1��6.   $��0��6;   $ Person=�5]   .   $��Center=�5_   .   ��5^   .   �� $ 	firstName��$ BorderBrush�5a      �� 5b      -   5        $��	firstName��5c      #��[ 5d      $ Фамилия��5e      $	��199��5f      $��40��6%   ��5g      �� $ 	firstName�.��69   5h      5i      �� 5k      $ 
Horizontal=�6   $��3��66   $��1��6C   $��	0 200 0 0q�6S   $	��234��6f   .+�5l        $��1��6.   $��0��6;   $
 Post=�5m   .   $��Center=�5o   .   ��5n   .   �� $
 post��$ BorderBrush�5q      �� 5r      -   5        $
��post��5s      #��[ 5t      $ Роль��5u      $	��199��5v      $��40��6%   ��5w      �� $
 post�.��64   5x      5y      �� 5{      $ 
Horizontal=�6   $��3��66   $��1��6C   $��	0 300 0 0q�6S   $	��234��6f   .+�5|        $��1��6.   $��0��6;   $ Login=�5}   .   $��Center=�5   .   ��5~   .   �� $ login��$ BorderBrush�5�      �� 5�      -	   5        $��login��5�      #��[ 5�      $ 
Логин��5�      $	��199��5�      $��40��6%   ��5�      �� $ login�.��65   5�      5�      �� 5�      $ 
Horizontal=�6   $��3��66   $��1��6C   $��	0 400 0 0q�6S   $	��234��6f   .+�5�        $��1��6.   $��0��6;   $ Password=�5�   .   $��Center=�5�   .   ��5�   .   �� $ password��$ BorderBrush�5�      �� 5�      -
   5        $��password��5�      #��[ 5�      $ Пароль��5�      $	��199��5�      $��40��6%   ��5�      �� $ password�.��68   5�      5�      5�      � 5�      $
��Left=�6   $��Bottom=�6.   $��0 -120q�6I   $	��300��6Y   .+�5�      �� -   5        $
��back��5�       ) %MaterialDesignFlatSecondaryDarkButton#��[ 5�      +	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 20��5�      $��40��5�      $��80��6%   $
��Left=�5�      $
��40 0q�5�      .��5�   8   
Назад5�      �� 5�      -   5        $��companyStore��5�      #��[ 5�      $ 20��5�      $��40��5�      $	��120��6%   $��Right=�5�      .��5�   H   Сохранить5�      5�      5�      5�      5�      