   M S B A M L   `   `   `  ����  app_Spaceman_Warehouse'    !app_Spaceman_Warehouse.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5   	   -   5          �Name$#  Spaceman_industries_warehouse��5   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � AllowsTransparency . .��5      � .+�5   
   �� -   5        $��wrapper��5      ���	#FF008BFF$��2q�68   ��5	      �� 5
       �� Color$ White��6"    �� Opacity$ 0Q�60   ._�5      ]� ��. .+�5      �� -   5        $��header��5      $	��Top=�6+   $��90��6@   $��Stretch=�6L   $��Stretch=�6h   .+�5      ]� ��. .+�5      �� $��Right=�6$   $��90��6;   $	��120��6G   $��Stretch=�6S   $��Right=�6o    �� Padding$ 0,5,0,0q�6�    � IsSharedSizeScope . �� 5      -   5        	 ��Name$	 minimizebtn��5   $   $��30��69   $��30��6E   $��19,0,1,0q�6P   ��5      �� 5       
 �� ImageSource$)
 #Resources/minimize_-mouse_leave.png��6+    j� Stretch$ Uniform=�6]   5   3    �� 5      -   5        $	 maximizebtn��5   $   $��30��69   $��30��6E   $��0,0,1,0q�6P   ��5      �� 5       $)
 #Resources/maximized_mouse_leave.png��6+   $ Uniform=�6]   5   3    �� 5      -   5        $	 closebtn��5   $   $��30��66   $��30��6B   ��5      �� 5       $%
 Resources/close_mouse_leave.png��6+   $ Uniform=�6Y   5   3   5      �� 5      ���	#FF008BFF$��36(�6;   $��Stretch=�6I   $
��Left=�6f   $��10,0,0,0q�6�   $��77��6�   $	��858��6�   �� 5      $
��Left=�6$   $��Stretch=�6?   $	��858��6[   $��77��6g   ��5      �� 5        $#
 Resources/spaceman_header.png��6+   5#       5$      5%      5&      ]� 5(      -   5        $��footer��5(      $��Bottom=�6*   $��40��6B   $��Stretch=�6N   $��Stretch=�6j   ���	#FFFFFFFF.+�5)      �� $��Right=�6    $	��180��67   $��Center=�6C   $��14(�6^   $ 0q�6l   ���	#FFF7F7F7$��Center=�6�   $��0,0,10,0q�6�   Spaceman-Industries@20156�   �� 5*      $
��Left=�6    $��70��66   $��14(�6A   $��Center=�6O   $��Right=�6j   $ 15,0,0,0q�6�   ���	#FFFDFDFD
status :6�   �� 5+      -   5        $��status_content��5+       $��Center=�6O   
�������6}   5,      ]� 5-      -	   5        $��content��5-   1   ��. .+�5.      �� -
   5        $��border_top_content��5.       $	��Top=�6:   $��1��6O   $��0��6Z   $��Right=�6d   ��5/      �� 50      $ 	#FF008BFF��6.   6B   52      �� 53      -   5        $��border_bottom_content��53       $��Bottom=�6=   $��1��6U   $��0��6`   $
��Left=�6j   ��54      �� 55      $ 	#FF008BFF��6.   6B   57      �� 59      -   5        $��content_control��59   !   $	��Top=�68   $
��Left=�6M   ��5:      �� 5;      $'
 !Resources/spaceman_background.png��6)   $	 0.7Q�6Y    j� 
AlignmentX$ Right=�6g    j� 
AlignmentY$ Bottom=�6z   $ Uniform=�6�    j� TileMode$
 Tile=�6�   5=      5>      5?      5@      5B       � 	Resources 5H         window_open g� RepeatBehavior �� 
TargetName �� TargetProperty	 �� To g� 	BeginTime g� Duration �� EasingFunction2  ,System.Windows.Media.Animation.QuadraticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode W� From	 W� To W� EasingFunction �� From  window_close  content_fading_in R� KeyTime  System.Windows.Visibility   Hidden R� Value   Visible��%�  &	        &	 `    &	 �    �� 5I   
   $ 1x��6)   .��5J      �� $ footer��6   $5 /(StackPanel.Background).(SolidColorBrush.Color)�6=   $ 	#FFFFFFFFX�6�   $ 0:0:0:0X�6�   $ 0:0:0:0D�6�    5K        5L      $ 	EaseInOut=�6$   6=   5N      W� 5O      $ border_top_content��6   $ Width�6I   $ 0X�6k   $
 1280X�6t   $ 0:0:0X�6~   $ 0:0:0.7D�6�    5P        5Q      $ EaseIn=�6$   6:   5S      W� 5T      $ border_bottom_content��6   $ Width�6L   $ 0X�6o   $
 1280X�6x   $ 0:0:0X�6�   $ 	0:0:0:0.7D�6�    5U        5V      $ EaseIn=�6$   6:   5X      �� 5Y      $ footer��6   $5 /(StackPanel.Background).(SolidColorBrush.Color)�6=   $ 	#FFFFFFFFX�6�   $ 	#FF008BFFX�6�   $ 	0:0:0:0.7X�6�   $ 	0:0:0:0.7D�6�    5Z        5[      $ 	EaseInOut=�6$   6=   5]      5^      �� 5`   
   $ 1x��6*   .��5a      W� $ border_top_content��6   $ Width�6I   $ 0X�6l   $ 0:0:0X�6s   $ 	0:0:0:0.7D�6�    5b        5c      $ EaseIn=�6$   6:   5e      W� 5f      $ border_bottom_content��6   $ Width�6L   $ 0X�6n   $ 0:0:0X�6u   $ 	0:0:0:0.7D�6�    5g        5h      $ EaseIn=�6$   6:   5j      5k      �� 5m   
   .��5n      W� $ content_control��6   $ Opacity�6F   $ 1X�6j   $ 0X�6s   $ 0:0:0:0X�6z   $ 0:0:0:0D�6�    5o        5p      $ 	EaseInOut=�6$   6=   5r      T� 5s      $ content_control��6,   $ 
Visibility�6T   ..�5t      i� $ 0:0:0:0��6)   # Z 6;   5u      5v      T� 5w      $ content_control��6,   $ 
Visibility�6T   ..�5x      i� $ 	0:0:0:0.6��6)   # Z 6=   5y      5z      W� 5{      $ content_control��6   $ Opacity�6F   $ 0X�6j   $ 1X�6s   $ 	0:0:0:0.7X�6z   $ 	0:0:0:0.5D�6�    5|        5}      $ 	EaseInOut=�6$   6=   5      5�      5�      ��5�      �� 5�   
   $ White��6   5�      