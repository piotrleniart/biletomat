   M S B A M L   `   `   `  ����D  @biletomat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:biletomat	biletomat  5   	   ;"clr-namespace:biletomat.ViewModelsbiletomat.ViewModels  5   	   1clr-namespace:biletomat.Viewsbiletomat.Views  5   	       biletomat.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:biletomat     5   	   9
viewmodels"clr-namespace:biletomat.ViewModels     5   	   /viewsclr-namespace:biletomat.Views     5   	   -   5          � Title$  
MainWindow��5
   	   $	��768��6   $
��1024��6)    � 	Resources 5       �� DataType    biletomat.ViewModels.Okno1"   biletomat.Views.UserControl1 � DataContext   biletomat.ViewModels.Okno2"   biletomat.Views.UserControl2   MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding	 �� CornerRadius
 �� Triggers P� Property P� Value �� 
TargetName��%�  (��       5   &   *, +)(�� J     5   &   *, +)&	  �     �� 5   
   	temp1��"  6&   .R�5         6!   �� 5      �� 5   
   	temp2��"  6&   .R�5         6!   �� 5      �� 5   
   " ��6&   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��1q�5      $	 4,2q�5      
�������$	 3��5      #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       
 5!      P� 5"       �@J�IsMouseOver . . �5#   "   �� $ border��6)    � ��
 �   �6T   5$      5&      5(      5)      5+      ��5,      �� 5-   
    �� ImageSource$ dd.png��6   .��5/      �  � ColumnDefinitions 50   
   �� 51      $
��508* �6   �� 52      $
��487* �6   �� 53      $	��21* �6    � RowDefinitions 55   
   �� 56      �� 57      $��9* �6   .+�5C   
    � -   5          �Name$
 Main��5C      $��0��6   $��1��6.   $��3��6;   $��0,0,0,0q�6O     � NavigationUIVisibility$ Hidden=�6`   $��20(�6�   6�   �� 5L   
   $��0��6   $��0��6!   $��2��61   $��1��6E   ���	#FF783434$��5��6h   ���	#FF783434$��0,48,279,23q�6�   �� 5M   
   -   5        $��	dataiczas��5M   <   $��0��6   $��0��6   $
��Data��6-   ���	#FF2A5777$��20(�6d   $��2��6r   $��120,4,367,659q�6�   $��2��6�   �� 5N   
   $��0��6   $��1��6   $��Język/Language��6-   $��40,4,10,659q�6F   $��20(�6[   ���	#FF2A5777$��2��6�   $��2��6�   �� 5R   
   -   5        $��POWRÓT��5R      $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   $��97��6h   $��32��6�   
����������	#FF1C3C53���	#FF2A57776�   �� 5S   
   -   5        $�� ��5S      $
��Left=�6   $��
222,10,0,0q�67   $	��Top=�6K   $��97��6c   $��32��6}   ���	#FF1C3C53���	#FF1C3C53$��1��6�   #��[  6�   ��5T      �� 5U      $ pl.png��6   5W      �� 5X   
   -   5        $�� ��5X      $
��Left=�6   $��
338,10,0,0q�67   $	��Top=�6K   $��96��6c   $��32��6�   ���	#FF1C3C53���	#FF1C3C53$��1��6�   #��[  6�   ��5Y      �� 5Z      $ gb.gif��6   5\      5a      5b      