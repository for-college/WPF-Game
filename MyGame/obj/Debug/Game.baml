   M S B A M L   `   `   `  ����A  =MyGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyGameMyGame  5   	       MyGame.Game   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyGame     5   	     � Title$  Где больше��5   	   $	��450��6   $	��800��6)    � Icon$ 	/more.jpg��65    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\    � Triggers 5	      :� 5
   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/    g� Duration$ 0:0:1D�66   	 �� TargetProperty$	 Opacity�6G   5      5      5      5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��80 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   �� 5       $��50 �6   �� 5!      $��50 �6   �� 5"      $��30 �6   �� 5#      $
��50px �6   .+�5%   
   �� $��more.jpg��6   $��6��6#   $��1��67   �� 5&   
    �� TextAlignment$ Center=�6   $��1��6+   $��2��68   $��2��6I   $��Где больше?��6]   �� 5'   
   -   5         ��Name$ firstNumber��5'      $ Center=�6*   $��3��6A   $��2��6N   �� 5(   
   -   5        $ secondNumber��5(      $ Center=�6+   $��3��6B   $��3��6O   �� 5)   
   -   5        $ rounds��5)      $ Center=�6%   $��2��6<   $��2��6I   $��2��6Y   $�� ��6m   �� 5*   
   -   5        $ currentPlayer��5*      $ Center=�6,   $��Center=�6C   $��2��6^   $��2��6k   $��2��6{   $��Ходит игрок��6�   �� 5,   
   $��2��6   $��4��6"   $��70��6/    �� CornerRadius$ 10��6:   ���	#FFABADB3$��1q�6d   ._�5-      �� -   5         ��Name$ 
buttonLeft��5-   <      SimpleButton#���   6   $��
Слева��6P   $��0q�6u   
������ 6�   5.      �� 5/   
   $��3��6   $��4��6"   $��70��6/   $ 10��6:   ���	#FFABADB3$��1q�6d   ._�50      �� -   5        $ buttonRight��50   <   #���   6   $��Справа��6Q   $��0q�6x   
������ 6�   51      52      53      