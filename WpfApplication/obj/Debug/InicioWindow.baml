   M S B A M L   `   `   `  ����  WpfApplication!    WpfApplication.InicioWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Inicio��5   	   $��559.934��6   
���   �$��744.111��6<   $��Shruti)�6L   $��14(�6`    � 
ResizeMode$ NoResize=�6o    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�    � Icon$ img/app.ico��6�   .��5      �  � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��490* �6   .+�5
   
   � ���	#FFF1EEEE � ColumnDefinitions 5      �� 5      $	��72* �6#   �� 5      $	��96* �6#   �� 5      $��8* �6#   �� 5      $
��399* �6#   �� 5      $
��118* �6#   �� 5      $	��45* �6#   .+�5      �� $��1��6   $��Nombre:��6$   $��18(�66   $��Right=�6D   $��Center=�6g   6�   �� 5      -   5        $	��Add��5      $��5��69   ��5      �� 5       �� ImageSource$ img/add199 (1).png��6!    j� Stretch$ UniformToFill=�6B   5      �� 5      -   5        $��	txtBuscar��5   i   $��Center=�6   $��16(�68   $��3��6{   
����  ���6�   Z� 6�   5      �� 5   
   -   5        $��lstPacientes��5      $��1��6'   	 �� View	 5      �� 5      
 �� AllowsColumnReorder
 . .P�5       �� $��Nombre��6%    �� Width$	 370��65    �� DisplayMemberBinding 6A   ��  �� Path$
 Col1��� 5!      $��Registro��6%   $ 60��67    6B   �� $
 Col2��� 5"      $��Correo��6%   $	 150��65    6A   �� $
 Col3��� 5#      $��	Teléfono��6%   $	 110��67    6C   �� $
 Col4�5$      5&      5'      5(      