   M S B A M L   `   `   `  ����H  DDimensionTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:DimensionTest.view.myControlsDimensionTest.view.myControls  5   	       DimensionTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =local+clr-namespace:DimensionTest.view.myControls     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��950��6)   .��5      � -   5         �Name$
 grd1��5      $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��5 �6   �� 5
      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   5   /DimensionTest.view.myControls.texboxDescription  -   5          Name$ datatext��5   ?   $��0��6"   $��0��62      WatermarkText$ 
Enter text��5         Commandtexbox 68   ��  �� Path$ RequestCommand� �� Mode$ TwoWay=�	   TextDescription	 6r   �� *
CurentText+$ TwoWay=��� 5   
   -   5        
 ��Name$
 ListViewCompiler��5      $��1��6V   $��0��6f   $��Stretch=�6s   $
��auto��6�   $��Stretch=�6�   $
��auto��6�   ��6-   �� *result.PartyList+ �� View 5      �� 5      .P�5      �� $��Список��6'    �� Width$	 100��67   5      5      �� 5   
   -   5         ��Name$ 	getResult��5   .   $��0��6   $��2��6!   $,��&Получить список фирм��6A   $��Bottom=�6`   5      5       