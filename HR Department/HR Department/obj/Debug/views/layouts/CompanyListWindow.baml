   M S B A M L   `   `   `  ����H  DHR Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HR_Department.views.layoutsHR_Department.views.layouts  5   	   3    -HR_Department.views.layouts.CompanyListWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HR_Department.views.layouts     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5   	     � Icon$  /Assets/img/logo.png��5   	    � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��685��6   $
��1030��6)    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�62   $��15(�5   	    � 	Resources 5       �� MergedDictionaries  OptionBorderStyle �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value  menuButtonStyle �� BasedOn �� 
TargetType �� CornerRadius �� Triggers�� 5   
    5      %  &	       'F� y     'Q� �     &	 %    7���� 5      " ��6.   .�5      �� 	 �@��CornerRadius$
 15��61   �� 5      	 � ��$
 30��6+   5      �� 5      " F�6   .�5      �� 	 � ��
 �#9AA8AE6)   �� 5       	 �@��Stretch$
 Uniform=�6,   5!      �� 5#      " Q�6   .�5$      �� 	 � ��

 ���� 6/   �� 5%      	 � ��
 �#41535A6/   �� 5&      	 � ��$
 Normal"�6/    5(      P� 5)       �@Q�
IsSelected . . �5*      �� 	 � ��
 �#41535A67   �� 5+      	 � ��$

 Bold"�67   5,      5.      �� 50      " ��6,   8   .�51      �� 	 � ��$
 15��6+   �� 52      	 � ��$
 15��6*   �� 53      	 � ��$	
 2,0q�6+   �� 54      	 �@J�Opacity$
 .7Q�6,   �� 55      	 � ��
 56      �� 57      " ��6*   .R�58      �� #��z��59   !   $ 5��5:   !   5<       5=      P� 5>   "    �@J�IsMouseOver . . �5?   &   �� 	 �@J�Opacity$
 1Q�6@   5@   #   5B      5D      5E      5F      .��5H      � ���	#FFEEEEEE � RowDefinitions 5I   
   �� 5J      $	��73* �6   �� 5K      $
��612* �6   .+�5M   
   �� $ 15��5N      ���#EEF3F5._�5P      � $��10q�6    5Q      �� 5R      $
��Auto �6$   �� 5T      $
��Auto �6$   �� 5V      .+�5Z      �  � ColumnDefinitions 5[      �� 5\      $��30 �6+   �� 5]      �� 5^      $
��Auto �6+   .+�5b      �� $��/assets/img/logo.png��5c      $��30��5d      $��30��5e      o� 5h      $��1��5i      $
��10,0q�5j      $��15(�5k      ���#41535A$��Center=�5m      
������ .@�5o      m� $
��20,0q�5p      $��Файл��5q      .@�5s      m� $
��20,0q�5t   !   ���#EEF3F5$��Лицензия��5v   !   m� 5x      $
��20,0q�5y   !   ���#EEF3F5$��Параметры��5{   !   5}      m� 5      -   5        $
��20,0q�5�   !   ���#EEF3F5$��Помощь��5�   !   5�      m� 5�      -   5        $
��20,5q�5�   !   ���#EEF3F5$��
Выйти��5�   !   5�   !   5�      m� 5�      $
��20,5q�5�      ���#EEF3F5$��Меню��5�      .@�5�      m� -   5        $��company��5�   !   $
��20,5q�5�   !   ���#EEF3F5$��Компании��5�   !   5�      m� 5�      -   5        $��vacancy��5�   !   $
��20,5q�5�   !   ���#EEF3F5$��Вакансии��5�   !   5�      5�      5�      �� 5�      $��2��5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� -   5        $��Minimase��5�      $��Right=�5�      
������  � Cursor$
 Hand��5�   M   ��66   Z� .��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�66   $��25��6L   $��25��6W   $
 Hand��6c   ���#0005�      5�      �� 5�      -   5        $��close��5�      $��Right=�5�      
������ $
 Hand��5�   M   ��66   Z� .��5�        $ close=�66   $��25��6C   $��25��6N   $
 Hand��6Z   ���#0005�      5�      5�      5�      5�      5�       � 5�   
   -   5        $��	MainFrame��5�   4   ���	#FFEEEEEE$��1��6'     � NavigationUIVisibility$ Hidden=�6E   5�      5�      5�      