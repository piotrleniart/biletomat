   M S B A M L   `   `   `  ���� D  @biletomat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:biletomat	biletomat  ;"clr-namespace:biletomat.ViewModelsbiletomat.ViewModels  1clr-namespace:biletomat.Viewsbiletomat.Views      biletomat.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:biletomat     9
viewmodels"clr-namespace:biletomat.ViewModels     /viewsclr-namespace:biletomat.Views     -     � Title$  
MainWindow��$	��768��$
��1024�� � 	Resources  �� DataType    biletomat.ViewModels.Okno1"   biletomat.Views.UserControl1 � DataContext   biletomat.ViewModels.Okno2"   biletomat.Views.UserControl2   MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding	 �� CornerRadius
 �� Triggers P� Property P� Value �� 
TargetName��%�  (��       *, +)(�� %     *, +)&	  J     �� 	temp1��"  .R�   �� �� 	temp2��"  .R�   �� �� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 5q���  � �� �� " ��.R��� $��border��$��1q�$	 4,2q�
�������$	 3��#��z��._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver . . ��� $ border�� � ��
 �   �����  �� ImageSource$ dd.png��.���  � ColumnDefinitions �� $
��508* ��� $
��487* ��� $	��21* � � RowDefinitions �� �� $��9* �.+� � -     �Name$
 Main��$��0��$��1��$��3��$��0,0,0,0q�  � NavigationUIVisibility$ Hidden=�$��20(��� $��0��$��0��$��2��$��1�����	#FF783434$��5�����	#FF783434$��0,48,279,23q��� -   $��	dataiczas��$��0��$��0��$
��Data�����	#FF2A5777$��20(�$��2��$��120,4,367,659q�$��2���� $��0��$��1��$��Język/Language��$��40,4,10,659q�$��20(����	#FF2A5777$��2��$��2���� -   $��POWRÓT��$
��Left=�$��	10,10,0,0q�$	��Top=�$��97��$��32��
����������	#FF1C3C53���	#FF2A5777�� -   $�� ��$
��Left=�$��
222,10,0,0q�$	��Top=�$��97��$��32�����	#FF1C3C53���	#FF1C3C53$��1��#��[  ���� $ pl.png���� -   $�� ��$
��Left=�$��
338,10,0,0q�$	��Top=�$��96��$��32�����	#FF1C3C53���	#FF1C3C53$��1��#��[  ���� $ gb.gif��