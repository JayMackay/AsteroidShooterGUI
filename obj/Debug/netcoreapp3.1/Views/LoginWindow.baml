   M S B A M L   `   `   `  ����M  IAsteroidShooterGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AsteroidShooterGUIAsteroidShooterGUI  5   	   #    AsteroidShooterGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AsteroidShooterGUI     5   	   c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��380��6)    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	#FF56A464��6'    � Offset$	 0.0Q�69   � 5      $ 	#FF020236��6'   $ 1Q�69   5      5      �� 5      $��Center=�6   $	��171��64   .+�5       �� $��Asteroid Shooter��6   $��Light"�5!      $��	helvetica)�5"      $��22(�5#      
�������$��Center=�5%      $��	0,110,0,0q�68   �� 5&      $��/Images/Logo.png��6   $��80��62   $��
0,-152,0,0q�6=   $��80��6Q   5'      �� 5*      -   5         ��Name$ errormessage��5+      $��	Helvetica)�5*      $��Center=�5,      $��20��5-      $��	0,170,0,0q�5.      $	��Top=�5/      	 J� OpacityMask
	 �<�����	#FFE5572C51      �� 54      $��1��6   .+�55      �� 
 �� Orientation$
 
Horizontal=�6   .+�56      �� -   5         ��Name$ usernameText��56      $��	Helvetica)�57      $��Light"�58      $��Username��59      $��20(�5:      $��Center=�5;      
�������
������ $��0q�5>      $	��235��5?      $
��Left=�5@       J� Opacity$	 0.5Q�5A      $��25��5B      $��63,0,0,0q�5C      .  (MahApps.Metro.IconPacks.PackIconMaterial  5D         Kind$ Account=�61   $��Center=�5E      $��Center=�5F      
�������5G      5H      �� 5I      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 5L      $
 
Horizontal=�6   $��0,20,0,0q�66   .+�5M      G� -   5         G�Name$ passwordText��5M   "   $��	Helvetica)�5N      $��Light"�5O       G� Password$ Password��5P      $��20(�5Q      $��Center=�5R      
�������
������ $��0q�5U      $	��235��5V      $
��Left=�5W      $	 0.5Q�5X      $��25��5Y      $��63,0,0,0q�5Z        5[      $ TextboxPassword=�61   $��Center=�5\      $��Center=�5]      
�������5^      5_      �� 5`      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 5c      $
 
Horizontal=�6   $��0,50,0,0q�66   .+�5d      �� -   5        $	��100��5d      $��40��6)   $��LOGIN��65   $��	60,0,60,0q�6_   �� 5e      -   5        $	��100��5e      $��40��6)   $��REGISTER��65   6H   5f      5h      5i      5j      5k      