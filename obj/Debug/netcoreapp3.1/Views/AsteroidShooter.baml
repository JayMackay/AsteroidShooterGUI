   M S B A M L   `   `   `  ����M  IAsteroidShooterGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AsteroidShooterGUIAsteroidShooterGUI  5   	   (    "AsteroidShooterGUI.AsteroidShooter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AsteroidShooterGUI     5   	   -   5          � Title$  AsteroidShooter��5   	   $	��540��6!   $	��615��6.    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   ��5      �� 5      .��5      �  � Color$ 	#FF56A464��6#    � Offset$	 0.0Q�65   � 5      $ 	#FF020236��6#   $ 1Q�65   5      5      �� 5   
   -   5        $��MyCanvas��5      $
|�True��5   	   .+�5      �� -   5        $��player��5      $��50��5       $��60��5!      
���   � �� Left$	 222��5#      
 �� Top$	 495��5$      �� 5'      -   5        $��	scoreText��5'      $��Score: 0��5(      $��	Helvetica)�5)      $��Regular"�5*      $��20(�5+      
�������
������ $��29��5.      �� 51      -   5        $��
damageText��51      $��	Damage: 0��52      $��	Helvetica)�53      $��Regular"�54      $��20(�55      
�������
������ $��34��58      	 �� Right$	 0��59      $	 478��6   $	��137��60   �� 5<      -   5        
 ��Name$
 TextBlockName��5<      $��	Helvetica)�5=      $��Light"�5>      $��20(�5?      
�������
������ $��24��5B      $��	97,14,0,0q�5C      $	 198��6$   $	��158��66   $ -7��6B   �� 5D      -   5        $
 WelcomeHeading��5D      $��Welcome:��5E      $��	Helvetica)�5F      $��Regular"�5G      $��20(�5H      
�������
������ $��29��5K      $	 198��5L      $ 6��6#   5N      5O      5P      