   M S B A M L   `   `   `  ����H  DHR Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HR_Department.views.layoutsHR_Department.views.layouts  5   	   -    'HR_Department.views.layouts.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HR_Department.views.layouts     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5   	     � Title$  LoginWindow��5
   	   $	��550��6   $	��800��6*    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /Assets/img/logo.png��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��Stretch=�5      $��Stretch=�5      .��5      �� $��/assets/img/hr.jpg��6   5      '  !MaterialDesignThemes.Wpf.PackIcon  5   
   -   5           Kind$ close=�5   "   $��25��6/   $��25��6:    � Cursor$
 Hand��6F   $��5,5,0,0q�5   "   5      � 5   
   $��0��6   $��Stretch=�6   $��Center=�6=    � RowDefinitions 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5%      �� $��0��6    $  MaterialDesignHeadline4TextBlock#��[ 5&      $��Center=�5'      Отдел кадров5)      �� 5*      	 �� Orientation$	 
Horizontal=�6   $��1��62   $��0,20,0,0q�6?   $��Center=�6Q   .+�5+        $��1��6*   $��0��67   $ Account=�5,   *   $��Center=�5.   *   $��	10,5,10,0q�6E   ��5-   *   �� 
 �� ElementName$
 loginBox�� �� Path$ BorderBrush�50      �� 51      -   5        $��loginBox��52       % !MaterialDesignFloatingHintTextBox#��[ 53      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��54      $	��140��55      .��6!   56      57      �� 58      $	 
Horizontal=�6   $��2��62   $��0,20,0,0q�6?   $��Center=�6Q   .+�59        $��1��6*   $��0��67   $	 Key=�5:   *   $��Center=�5<   *   $��	10,5,10,0q�6E   ��5;   *   �� $
 passwordBox��$ BorderBrush�5>      G� 5?      -   5        $��passwordBox��5?      $ Пароль��5@         
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � �$	��140��5C      {�.  ) %MaterialDesignFloatingHintPasswordBox#��[ 5E      5F      5G      �� 5H      $	 
Horizontal=�6   $��3��62   $��	90,20,0,0q�6?   $��Center=�6R   .+�5I      �� $!��Запомнить меня��6   $��Stretch=�64   $
 Hand��6R   6b   �� 5J      -   5         " MaterialDesignFlatDarkBgButton#��[ 5J      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5K      $��40��5L      $��80��6%   $��50,0,0,0q�60   .��5M   ,   
Войти5O      5P      5Q      5R      5S      