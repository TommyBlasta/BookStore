   M S B A M L   `   `   `  ����D  @BookStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BookStore	BookStore  5   	       BookStore.UserMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BookStore     5   	     � Title$'  !LibSys - @LoginInfo @Organization��5   	   #��Z��5	   	   #��Z��5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��3* �6   6*   �� 5      6   .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5           TabButtonsStyle#��[  5      
��� � �.��6{   BOOKS6�   �� 5      -   5        #��[  5      
�������.��6{   ITEMS6�   �� 5      -   5        #��[  5      
�������.��6�   SHIFTS6�   �� 5      -   5        #��[  5      
����p��.��6�   USERS6�   5      � 5      -   5         �Name$ DataViewHolder_Grid��5      5      5      � 5   
   -   5        $��ContentEditor_Grid��5      $��1��6    5       �� 5!      6%   �� 5"      6%   5$      � 5%   
   $��1��6   $��1��6   5'      � 5(   
   -   5        $ ContentFilter_Grid��5(      $��1��6   5)      5*      5+      