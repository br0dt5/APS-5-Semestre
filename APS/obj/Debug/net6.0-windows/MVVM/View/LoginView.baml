   M S B A M L   `   `   `  ����?  ;Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Chat.MVVM.ViewChat.MVVM.View  5   	   9!clr-namespace:Chat.MVVM.ViewModelChat.MVVM.ViewModel  64       Chat.MVVM.View.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Chat.MVVM.View     5   	   7	viewmodel!clr-namespace:Chat.MVVM.ViewModel     64     � Title$  	LoginView��5   	   $	��350��6   $	��400��6(   
������  � AllowsTransparency$
 True��5	   "    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � DataContext 5      (  "Chat.MVVM.ViewModel.LoginViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��220 �6   �� 5      $	��130 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   ��5      �� 5      .��5      �  � Color$ DarkSeaGreen��6#    � Offset$	 0.0Q�68   � 5      $ LightSeaGreen��6#   $	 1.0Q�69   5      5      �� 5   
   $��0��6   .+�5      �� $��Welcome��6   $��	Helvetica)�5       $��50(�5!      $��Medium"�5"      
�������$��Center=�5$      $
��0,40q�5%      �� 5&      
�������$��1q�5'      
�������$��	Helvetica)�5)      $��20(�5*      $��DemiBold"�5+      $��3q�5,      	 J� Opacity$		 0.6Q�5-      $	��340��5/      ��5.      �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=�5/      50      �� 52   
   $��2��6   .+�53      �� 
�������$��Enter��54      $��	Helvetica)�55      $��20(�56      $
��Bold"�57      $��20q�58      $��5q�59      $	��150��5:      ��5;      �� *LoginCommand+5<      5=      5>      