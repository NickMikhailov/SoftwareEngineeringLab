   M S B A M L   `   `   `  ����  LAB01v2    LAB01v2.WindowAdd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Enter Data To Add��5   	   $	��230��6#   $	��420��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R   .��5      � -   5         �Name$ GridWindowAdd��5      $��5q�6"    � RowDefinitions 5	   
   �� 5
      $	��95* �6   �� 5      $	��42* �6   .+�5   
   �� $
��Left=�6   $��	30,30,0,0q�6/   $
��Wrap=�6B   $��Detail Code��6V   $	��Top=�6i   $	��150��6�   $��16��6�   �� 5   
   $
��Left=�6   $��	30,60,0,0q�6/   $
��Wrap=�6B   $��Cell Number��6V   $	��Top=�6i   $	��150��6�   $��16��6�   �� 5   
   $
��Left=�6   $��	30,90,0,0q�6/   $
��Wrap=�6B   $��Quantity��6V   $	��Top=�6f   $	��150��6~   $��16��6�   �� 5   
   -   5         ��Name$ tbDetail��5      $��Right=�6$   $��	0,30,30,0q�6@    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��150��6   #��� ��6�    �� TextAlignment$ Right=�6�   $��18��6�   6�   �� 5   
   -   5        $ tbCell��5      $��Right=�6"   $��	0,60,30,0q�6>   $
 Wrap=�6Q   $	��Top=�6e   $	��150��6}   #��� ��6�   $ Right=�6�   $��18��6�   6�   �� 5   
   -   5        $ 
tbQuantity��5      $��Right=�6&   $��	0,90,30,0q�6B   $
 Wrap=�6U   $	��Top=�6i   $	��150��6�   #��� ��6�   $ Right=�6�   $��18��6�   6�   �� 5   
   -   5         ��Name$ 
detailTrue��5      $��Right=�6$   $��12��6@   $��0,33,9,0q�6L   $	��Top=�6^   $��12��6v   $��UniformToFill=�6�   $ ��/Resources/iconCorrect.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ cellTrue��5      $��Right=�6"   $��12��6>   $��0,63,9,0q�6J   $	��Top=�6\   $��12��6t   $��UniformToFill=�6   $ ��/Resources/iconCorrect.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ quantityTrue��5      $��Right=�6&   $��12��6B   $��0,93,9,0q�6N   $	��Top=�6`   $��12��6x   $��UniformToFill=�6�   $ ��/Resources/iconCorrect.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ detailFalse��5      $��Right=�6%   $��12��6A   $��0,33,9,0q�6M   $	��Top=�6_   $��12��6w   $��UniformToFill=�6�   $��/Resources/iconError.jpg��6�   $y�Hidden=�6�   �� 5   
   -	   5        $ 	cellFalse��5      $��Right=�6#   $��12��6?   $��0,63,9,0q�6K   $	��Top=�6]   $��12��6u   $��UniformToFill=�6�   $��/Resources/iconError.jpg��6�   $y�Hidden=�6�   �� 5   
   -
   5        $ quantityFalse��5      $��Right=�6'   $��12��6C   $��0,93,9,0q�6O   $	��Top=�6a   $��12��6y   $��UniformToFill=�6�   $��/Resources/iconError.jpg��6�   $y�Hidden=�6�   �� 5   
   $��1��6   	 �� Orientation$	 
Horizontal=�6"   $��0,6,0,0q�6;   .+�5      �� -   5        
 ��Name$

 bAdd��5      $	��Add��6#   $
��Left=�61   $��50��6L   $��30,0,0,0q�6X   $��Center=�6j   $	��150��6�    �� 	IsDefault . 6�   �� 5      -   5        $
 bCancel��5      $��Cancel��6&   $
��Left=�67   $��50��6R   $��40,0,0,0q�6^   $��Center=�6p   $	��150��6�   6�   5      5      5       