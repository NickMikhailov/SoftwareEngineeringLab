   M S B A M L   `   `   `  ����   LAB01v2    LAB01v2.WindowAdd   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Enter Data To Add��$	��230��$	��420�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ GridWindowAdd��$��5q� � RowDefinitions �� $	��95* ��� $	��42* �.+��� $
��Left=�$��	30,30,0,0q�$
��Wrap=�$��Detail Code��$	��Top=�$	��150��$��16���� $
��Left=�$��	30,60,0,0q�$
��Wrap=�$��Cell Number��$	��Top=�$	��150��$��16���� $
��Left=�$��	30,90,0,0q�$
��Wrap=�$��Quantity��$	��Top=�$	��150��$��16���� -    ��Name$ tbDetail��$��Right=�$��	0,30,30,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��150��#��� �� �� TextAlignment$ Right=�$��18���� -   $ tbCell��$��Right=�$��	0,60,30,0q�$
 Wrap=�$	��Top=�$	��150��#��� ��$ Right=�$��18���� -   $ 
tbQuantity��$��Right=�$��	0,90,30,0q�$
 Wrap=�$	��Top=�$	��150��#��� ��$ Right=�$��18���� -    ��Name$ 
detailTrue��$��Right=�$��12��$��0,33,9,0q�$	��Top=�$��12��$��UniformToFill=�$ ��/Resources/iconCorrect.jpg��$y�Hidden=��� -   $ cellTrue��$��Right=�$��12��$��0,63,9,0q�$	��Top=�$��12��$��UniformToFill=�$ ��/Resources/iconCorrect.jpg��$y�Hidden=��� -   $ quantityTrue��$��Right=�$��12��$��0,93,9,0q�$	��Top=�$��12��$��UniformToFill=�$ ��/Resources/iconCorrect.jpg��$y�Hidden=��� -   $ detailFalse��$��Right=�$��12��$��0,33,9,0q�$	��Top=�$��12��$��UniformToFill=�$��/Resources/iconError.jpg��$y�Hidden=��� -	   $ 	cellFalse��$��Right=�$��12��$��0,63,9,0q�$	��Top=�$��12��$��UniformToFill=�$��/Resources/iconError.jpg��$y�Hidden=��� -
   $ quantityFalse��$��Right=�$��12��$��0,93,9,0q�$	��Top=�$��12��$��UniformToFill=�$��/Resources/iconError.jpg��$y�Hidden=��� $��1��	 �� Orientation$	 
Horizontal=�$��0,6,0,0q�.+��� -   
 ��Name$

 bAdd��$	��Add��$
��Left=�$��50��$��30,0,0,0q�$��Center=�$	��150�� �� 	IsDefault . �� -   $
 bCancel��$��Cancel��$
��Left=�$��50��$��40,0,0,0q�$��Center=�$	��150��