   M S B A M L   `   `   `  ����L  HPracaInżynierska, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PracaInżynierska.MVVM.ViewPracaInżynierska.MVVM.View  5      ,    &PracaInżynierska.MVVM.View.Uzytkownik   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PracaInżynierska.MVVM.View     5      .��5
      �� .+�5   
   �� $*��$Informacje o aktualnym użytkowniku:��6   
�������$��28(�5      $
��Left=�5      $��
25,10,0,10q�5      �� 5   
     �� Orientation$  
Horizontal=�6   $��	25,0,0,10q�5      .+�5      �� $	��650��6   $	��100��5      ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,2&�6;   .��5      �  � Color$ White��6'    � Offset$	 0.0Q�65   � 5      $ 
WhiteSmoke��6'   $ 1Q�6:   5       J� Clip 5      �� 5       �� RadiusX$ 10Q�6(    �� RadiusY$ 10Q�5   (    �� Rect$ 0,0,650,100�5   (   ._�5      � .+�5       �� $  
Horizontal=�6!   .+�5!      �� $��80��6    $��80��5"      $
��Left=�5$      $	��Top=�5%      $��	20,10,0,0q�5&      ��5#      �� 	 �� Path$	 awatar�5&      �� 5'      $  Vertical=�6%   .+�5(      �� $  
Horizontal=�6)   .+�5)   "   �� 
���   �$��24(�5+   $   $��	35,10,0,0q�5,   $   ��5)   ,   �� $
	 Imie�
 �� Mode$
 TwoWay=�5,   $   �� 5-   "   
���   �$��24(�5/   $   $��	10,10,0,0q�50   $   ��5-   ,   �� $	 Nazwisko�50   $   51      �� 52      
���   �$��18(�54   $   $��35,0,0,0q�55   $   ��52   (   �� $	 
RolaString�55   $   �� 56      
���   �$��18(�58   $   $��35,0,0,0q�59   $   ��56   (   �� $	 Email� �� StringFormat$ 
Email: {0}��59   $   5:      5;      5<      5=      5>      �� 5?   
   $  
Horizontal=�6   $��	25,0,0,10q�5@      .+�5A      �� $	��250��6   $	��260��5B      ��5C      �� 5D      $	 0,0&�6*   $	 1,2&�6;   .��5E      � $ White��6'   $	 0.0Q�65   � 5F      $ 
WhiteSmoke��6'   $ 1Q�6:   5G       5I      �� 5J      $ 10Q�6(   $ 10Q�5K   (   $ 0,0,250,260�5L   (   ._�5N      � .+�5O      �� .+�5P      �� $��Informacje kontaktowe:��6$   
���   �$��16(�5R   $   $��
20,10,0,10q�5S   $   �� 5T      $��3��6$   
���   �6/   �� 5U      $��Email:��6$   
���   �$��16(�5W   $   $��	20,10,0,0q�5X   $   �� 5Y      
���   �$��14(�5[   $   $��	35,0,0,10q�5\   $   ��5Y   $   �� $	 Email�$ 
Email: {0}��5\   $   �� 5]      $��Telefon służbowy:��6$   
���   �$��16(�5_   $   $��20,0,0,0q�5`   $   �� 5a      
���   �$��14(�5c   $   $��	35,0,0,10q�5d   $   ��5a   $   �� $	 TelefonSluzbowy�5d   $   �� 5e      $��Telefon prywatny:��6$   
���   �$��16(�5g   $   $��20,0,0,0q�5h   $   �� 5i      
���   �$��14(�5k   $   $��	35,0,0,10q�5l   $   ��5i   $   �� $	 TelefonPrywatny�5l   $   �� 5m      $��Identyfikator��6$   
���   �$��16(�5o   $   $��20,0,0,0q�5p   $   �� 5q      
���   �$��14(�5s   $   $��	35,0,0,10q�5t   $   ��5q   $   �� $	 Identyfikator�5t   $   5u      5v      5w      �� 5x      $	��390��6   $	��260��5y      $��10,0,0,0q�5z      ��5{      �� 5|      $	 0,0&�6*   $	 1,2&�6;   .��5}      � $ White��6'   $	 0.0Q�65   � 5~      $ 
WhiteSmoke��6'   $ 1Q�6:   5       5�      �� 5�      $ 10Q�6(   $ 10Q�5�   (   $ 0,0,390,260�5�   (   ._�5�      � .+�5�      �� .+�5�      �� $%��Pozostali członkowie zespołu:��6$   
���   �$��16(�5�   $   $��
20,10,0,10q�5�   $   �� 5�      $��3��6$   
���   �6/   �� 5�      $	��215��6#   $	��390��60   ��6<   �� *Items+��5�      �� 5�   "   .R�5�   &   � $	��359��6+   $��60��5�   '   $	��Top=�5�   '   $
��Left=�5�   '    � ColumnDefinitions 5�   *   �� 5�   .   $��70 �6?   �� 5�   .   $	��150 �6?   �� 5�   .    � RowDefinitions 5�   *   �� 5�   .   �� 5�   .   .+�5�   *   �� $��0��5�   (   $��2��5�   (   $��5,-5,0,0q�5�   -   $��55��5�   -   $��55��5�   -   ��5�   (   �� $	 awatar�5�   -   �� 5�   *   $��1��5�   0   $��0��5�   0   
���   �$��16(�5�   0   $��Bottom=�5�   0   $��21��6K   ��5�   .   `� 5�   2   $ {0} {1}��6?   .1�5�   6   �� $
	 Imie�6>   �� 5�   6   $	 Nazwisko�6>   5�   3   5�   +   �� 5�   *   $��1��5�   0   $��1��5�   0   
���   �$��16(�5�   0   ��5�   4   �� $	 TelefonSluzbowy�5�   0   �� 5�   *   $��2��5�   0   $��1��5�   0   
���   �$��16(�5�   0   $��	-45,0,0,0q�5�   0   ��5�   4   �� $	 Email�5�   0   �� 5�   *   $��5��64   $	��360��5�   0   
���   �$��2��5�   0   $��3��5�   0   $��0,25,0,0q�5�   0   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      