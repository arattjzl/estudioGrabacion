   M S B A M L   `   `   `  ����K  GestudioGrabacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:estudioGrabacionestudioGrabacion  5   	   !    estudioGrabacion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:estudioGrabacion     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$  Inicio��5	   	    � WindowState$ 	Maximized=�6   $y�Visible=�5
   	   $��Old English Text MT)�5   	   ��5      �� 5   
    �� ImageSource$ imagenes/fongo.jpg��6    j� Stretch$ UniformToFill=�66    j� 
AlignmentX$ Center=�6N    j� 
AlignmentY$ Center=�6b    �� Opacity$	 0.5Q�6v   .��5      � .+�5   
   � .+�5      � 
���   �$	��160��6&   $	��Top=�63   .+�5      �� $��ESTUDIO��6   
�������$��Center=�6=   $
��Left=�6X   $��	300,0,0,0q�6s   $��40(�6�   $��Old English Text MT)�6�   �� 5      $��imagenes/giphy.gif��6   $	��110��64   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ imagenes/giphy.gif��6A      RepeatBehavior$ Forever��6w   $��Center=�6�   $	��Top=�6�   �� 5      $��GRABACI��6   
�������$��Center=�6=   $��Right=�6X   $��	0,0,300,0q�6t   $��40(�6�   $��Old English Text MT)�6�   � 5      $��50��6   $��Bottom=�6#   	 � ColumnDefinitions	 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� -   5        
 ��Name$
 inicio��5      
���   �$��0��6@   $��2,3,3,3q�6P   $��1,1,1,1q�6a   $��24(�6s   $��Old English Text MT)�6�   ��5       �� 5!       �� 
TargetType" ��6.   .R�5"   "   �� 
�������#��z��6<   $��1q�6h    �� CornerRadius$ 3��6|   ._�5#   &   �� $��Inicio��67   $��Center=�6H   $��Center=�6e   $��30��6�   6�   5$   #   5%      5'      �� 5(      -   5        $

 beat��5(      
�������$��1��6>   $��2,3,3,3q�6N   $��1,1,1,1q�6_   $��24(�6�   $��Old English Text MT)�6�   ��5)      �� 5*      " ��6.   .R�5+   "   �� #��z��6)   $��1q�6U   $ 3��6i   ._�5,   &   �� $
��Beat��67   $��Center=�6F   $��Center=�6c   $��30��6~   6�   5-   #   5.      50      �� 51      -   5        $
 estudio��51      
�������$��2��6A   $��2,3,3,3q�6Q   $��1,1,1,1q�6b   $��24(�6�   $��Old English Text MT)�6�   ��52      �� 53      " ��6.   .R�54   "   �� #��z��6)   $��1q�6U   $ 3��6i   ._�55   &   �� $��Estudio��67   $��Center=�6I   $��Center=�6f   $��24��6�   6�   56   #   57      59      �� 5:      -   5        $
 cuenta��5:      
�������$��3��6@   $��2,3,3,3q�6P   $��1,1,1,1q�6a   $��24(�6�   $��Old English Text MT)�6�   ��5;      �� 5<      " ��6.   .R�5=   "   �� #��z��6)   $��1q�6U   $ 3��6i   ._�5>   &   �� $��Cuenta��67   $��Center=�6H   $��Center=�6e   $��30��6�   6�   5?   #   5@      5B      5C      5D      5F      � 5H   
   .+�5I      �� -   5        $
 	registrar��5I      $��Registrarse��6(   $
��Left=�6>   $��1700,178,0,0q�6Y   $	��100��6o   $��30��6{   $	��Top=�6�   $��Old English Text MT)�6�   �� 5J      -   5        $
 	inicioSes��5J      $��Iniciar Sesion��6(   $
��Left=�6A   $��1550,178,0,0q�6\   $	��100��6r   $��30��6~   $	��Top=�6�   $��Old English Text MT)�6�   5K      � 5M   
   
���   �$��Bottom=�6"   $��40��6=   	 5N      �� 5O      �� 5P      �� 5Q      �� 5R      �� 5S      �� 5T      �� 5U      �� 5V      .+�5Y      �� -   5        
���   �$��3��5Y   (   .��5Z      �� $��imagenes/instagram.jpg��6   $��5��68   $��Uniform=�6H   $��30��6Z   5[      �� 5\      -   5        
���   �$��2��5\   (   .��5]      �� $��imagenes/twitter.jpg��6   $��Uniform=�66   $��30��6H   5^      �� 5_      -	   5        
���   �$��5��5_   (   .��5`      �� $��imagenes/facebook.jpg��6   $��Uniform=�68   $��30��6J   5a      �� 5b      -
   5        
���   �$��4��5b   )   .��5c      �� $��imagenes/telefono.jpg��6   $��4��67   $��Uniform=�6G   $��30��6Y   5d      5f      5g      5h      