   M S B A M L   `   `   `  ����  Annies Store"    Annies_Store.Views.Productos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
������   � 	Resources  5
         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  BtnBuscarStyle ��Name  DataGridStyle1&   System.Windows.Controls.DataGrid �� Padding � ColumnDefinitions � RowDefinitions   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter   Name!   Column" ��Name# �� CanContentScroll$ ��Name% �� ScrollableHeight& � Maximum' �� Orientation*( �� #ComputedVerticalScrollBarVisibility) �� ViewportHeight* �� ViewportSize+ � Value, �� Mode- �� ScrollableWidth,. �� %ComputedHorizontalScrollBarVisibility/ �� ViewportWidth=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%�  &	        &	 #     &	 F     &	 i     7   7  7  &	 o    &	     &	 <    &	 _    &	 �    &		 �    &	
 �    &	 �    &	     &	 1    &	 T    7  7  7  7  7  7  &	 C    '  �    '  �    �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6&   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��63   $ 10��6!   #��z��6C   #��z��6o   #��z��6�    . ._�5      �� $	 PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5      
 5       P� 5!       � {� .  . �5"   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5#      P� 5$       �@J�IsMouseOver . . �5%   "   �� $ border��6@   8   � ��6T   5&      P� 5'       �@J�IsKeyboardFocused . . �5(   "   �� $ border��6@   8   � ��6T   5)      5+      5-       5.      ]� 5/       50      �� 51      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 52       �@��IsSelectionActive .  6A   ./�54      ��  �@��SelectionBrush# � /�67   55      57      �� 58   
   .�59      ��  � �� 5:      �� 5;      .R�5<      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5=      5?      5@      �� 5C   
   $ 	#FFDDDDDD��6;   �� 5D   
   $ 	#FF707070��67   �� 5E   
   $ 	#FFBEE6FD��6>   �� 5F   
   $ 	#FF3C7FB1��6:   �� 5G   
   $ 	#FFC4E5F6��6<   �� 5H   
   $ 	#FF2C628B��68   �� 5I   
   $ 	#FFF4F4F4��6=   �� 5J   
   $ 	#FFADB2B5��69   �� 5K   
   $ 	#FF838383��6=   �� 5L   
   " ��6'   .�5M      ��  �@�FocusVisualStyle8   61   �� 5N       � ��8  6+   �� 5O       � ��8  6,   �� 5P       � ��# � ��6+   �� 5Q       � ��$ 1q�60   �� 5R       � ��$ Center=�6;   �� 5S       � ��$ Center=�69   �� 5T       � ��$ 1q�6(   �� 5U       � �� 5V      �� 5W      " ��6&   .R�5X      �� $ border��63   $ 10��6!   #��z��6C   #��z��6o   #��z��6�    . ._�5Y      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5Z      
 5[      P� 5\       �@��IsDefaulted . . �5]   "   �� $ border��6@   # � ��6T    � ��5^      P� 5_       �@J�IsMouseOver . . �5`   "   �� $ border��6?    � �� �#f48fb16S   �� 5a   "   $ border��6@    � �� �#f48fb16T   5b      P� 5c       � �� . . �5d   "   �� $ border��6?    � ��
 �����6S   �� 5e   "   $ border��6@    � ��
 �����6T   5f      P� 5g       � {� .  . �5h   "   �� $ border��6?   8   � ��6S   �� 5i   "   $ border��6@   8   � ��6T   �� 5j   "   $ contentPresenter��6K   8   � ��6i   5k      5m      5o      5p      �� 5s   
   "  6'   .�5t      ��  � ��# � ��6+   �� 5u       � ��# � ��6+   �� 5v       � ��
 �����6,   �� 5w       � ��$ 1q�60   �� 5x        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5y       � �� . 6>   �� 5z       �@��PanningMode$
 Both=�69   �� 5{       �@��IsFlicksEnabled .  67   �� 5|       � �� 5}      �� 5~      "  6&   .R�5      �� $ 	0,0,10,10��6!   #��z��5�   !   #��z��5�   !   #��z��6U   # z��6    . ._�5�      �� $	 DG_ScrollViewer��6+   |�.  ��5�   "   �� 5�   &   " ��66   .R�5�   *   �  5�   .   �� 5�   2   $
��Auto �6C   �� 5�   2   $��* �6C   �� 5�   2   $
��Auto �6C    5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $��* �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� #��Z 65   |�.  ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5�   .   $!  PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z! # Z  �� "  �� 5�   .   $!" PART_ScrollContentPresenter��6E   ## z��6j   $��2��6�   $��1��6�   �� 5�   .   $$ PART_VerticalScrollBar��68   $��2��6X   #& z% 6h   $' Vertical=�6�   $��1��6�   #y�z( 6�   #* z) 6[  + 6�   �� *VerticalOffset+$, OneWay=� �� *TemplatedParent+6[  � 5�   .   $��1��63   $��2��6C    5�   2   �� 5�   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5�   6   $��* �6G   .+�5�   2   �� $$ PART_HorizontalScrollBar��6<   $��1��6^   #& z- 6n   $' 
Horizontal=�6�   #y�z. 6�   #* z/ 6Y  + 6�   �� *HorizontalOffset+$, OneWay=� �� *TemplatedParent+6Y  5�   /   5�   +   5�   '   .��5�   "   �� # z 61   5�      5�      5�      5�       5�      ]� 5�       5�      �� 5�       �@��
IsGrouping . 6:   �� 5�      " �@%�IsVirtualizingWhenGrouping .  6\   ./�5�      ��  � �� .  6F   5�      5�      �� 5�   
   "  6   .�5�      ��  � ��
 �����6+   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��
 �����6+   �� 5�       � ��$ 20��6'   �� 5�       � ��$ Center=�6;   5�      �� 5�   
   "  6    5�      P� 5�       �@ 
IsSelected . . �5�      ��  � �� �#bbdefb63   �� 5�       � ��
 ���� 64   5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#bbdefb63   �� 5�       � ��
 ���� 64   �� 5�       � ��
 �����63   5�      5�      5�      .��5�      �� $ 10��6   
������ ._�5�   
   � -   5        $��GridProductos��5�      .+�5�      � -   5        0 �Name$0 	Contenido��5�      $��0��5�      $��0��5�      $��6��5�      $��8��5�       5�      �� 5�      $��20 �6'   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6'    5�      �� 5�      $��50 �6$   �� 5�      $��20 �6$   �� 5�      $��30 �6$   �� 5�      $��20 �6$   �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6$   .+�5�      �� $��0��6   $��6��5�      $ ��Mantenimiento de Productos��5�      
���   �$��30(�5�      $��Center=�5�      $��Center=�5�      �� 5�      $��Buscar Productos��6   $��Right=�5�      $��Center=�5�      $��1��5�      $��2��5�      $��15(�5�      $��0,0,10,0q�5�      �� 5�      -   5        1 ��Name$1 tbBuscar��5�      2 �� TextAlignment$2 Center=�5�      
������ 
�������$��2��5�      $��2��5�      $��20(�5�      #���  5�      �� 5     -   5        3 ��Name$3 BtnCrearProducto��5     ���#81d4fa���#81d4fa$��4��5     $��2��5     4 � Cursor$
4 Hand��5     $	��150��5     #���  5     .��5
     �� $��Agregar Producto��6    
�������$��15(�5     5       5     -   5        5  Name$5 	GridDatos��5     $��1��5     $��4��5     $��2��5     $��4��5     6   AutoGenerateColumns6 .  
����������#f8bbd0$��15(�5     7   CanUserAddRows7 .  8   CanUserResizeColumns8 . 9   CanUserResizeRows9 .  :   CanUserSortColumns: .  ;   RowBackground
; ���� <   HeadersVisibility$< Column=�5      =   GridLinesVisibility$= 
Horizontal=�5!     >   HorizontalGridLinesBrush> �#f8bbd0#���  5#     ?   Columns? 5$     4  .System.Windows.Controls.DataGridTemplateColumn  5%     ,  &System.Windows.Controls.DataGridColumn@   Header$@ Opciones de Administrador��61   A   Width5	  /System.Windows.Controls.DataGridLengthConverter$	A 245	 5&  -   B   CellTemplateB 5'     �� 5(  "   .R�5)  &   ]� .+�5*  *   �� $3 BtnConsultar��5-  -   -   5        $��	Consultar��5*  1   
�������
�������$��80��5.  -   
������ #���  50  -   $
4 Hand��52  -   ��53  -   �� *
IdArticulo+�� 54  *   $3 BtnModificar��57  -   -   5        $��	Modificar��54  1   
�������
�������$��80��58  -   $
4 Hand��59  -   
������ #���  5;  -   ��5<  -   �� *
IdArticulo+5=  -   �� 5>  *   $3 BtnEliminar��5A  -   -   5        $��Eliminar��5>  1   
�������
�������$��80��5B  -   $
4 Hand��5C  -   
������ #���  5E  -   ��5F  -   �� *
IdArticulo+5G  -   5H  '   5I  #   5K     0
  *System.Windows.Controls.DataGridTextColumn
  5L     $@ Código��6-   $A 50	 5M  )   1  +System.Windows.Controls.DataGridBoundColumnC   BindingC 5N  )   �� *Codigo+
  5O     $@ Nombre��6-   $	A 150	 5P  )   C 5Q  )   �� *Nombre+
  5R     $@ Cantidad��6-   $	A 200	 5S  )   C 5T  )   �� *
Cantidad+
  5U     $@ Precio Unitario��6-   $A *	 5V  )   C 5W  )   �� *Precio+
  5X     $@ Descripción��6-   $A *	 5Y  )   C 5Z  )   �� *Descripcion+5\     5_      � 5b     -	   5        D  �Name$D FrameProductos��5b     $��0��5c     $��0��5d     $��8��5e     $��6��5f     5h     5i     5k     