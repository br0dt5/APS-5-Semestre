   M S B A M L   `   `   `  ����>  :APS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:APSAPS  5   	   5clr-namespace:APS.MWM.ViewModelAPS.MWM.ViewModel  6)       APS.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:APS     5   	   5	viewmodelclr-namespace:APS.MWM.ViewModel     6)   $	��650��5   	   $
��1200��6   ���#36393F  � WindowStyle$
  None=�5
   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � DataContext 5      %  APS.MWM.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� -   5        $��2��5      ���#6FFF5E._�5"      � $��Stretch=�6   .+�5#      �� $��	EcoSistem��6   $��SemiBold"�5$      �� 5&      $��Right=�6    �� Orientation$ 
Horizontal=�5'      .+�5)      �� -   5        $��20��5)      $��20��6(   $��_��5*      
������ $��0q�5,      $
��Bold"�5-      $��0,0,0,3q�5.      5/      �� 51      -   5        $��20��51      $��20��6(   $	��▢��52      
������ $��0q�54      $
��Bold"�55      56      �� 58      -   5        $��20��58      $��20��6(   $	��╳��59      
������ $��0q�5;      $
��Bold"�5<      $��0,0,0,3q�5=      5>      5@      5B      5D      � 5F   
   ���#10E3A5$��1��5G       5H      �� 5I      $��50 �6    �� 5J      �� 5K      $��60 �6    .+�5N      �� $��Contatos��6   $��Center=�5O      $��Medium"�5P      $��8,0,0,0q�5Q      �� 5S      
������ $��0q�5U      $��1��5V         CardContatos#��[  5W      ��5S      �� *
Contatos+5W      �� 5Y      $��2��6   $ 
Horizontal=�5Z      ���#056FF0.+�5]      ��  �� CornerRadius$ 25��6   $��30��5^      $��30��6$   ���#6FFF5E$��18,0,0,0q�5`      �� 5b      $��Center=�6   .+�5c      �� $��Username��6   
�������$��SemiBold"�5e      $��	0,-5,0,-5q�5f      �� 5h      $��Status��6   
�������$��SemiBold"�5j      $��10(�5k      $��	0,-8,0,-5q�5l      5m      5o      5q      � 5s   
   $��1��6   $��1��5t       5v      �� 5w      $��50 �6    �� 5x      �� 5y      $��70 �6    .+�5|      �� 
���   �$��0,0,0,2q�5}      ._�5~      � $��Stretch=�6   $��8q�5      .+�5�      �� $��	@UserName��6   
�������$
��Bold"�5�      $��5,0,5,0q�5�      $��Center=�5�      �� 5�      $ 
Horizontal=�6!   $��Right=�5�   !   .+�5�      �� $��20��6    $��20��6+    �� BitmapScalingMode$
 Fant=�5�       $��5,0,5,0q�5�       $��/telefonema.png��5�       �� 5�      $��20��6    $��20��6+   $
 Fant=�5�       $��5,0,5,0q�5�       $��/camera.png��5�       5�      5�      5�      �� 5�      
������ $��0q�5�        	ItensChat#��[ 5�      $��8,0,0,0q�5�      $��1��5�      ��5�      �� *SelecionarContato.Mensagens+5�      � 5�      $��2��6    5�      �� 5�      �� 5�      $��90 �6'   .+�5�      �� $��1��6   $��50��5�      $��Mensagem @Username��5�        CaixaMensagem#��[ 5�      $��2��5�      �� 5�      $ 
Horizontal=�6   $��Right=�5�      $��1��5�      $��0,0,16,0q�5�      .+�5�      �� $��20��6   $��20��6'   $
 Fant=�5�       $��5,0,5,0q�5�       $��	/mais.png��5�       �� 5�      $��20��6   $��20��6'   $
 Fant=�5�       $��5,0,5,0q�5�       $��	/send.png��5�       5�      5�      5�      5�      5�      