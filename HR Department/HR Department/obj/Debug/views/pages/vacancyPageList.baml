   M S B A M L   `   `   `  ����H  DHR Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HR_Department.views.pagesHR_Department.views.pages  5      /    )HR_Department.views.pages.vacancyPageList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:HR_Department.views.pages     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5      -   5           MaterialDesignBody#���   5
        N� Title$  vacancyPageList��5      .��5      � .+�5   
   � -   5        $��loading��5      $y�Visible=�6   .+�5      �� '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ /Assets/img/loading.gif?�6   $	��250��6N   $	��250��6Z   5      � 5   
   -   5        $��
conentMain��5      $y�Hidden=�6!    � RowDefinitions 5      �� 5      $	��31* �6    �� 5      $
��119* �6    .+�5      � -   5        $	��nav��5      ���#EEEEEE.+�5      �� $	��0,5q�5        �� Orientation$ 
Horizontal=�5!      .+�5$      �� ���#D5E0E5 �� CornerRadius$ 15��5&      $
��15,0q�5'       �� Padding$ 20q�5(      ._�5)      �� 
������ $��0q�5+      $��Center=�5,        ButtonStyle1#���  6?   .��5-      �  � ColumnDefinitions 5.   "   �� 5/   &   $
��Auto �67   �� 51   &   .+�54   "   �� $��30��55   %   ._�56   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PlusCircle=�6>   $��25��6P   $��25��6[    � Cursor$
 Hand��6g   $��5,5,0,0q�57   >   58   '   59   #   �� 5;   "   -   5        $��
addCompany��5B   %   ���#41535A$��SemiBold"�5=   %   $��1��5>   %   	 �� Padding$		 6,0q�5?   %   $'��!Добавить вакансию��5@   %   $
 Hand��5A   %   $��Center=�5D   %   5E      5F      5G      �� 5I      ���#D5E0E5$ 15��5K      $
��15,0q�5L       - )MaterialDesignToolBarMainPanelBorderStyle#��[ 5M      $ 20q�5N      ._�5O      �� 
������ $��0q�5Q      $��Center=�5R      #���  6?   .��5S      �  5T   "   �� 5U   &   $	��300 �67   �� 5W   &   .+�5Z   "   �� $��30��5[   %   $��Right=�5\   %   ._�5]   &     ���#000$ Search=�6P   $��25��6^   $��25��6i   $
 Hand��5^   >   $��5,-5,0,0q�6L   5_   '   5`   #   �� 5b   "   -   5        $��TBox_search��5e   %   $��Center=�5c   %   $	��350��5d   %   5f   %   5h      5i      5j      �� 5l      ���#D5E0E5$ 15��5n      $
��15,0q�5o      $ 20q�5p      ._�5q      �� 
������ $��0q�5s      $��Center=�5t      #���  6?   .��5u      �  5v   "   �� 5w   &   $
��Auto �67   �� 5y   &   .+�5|   "   �� $��30��5}   %   ._�5~   &     $
 Post=�6>   $��25��6J   $��25��6U   $
 Hand��6a   $��5,5,0,0q�5   >   5�   '   5�   #   �� 5�   "   -   5        $��title��5�   %   ���#41535A$��SemiBold"�5�   %   $��1��5�   %   $		 6,0q�5�   %   $��Вакансии��5�   %   $��Center=�5�   %   5�      5�      5�      �� 5�      ���#D5E0E5$ 15��5�      $
��15,0q�5�      $ 20q�5�      $	��220��5�      ._�5�      �� 
������ $��0q�5�      $��Center=�5�      #���  6?   .��5�      �  5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   .+�5�   "   ]� .+�5�   &   �� ���#41535A$��1��5�   )   $
��Bold"�5�   )   $��20(�5�   )   $		 6,0q�5�   )   $��Вакансий |��5�   )   $��Center=�5�   )   �� 5�   &   -   5        $��_Count_Base_title��5�   )   ���#673AB7$
��Bold"�5�   )   $��1��5�   )   $		 6,0q�5�   )   $��0��5�   )   $��20(�5�   )   $��Center=�5�   )   5�   #   5�      5�      5�      5�      5�      � 5�      -	   5        $��conent��5�      $��1��6!   .+�5�      �� 
����������#CBD7DC$��1q�5�      $ 15��5�      $��1��5�      $ 10q�5�      ._�5�      �  5�      �� 5�      $
��Auto �6,   �� 5�      $	��21* �6,   �� 5�      $
��289* �6,   .+�5�      �� ���#D5E0E5$ 15��5�      $��40��5�      ._�5�      �  5�   "   �� 5�   &   $��* �67   �� 5�   &   $��* �67   �� 5�   &   5�      5�      �� 5�      
������ $��0q�5�      $��1��5�      $��Stretch=�5�      $��2��6B   5�      &   System.Windows.Controls.DataGrid  5�      -
   5        $��DBlist��5�   #   
   AutoGenerateColumns
 .     
IsReadOnly . ��. $
��Auto=�5�   #   $
��Auto=�5�   #      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ #��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ id�  5�   "   $' !Название вакансии��65   $ * 6P    5�   5   �� $ titleVacancy�  5�   "   $  Ответственный��65   $ * 6L    5�   5   �� $ responsible�  5�   "   $ Компания��65   $ * 6G    6Q   �� $ 
id_company�4  .System.Windows.Controls.DataGridCheckBoxColumn  5�   "   $ Активность��69    6M   �� $ isActive�4	  .System.Windows.Controls.DataGridTemplateColumn	  5�   "   $ * 69    	  CellTemplate 5�   &   �� 5�   *   .R�5�   .   �� -   5        $��Подробнее��5�   5   6I   5�   +   5  #   5     5     5     5     5     5
     5     