   M S B A M L   `   `   `  ����   LAB01v2    LAB01v2.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$8  2Система управления складом��$	��520��$	��680�� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ MainGrid��$��5q� � ColumnDefinitions �� $
��490* ��� $	��180 �.+��� $��1��.+��� -    ��Name$
 bAdd��$��Добавить��$	��Top=�$��40��$	��140��$��0,0,0,0q� �� 	IsDefault . �� -   $ bDelete��$��Удалить��$	��Top=�$��0,10,0,0q�$��40��$	��140���� $	��Top=�$	��110��$��0,10,0,0q�$	��140��#��� ������ .R��� $��1q����	#FFAEABAB �� CornerRadius$ 2��._��� $��Фильтр��
�������
������� �� Padding$ 5,0,5,0q�.���� .+���  �� Orientation$ 
Horizontal=�.+��� $
��Left=�$��5,5,0,5q�$��Код детали��$��70��$	��Top=��� -   	 ��Name$	 tbFilterDetail��$��Right=�$��5,5,0,5q�$	��Top=�$��40��
 �� TextAlignment$
 Right=�#��� ���� $ 
Horizontal=�.+��� $
��Left=�$��5,5,0,5q�$��Ячейка��$��70��$	��Top=��� -   $	 tbFilterCell��$��Right=�$��5,5,0,5q�$	��Top=�$��40��$
 Right=�#��� ���� $ 
Horizontal=�.+��� -   $ 
bFilterSet��$	��Set��$
��Left=�$��5,5,0,5q�$	��Top=�$��21��$��56���� -   $ bFilterCancel��$��Cancel��$
��Left=�$��5,5,0,5q�$	��Top=�$��21��$��56���� $	��Top=�$��55��$��0,10,0,0q�$	��140��#��� ������ .R��� $��1q����	#FFAEABAB$ 2��._��� $��Сортировка��
�������
�������$ 5,0,5,0q�.���� .+��� $ 
Horizontal=�$��Center=�$��Center=�$��0,5,0,0q�$	��130��.+��� -	    ��Name$ cbSort��$��93��$��Center=�$��1,0,10,0q�
�������.@��� $��ID�� �� 
IsSelected . �� $��Код детали���� $��Ячейка���� $��Количество���� -
   $ bSortDescending��$��16��$��Center=�$��10����Z� ����  �� ImageSource$ /Resources/arrowup.jpg�� j� Stretch$ Uniform=��� -   $ bSortAscending��$��16��$��Center=�$��10����Z� ���� $ /Resources/arrowdown.jpg��$ Uniform=��� $	��Top=�$	��130��$��0,10,0,0q�$	��140��#��� ������ .R��� $��1q����	#FFAEABAB$ 2��._��� $��
Сумма��
�������
�������$ 5,0,5,0q�.���� .+��� $ 
Horizontal=�$��Center=�$��Center=�$��0,5,0,0q�$	��125��.+��� -   $ bSumByOneDetail��$��Right=�$��Сумма по коду��$��24��$��60��$��0,5,0,5q��� -   $	 tbDetailToSum��$��Код детали��$��Right=�$��5,5,0,5q�$��Center=�$��60��$
 Right=�#��� ���� -   $ bSumByDetails��$)��#Сумма по всем кодам��$��24��$	��125��$��0,5,0,5q��� -   $ 
bSumCancel��$��Отмена��$��24��$	��125��$��0,5,0,5q��� -   $ bExit��$��
Выход��$	��Top=�$��40��$	��140��$��0,10,0,0q�&   System.Windows.Controls.DataGrid  -     Name$ dgInventoryList��$y�Visible=�$��Center=�   AutoGenerateColumns .     
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY�$��0��   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value$ Center=�   	CellStyle �� .���  �@��TextAlignment$ Center=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40* 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Id�  $ Код детали��$
 150*  �� $ Detail�  $ Ячейка��$
 150*  �� $
 Cell�  $ Количество��$
 150*  �� $ Quantity�  -   $ dgInventoryListToSum��$y�	Collapsed=�$��Center=� .   . $��0��   $ ID��$	 40*    
FontWeight$
 Bold"� �� $ ID�  $ Detail��$
 150*  �� $ Detail�  $ Quantity��$
 150*  �� $ Quantity�