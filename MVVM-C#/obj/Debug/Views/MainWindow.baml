   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MVVMMVVM  5   	       MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MVVM     5   	     � Title$  Recipes DataBase��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��6* �6   �� 5      $��3* �6   .+�5   
   �� $��2��6   $��
10,55,0,10q�6�   ��6#   ��  �� Path$ Recipe� �� SelectedItem 6I   �� $ CurrectRecipe� �� Mode$ TwoWay=���5      �� 5      .R�5      �� $
��auto��6    ��6.   �� $ 
RecipeInfo�5      5      � 5   
   $��1��6    5      �� 5      �� 5      �� 5       �� 5!      �� 5"       5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      .+�5+      �� $��Добавить��6   $��10,57,10,33q�6L   $��5��6a   $��2��6u   ��6(   �� $ 	addRecipe�6u   �� 5,      $��Изменить��6   $��11,42,10,48q�6~   $��1��6�   $��5��6�   $��2��6�   ��6(   �� $ 
editRecipe���6L   �� $ CurrectRecipe�6�   �� 5-      $��Удалить��6   $��10,27,10,63q�6~   $��2��6�   $��5��6�   $��2��6�   ��6'   �� $ deleteRecipe���6M   �� $ CurrectRecipe�6�   �� 5.      $��По Имени��6   $��-517,10,486,26q�6M   ��6(   �� $ 
sortByName�6M   �� 5/      $��По времени��6   $��-428,10,391,26q�6N   ��6*   �� $ 
sortByDate�6N   51      �� 52   
   $,��&База данных рецептов��6   $
��Left=�6/   $��	10,22,0,0q�6J   $	��Top=�6]   $��1��6u   $��28��6�   $	��244��6�   55      57      