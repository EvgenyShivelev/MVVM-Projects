   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5   	       MVVM.Views.RecipeCardN   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVM.Views     5   	     � Title$  
RecipeCard��5   	   $��242.334��6   $��454.001��6-    � 
ResizeMode$ NoResize=�6=   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��224* �6   �� 5      $
��134* �6   �� 5      $	��91* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��4* �6   �� 5      $��2* �6   .+�5   
   �� $��3��63   $��12(�6G   $
��Left=�6U   $��Center=�6w   $��102,10,68,18q�6�   {�6   �� *	isEnabled+��6�   �� *CurrectRecipe.Name+ �� Mode$ TwoWay=�6�   � 5   
   $��1��6   $��1��6   $��3��6-    5      �� 5      $��9* �6#   �� 5       5      �� 5      �� 5      .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ steps��5"      $��2��6&      AutoGenerateColumns .  $��	19,-7,1,0q�6�   ��6S   ��  �� Path$
 Text�$ TwoWay=�   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 Шаг��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� $ StepId�$ TwoWay=�  5%      	 . $
 Действие��6;    6M   �� $ StepDescription�$ TwoWay=�5'      5*      � 5-   
   $��2��6   $��3��6    5.      �� 5/      �� 50      .+�53      �� $��Удалить��61   $��14(�6C   $��
20,4,109,4q�6Q   ��6   �� *	StopRec+6Q   �� 54      $��Добавить��65   $��14(�6I   $��	120,4,1,4q�6W   $��Center=�6j   $��Center=�6�   ��6   �� *
AddNewStep+6�   �� 55      $	��win��61   $��Готово��6H   $��1��6Y   $��4,4,45,4q�6i   ��6   �� *	EndEdit+6i   56      �� 57   
   $��Имя рецепта��6   $
��Left=�6&   $��	20,10,0,0q�6A   $	��Top=�6T    J� RenderTransformOrigin$ -0.491,0.231&�6l   5:      5;      