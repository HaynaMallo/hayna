   M S B A M L   `   `   `  ����N  JHAYNARESTAURANT.POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HAYNARESTAURANT.POS.DeliveryHAYNARESTAURANT.POS.Delivery  5   	   &     HAYNARESTAURANT.POS.Delivery.Add   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HAYNARESTAURANT.POS.Delivery     5   	     � Title$	  Add��5   	   $��430.851��6   $��880.851��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ lblDate��5
      $�� ��6!   $
��Left=�6,   $��	38,10,0,0q�6G   $	��Top=�6Z    J� RenderTransformOrigin$ -2.079,-0.173&�6r   $	��362��6�   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   $��24(�6�   $��42��6�   �� 5   
   -   5         ��Name$ btnAdd��5      $��Add Delivery Item��6!   $
��Left=�6=   $��639,42,0,312q�6X   $	��128��6n   $ 0.169,0.183&�6z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grDeliveryItemList��5      $
��Left=�6/   $	��242��6J   $��
38,106,0,0q�6W   $	��Top=�6k   $	��743��6�      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Delivery Item��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 5   8   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6   �� *MaterialName+68     5      $ Quantity��6%   $	 * 5   4   
 6   �� *
Quantity+64   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $ 	btnUpdate��6%   .��68   Update6@   5      5        5       5      �� 5      .R�5      �� $ btnConfirmDelete��6%   .��6?   Delete6G   5      5      5!      �� 5"   
   -   5        $ btnSave��5"      $
��Save��6"   $
��Left=�61   $��639,364,0,0q�6L   $	��Top=�6a   $	��128��6y   $ 0.169,0.183&�6�   $��26��6�   6�   �� 5#   
   -   5        $ 	btnCancel��5#      $��Cancel��6$   $
��Left=�65   $��491,364,0,0q�6P   $	��Top=�6e   $	��128��6}   $ 0.169,0.183&�6�   $��26��6�   6�   5$      5%      