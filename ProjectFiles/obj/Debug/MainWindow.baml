   M S B A M L   `   `   `  ����L  HPracaInżynierska, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PracaInżynierskaPracaInżynierska  5   	   S.clr-namespace:PracaInżynierska.MVVM.ViewModel PracaInżynierska.MVVM.ViewModel  5   	   "    PracaInżynierska.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PracaInżynierska     5   	   D	viewModel.clr-namespace:PracaInżynierska.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   ���#272537���#272537 � AllowsTransparency .   � DataContext 5      3  -PracaInżynierska.MVVM.ViewModel.MainWindowVM  5   
   .��5      �� ���#272537 �� CornerRadius$ 10��6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   5      �� 5      5       � RowDefinitions 5      �� 5      $��80 �6    5       �� 5!      5#      .+�5%      �� $��2��6   
�������$��2��5'      �� 5(      $��2��6   $��0��5)      $��Bottom=�5*      $��Stretch=�5+      
�������$��2��5-      �� 5.      $��ZMDesk��6   $��Center=�5/      $
��Left=�50      
�������$��22(�52      $��20,0,0,0q�53      �� 54      $��1��6   $
��Left=�55      y�54   &   �� *
isHidden+   BoolToVisibility �� 	Converter# [   �� Mode$ TwoWay=�.+�56      	� $��Główna��6   $��50��57      $	��198��58      $
��Left=�59      
�������$��14(�5;        
MenuButton#��[ 5<      ��5=      �� *GlownyViewCommand+	� 5>      $��Użytkownik��6   $��50��5?      $	��198��5@      $
��Left=�5A      
�������$��14(�5C      #��[ 5D      ��5E      �� *UzytkownikViewCommand+	� 5F      $��	Kalendarz��6   $��50��5G      $	��198��5H      $
��Left=�5I      
�������$��14(�5K      #��[ 5L      ��5M      �� *KalendarzViewCommand+	� 5N      $��	Incydenty��6   $��50��5O      $	��198��5P      $
��Left=�5Q      
�������$��14(�5S      #��[ 5T      	� 5U      $��Raporty��6   $��50��5V      $	��198��5W      $
��Left=�5X      
�������$��14(�5Z      #��[ 5[      5\      �� 5e      $��1��6   $��1��5f      $��10q�5g      ��5h      �� *CurrentView+5i      5k      5l      