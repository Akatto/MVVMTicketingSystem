   M S B A M L   `   `   `  ����L  HPracaInżynierska, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PracaInżynierska.MVVM.ViewPracaInżynierska.MVVM.View  5      K*clr-namespace:PracaInżynierska.ComponentsPracaInżynierska.Components  6E   ,    &PracaInżynierska.MVVM.View.LoginPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PracaInżynierska.MVVM.View     5      A
components*clr-namespace:PracaInżynierska.Components     6E   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��420 �6   �� 5      $	��150 �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��360 �6   �� 5      $��80 �6   .+�5   
   �� ���#272537$��3��5      $��3��5      5      �� 5   
   $��1��6   $��1��5       J� Clip 5      �� 5       �� RadiusX$ 20Q�6$    �� RadiusY$ 20Q�5   (    �� Rect$ 0,0,420,360�5   (   ��5      �� 5        �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,2&�67   .��5!      �  � Color$ #5bc3ff��6#   	 � Offset$		 0.0Q�63   � 5"      $
 Blue��6#   $	 1Q�60   5$      5&      �� 5'   
   $��1��6   
 �� TextAlignment$
 Center=�5*      $��Center=�5+      $��14(�5,      $
��Bold"�5-      ��5(      ��  �� Path$ 	BladColor���5)      �� $
 Blad�5-      � 5.   
   $��1��6   $��1��5/      $��10q�50       51      �� 52      $��50 �6    �� 53      $��50 �6    �� 54      $��50 �6    �� 55      $��50 �6    �� 56      .+�58      �� $��E-Mail��6   $��0��59      $
��Bold"�5:      
�������$��22(�5<      $
 Center=�5=      $��Bottom=�5>      �� 5?      $��1��6      TextBoxRounded#��[  5@      $	��300��5A      $��40��5B      $
��Left=�5C      $��Center=�5D      $
��Bold"�5E      $��14(�5F      ��5G      �� $ Login� �� Mode$ TwoWay=��� 5H      $��Hasło��6   $��2��5I      $
��Bold"�5J      
�������$��22(�5L      $
 Center=�5M      $��Bottom=�5N      G� 5O      -   5        $��3��5O      $	��300��5P      $��40��5Q      $��Center=�5R      $
��Bold"�5S      $��14(�5T      5U      �� 5W      $��4��6   $��50��5X      $	��150��5Y        RoundedButton#��[ 5Z      $��Zaloguj się��5[      ���#272537
�������$
��Bold"�5^      $��18(�5_      ��5`      �� $ TryLoginCommand�5b      5c      5d      