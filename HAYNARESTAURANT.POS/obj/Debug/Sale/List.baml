   M S B A M L   `   `   `  ����N  JHAYNARESTAURANT.POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HAYNARESTAURANT.POS.SaleHAYNARESTAURANT.POS.Sale  5   	   #    HAYNARESTAURANT.POS.Sale.List   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HAYNARESTAURANT.POS.Sale     5   	     � Title$
  List��5   	   $��507.743��6   $��756.743��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grList��5
      $
��Left=�6#   $	��186��6>   $��
70,146,0,0q�6K   $	��Top=�6_   $	��606��6w      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   .   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Name+6.   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      5      5        5       5      �� 5      5      5      5      �� 5    
   -   5        	 ��Name$	 btnLast��5       $��>|��6"   $
��Left=�62   $��514,398,0,0q�6M   $	��Top=�6b   $��34��6z   $��36��6�   6�   �� 5!   
   -   5        $	 btnFirst��5!      $��|<��6#   $
��Left=�63   $��246,398,0,0q�6N   $	��Top=�6c   $��38��6{   $��36��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   6�   �� 5"   
   -   5        $	 btnNext��5"      $��>��6"   $
��Left=�61   $��474,398,0,0q�6L   $	��Top=�6a   $��36��6y   $
 0.5,0.5&�6�   $��36��6�   6�   �� 5#   
   -   5        $	 btnPrevious��5#      $��<��6&   $
��Left=�65   $��288,398,0,0q�6P   $	��Top=�6e   $��42��6}   $
 0.5,0.5&�6�   $��36��6�   6�   �� 5$   
   -   5         ��Name$ lblPages��5$      $��          Page X of Y��6"   $��Center=�6B   $��330,403,261,0q�6_   $	��Top=�6v   $	��134��6�   �� 5%   
   -   5        $ lblSort��5%      $��Sort By��6!   $
��Left=�63   $��	72,95,0,0q�6N   $	��Top=�6a   $
 0.5,0.5&�6y   $��26��6�   $��62��6�   z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*       �� Angle$ -0.725Q�6&   T� 5+      5,      5.      �� 5/   
   -   5         ��Name$ cboSortOrder��5/      $
��Left=�6)   $��
134,95,0,0q�6D   $	��Top=�6X   $��94��6p   6{   �� 50   
   -	   5        $ 	lblResult��50      $��Search Result : Z Users��6#   $��Center=�6E   $��72,337,465,0q�6b   $	��Top=�6x   $
 	0.5,0.346&�6�   $	��188��6�   �� 51   
   -
   5        $ lblPageSize��51      $��	Page Size��6%   $
��Left=�69   $��140,367,0,0q�6T   $	��Top=�6i   $��86��6�   �� 52   
   -   5         ��Name$ txtboxPageSize��52      $
��Left=�6*   $��22��6E   $��232,371,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $��3��6z   $	��Top=�6�   $��32��6�   6�   �� 53   
   -   5        $ txtBoxSearch��53      $
��Left=�6(   $��22��6C   $��
470,95,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��96��6�   $
 0.508,0.522&�6�   �� 54   
   -   5        $	 	btnSearch��54      $��Search��6$   $
��Left=�65   $��
592,95,0,0q�6P   $	��Top=�6d   $��84��6|   6�   �� 55   
   -   5        $ lblTitle��55      $��Sales��6"   $
��Left=�62   $��	70,25,0,0q�6M   $	��Top=�6`   $	��438��6x   $��34��6�   $��18(�6�   $
��Bold"�6�   57      58      