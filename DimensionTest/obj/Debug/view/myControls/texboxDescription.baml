   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5       DimensionTest5   /DimensionTest.view.myControls.texboxDescription   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      oMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5        � 	Resources  5	         TextBoxBorder �� EndPoint �� 
StartPoint � MappingMode � Color � Offset $  VistaTextBoxWithDescriptionStyle �� 
TargetType �� BasedOn �� Property	 �� Value
 �� 
TargetType,   &Microsoft.Windows.Themes.ListBoxChrome  Name J� SnapsToDevicePixels   
Background   BorderBrush J� IsKeyboardFocusWithin   RenderFocused J� IsMouseOver   RenderMouseOver   BorderThickness ��Name � ToolTip �� Padding ��Name �� ImageSource ��Name �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property  P� Value��%(	  &	        &	 �     7   �� 5
      $
 0,20&�60   $	 0,0&�6@   $ Absolute=�6Q   .��5   
   � $ #ABADB3��6   $
 0.05Q�6'   � 5   
   $ #E2E3EA��6   $
 0.07Q�6'   � 5   
   $ #E3E9EF��6   $ 1Q�6'   5      �� 5   
   " ��6L    69   Z� .�5   
   ��  � ��#	 � ��6'   �� 5   
    � ��#	 � ��6'   �� 5   
    � ��8	   6(   �� 5   
    � ��$	 1q�6,   �� 5   
    � ��$	 1q�6$   �� 5   
    �@J�	AllowDrop	 . 6&   �� 5   
    � ��$		 100��6%   �� 5   
    �@�FocusVisualStyle	 6-   Z� �� 5   
    � ��	 5      �� 5      "
 ��6&   .R�5        $ Bd��6X    . # z��5   =   # z��5   =   # z 5   =   # z 5   =   $ 0,0,0,2q�5    =   ._�5!      � $
��Auto��6   $
��Auto��6,   .+�5#   "   �� $ descriptionTextBlock��6[   $y�Hidden=�6,   $
��Left=�6@   $	��Top=�5$   ,   $��Italic$�6D   ���	#FF7E7E7E#��z 5%   ,   $
��Wrap=�6M   $��17,0,0,0q�6a   # z��6s   ]� 5&   "   .+�5(   &   �� $ 	imageFind��6-   $
��Left=�6A   $��16��6W   $��16��6b   $
��Left=�6n   $��0,0,0,0q�5)   -   $��Segoe UI Symbol)�6H   $y�Visible=�6f   
���������6�   �� *Commandtexbox+��5*   &   �� 5+   *   $F @pack://application:,,,/Resources/Images/ic_search_black_24dp.png��65   5-   #   �� 5.   &   $ PART_ContentHost��6p   # z 64   $��17,0,0,0q�6�   �� 5/   &   $ 
imageClose��6-   -   5        $��Right=�5/   A   $��16��6X   $��16��6c   $��Right=�6o   $��0,0,0,0q�6�   $	��2,0q�50   -   $	��3,0q�6;   $��Segoe UI Symbol)�6H   $y�Visible=�6f   
���������51   &   �� 52   *   $E ?pack://application:,,,/Resources/Images/ic_close_black_16dp.png��65   54   #   55      56      57       58      ]� 59       5:      �� 5;   "    � ��$  ��6<   �� 5<   "    �@J�	IsFocused .  6A   ./�5>      �� $ descriptionTextBlock��6;    � y�$	 Visible=�6]   �� 5?      $ Bd��6@    �@ BorderThickness$	 0,0,0,0q�6P   5@      P� 5A       � ��$   ��62   . �5B   "   �� $ 
imageClose��6?    � y�$	 	Collapsed=�6W   5C      P� 5D       � {�  .  . �5E      �� $ Bd��6;   #	 � ��6K    �@ 
Background�� 5F      #	 � ��6;    � ��5G      5I      5K      5L      5M      .��5N      � -   5        ! �Name$
! grd1��5N      .+�5O   
   �� -   5        " ��Name$
" tbx1��5O      #��[ 6     6Z   �� *WatermarkText+��6|   �� *TextDescription+# �� Mode$# TwoWay=�5P      5Q      