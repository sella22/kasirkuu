   M S B A M L   `   `   `  ����B  >Kasirku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KasirkuKasirku  5   	       Kasirku.tampilBarang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kasirku     5   	     � Title$  tampilBarang��5   	   $	��547��6   $	��984��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�6\    � WindowStyle$
 None=�6r   .��5	      � .+�5
   
   � $
��Left=�6   $	��547��6*   $	��Top=�67   $	��180��6O   $��0,0,0,-0.333q�6[   ���#0000806q   � 5   
   $
��Left=�6   $	��104��6*   $��
180,0,-1,0q�67   $	��Top=�6K   $	��805��6c   ���#000080.+�5      �� -   5         ��Name$ textBlock_Copy��5      $��293,25,279,0q�60   $
��Wrap=�6F   $��Aplikasi Kasirku��6Z   $��Center=�6r   $��
Constantia)�5      
�������$��30(�6C   $	��Top=�6R   $	��233��6j   5      � 5   
    � RowDefinitions 5      �� 5      $	��200 �6    �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��322* �6#   �� 5      $
��199* �6#   �� 5      $
��123* �6#   �� 5      $
��322* �6#   .+�5      � $��1��6   $��3��6#   $��0,0,321.666,0q�67   .+�5      � $��25q�6   $	��120��6#   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�6:   $	��Top=�6V   $��10 30q�6n   5      5      5       � 5!      $��3��6   $��0.334,0,-0.334,0q�6#   .+�5"      � $��25q�6   $	��120��6#   .+�5#      �� $ 
Horizontal=�6!   $��Right=�6:   $	��Top=�6V   $��10 30q�6n   5$      5%      5&      � 5'      $��3��6   $��4��6$   $��Center=�68   $	��772��6U   $��202,116,10,-0.8q�6a    5(      �� 5)      $
��181* �6'   �� 5*      $
��109* �6'   .+�5,      ,� $��
0,70,10,96q�6,   $��2��6@   .��5-      /� .T�5.      J� J� 5/      .*�6$   .*�50      �� .F�51   "   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrd2��52   h   $	��717��51   ,   $	��Top=�6S   	   AutoGenerateColumns	 .  
 �� SelectedValuePath$
 Id��6�    �� SelectedIndex$ 0��6�   $	��232��52   +      CanUserAddRows .  ��68   ��    Columns 53   &   0  *System.Windows.Controls.DataGridTextColumn  54   *   ,  &System.Windows.Controls.DataGridColumn   Header$ 	Id Barang��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6P   �� *Id+  55   *   $ Nama Barang��6=    6R   �� *nama_barang+  56   *   $ Harga��6=    6L   �� *harga_barang+  57   *   $ Jumlah��6=    6M   �� *jumlah_barang+4  .System.Windows.Controls.DataGridTemplateColumn  58   *      HeaderTemplate 59   .   �� 5:   2   .R�5;   6   �� $
��Aksi��6@   5<   3      CellTemplate 5>   .   �� 5?   2   .R�5@   6   �� $ Vertical=�6A   .+�5A   :   ��  ��Name$ btnHapus��6A   -   5        $��Hapus��5A   S   6c   5B   7   5C   3   5E   +   5G   #   5H      5I      5J      5K      �� 5L      5M      �� 5N      -   5        $ judul��5N      $��226,0,181,0q�6+   $
��Wrap=�6@   $��Halaman Data Transaksi��6T   $��Center=�6r   $��
Constantia)�6�   
���   �$��30(�5O   /   $	��Top=�6>   $	��365��6V   $��2��6b   5P      �� 5Q      -   5        $ kembali��5Q      $��Kembali��6&   $
��Left=�68   $��10,68.667,0,0q�5R      $	��Top=�60   $	��154��6H   $��35��6T   
�������$��21.333(�6s   $��Century Gothic)�5S      
���   �$��2��6_   ��6H   Z� 6l   �� 5T      -   5        $ 	btnTambah��5T      $��Tambah Data��6(   $
��Left=�6>   $��10,10.4,0,0q�5U      $	��Top=�6.   $	��154��6F   $��35��6R   
�������$��21.333(�6r   $��Century Gothic)�5V      
���   �$��2��6_   ��6H   Z� 6l   5W      5X      5Y      