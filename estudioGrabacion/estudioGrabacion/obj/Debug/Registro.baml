   M S B A M L   `   `   `  ����K  GestudioGrabacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:estudioGrabacionestudioGrabacion  5   	       estudioGrabacion.Registro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   *localclr-namespace:estudioGrabacion  5   	     � Title$  Registro��5	   	   $	��450��6   $	��800��6'   $��Old English Text MT)�5
   	   .��5      � .+�5   
   � 
���   �$��80��6"   $	��Top=�6.   .+�5      �� $��imagenes/giphy.gif��6   $��80��60   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ imagenes/giphy.gif��6<      RepeatBehavior$ Forever��6r   $��Center=�6�   $	��Top=�6�   5      � 5   
   $��	0,100,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��0��6!   $��Usuario:��61   $��5q�6D   $��Old English Text MT)�6O   �� 5      -   5         ��Name$
 user��5      $��0��6$   $��1��61   $��5q�6A   $��Old English Text MT)�6L   �� 5!      $��1��6   $��0��6!   $��Correo:��61   $��5q�6C   $��Old English Text MT)�6N   �� 5"      -   5        $ correo��5"      $��1��6&   $��1��63   $��5q�6C   $��Old English Text MT)�6N   �� 5$      $��2��6   $��0��6!   $��Contraseña:��61   $��5q�6G   $��Old English Text MT)�6R   G� 5%      -   5         G�Name$ contra��5%      $��2��6*   $��1��67   $��5q�6G   $��Old English Text MT)�6R   �� 5'      $��3��6   $��0��6!   $��
Teléfono:��61   $��5q�6E   $��Old English Text MT)�6P   �� 5(      -   5        $ telefono��5(      $��3��6(   $��1��65   $��5q�6E   $��Old English Text MT)�6P   �� 5*      -   5        $��4��5*      $��1��6"   $��Registrarse��62   $��5q�6H   $
��10,5q�6S   $��Old English Text MT)�6z   �� 5,      -   5        $��5��5,      $��1��6&   $��5q�66   $+��%Ya tienes una cuenta? Inicia sesión.��6A   $��	Underline{�6m   
����  �6�   �� 5-      -   5         ��Name$ correcto��5-      $��6��6*   $��1��67   $��5q�6G   $!��Se creo la cuenta con exito��6R   $��Center=�6u   
���W�.�$y�Hidden=�6�   �� 5.      -   5        $ 
incorrecto��5.      $��6��6,   $��1��69   $��5q�6I   $ ��Faltan campos por rellenar��6T   $��Center=�6v   
���  ��$y�Hidden=�6�   5/      50      51      