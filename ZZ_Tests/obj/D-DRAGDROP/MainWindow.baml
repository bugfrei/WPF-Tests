   M S B A M L   `   `   `  ���� C  ?ZZ_Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ZZ_TestsZZ_Tests      ZZ_Tests.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:ZZ_Tests       � Title$  
MainWindow��$	��450��$	��800��.���  � RowDefinitions �� $	��100 ��� $	��100 ��� $	��100 ���  � ColumnDefinitions �� $	��250 ��� .+��� $��0��$��0��
��� ��� �� Orientation$ Vertical=�.+��� 
�������$��
StackPanel���� 
��� ���$��Vertical���� 
�������
�������$��Button 1���� 
��� ���
�������$��Button 2���� $��0��$��1��
��� ���$ 
Horizontal=�.+��� 
��� E��$��
StackPanel���� 
��� ���$��
Horizontal���� 
��� E��
�������$��Button 1���� 
��� ���
�������$��Button 2��� $��1��$��0��
��� � �.+��� 
������$��	WrapPanel���� 
��� � �
�������$��Button 1���� 
������
�������$��Buton 2���� 
��� � �
�������$��Button 3���� 
������
�������$��Button 4���� 
��� � �
�������$��Button 5���� 
������
�������$��Button 6��]� $��1��$��1��
����  �.+��� 
����ح�$��Button 1��$
��Left=��� 
����  �$��Button 2��$
��Left=��� 
����ح�$��	DockPanel��$	��Top=��� 
����  �
�������$��Button 4��$��Right=��� 
����ح�
�������$��Button 5��$��Bottom=��� 
����  �
�������$��Button 6���� $��2��$��0��
���  ��.+���  �� Left$ 25��
 �� Top$ 25��
���\\��
�������$��Button 1���� $	 185��$ 25��
���  ��
�������$��Button 2���� $	 115��$ 50��
���\\��$��Canvas���� $ 5�� �� Bottom$ 5��
���  ��
�������$��Button 3����  �� Right$ 25��$ 5��
���\\��
�������$��Button 5��A� $��3��$��0��$��2�� A� Rows$ 3��	 A� Columns$	 3��.+��� $��UniformGrid���� -   
 ��Name$
 ListItemList��
���  ��$��List-Item in List���� 
�������$��Button 2���� 
�������$��Button 3���� 
�������$��Button 4���� 
�������$��Button 5���� 
�������$��Button 6��