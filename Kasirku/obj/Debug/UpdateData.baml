   M S B A M L   `   `   `  ����B  >Kasirku, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KasirkuKasirku  5   	       Kasirku.UpdateData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kasirku     5   	     � Title$  Kamar��5   	   $	��750��6   $	��800��6$   .��5	      � ���#000080 � ColumnDefinitions 5
   
   �� 5      $
��721* �6   .+�5   
   �� -   5        $��Kembali��5      $��65,662,618.6,28.8q�68   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataTransaksi��5   E      AutoGenerateColumns .  $
��Left=�6x   $	��285��6�   $��	65,10,0,0q�6�   $	��Top=�6�   $	��650��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id Transaksi��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id_transaksi+  5      $ Id Admin��6%    67   �� *	Id_barang+  5      $ Nama Barang��6%    6:   �� *nama_barang+  5      $ Harga��6%    64   �� *harga_barang+  5      $ Jumlah��6%    65   �� *jumlah_barang+5      �� 5   
   $
��Left=�6   $��
50,340,0,0q�6+   $	��Top=�6?   $��Microsoft Sans Serif)�6W   $	��166��6y   .��5      �� $��	Pemesanan��6   $	��151��6*   $	��360��67   
�������6C   5      �� 5   
   $��Harga��6   $
��Left=�6    $��
81,407,0,0q�6;   $	��Top=�6O   $��Microsoft Sans Serif)�6g   
������� J� RenderTransformOrigin$ 0.405,0.638&�6�   �� 5   
   $��Barang��6   $
��Left=�6!   $��
76,359,0,0q�6<   $	��Top=�6P   $��Microsoft Sans Serif)�6h   
�������$ 1.315,0.567&�6�   �� 5   
   $��Jumlah��6   $
��Left=�6!   $��
81,458,0,0q�6<   $	��Top=�6P   $��Microsoft Sans Serif)�6h   
�������6�   �� 5   
   -   5         ��Name$ cbBarang��5   A   $
��Left=�6S   $��234,361,0,0q�6n   $	��Top=�6�   $	��120��6�   �� 5    
   -   5        	 ��Name$	 jumlah��5       $
��Left=�6"   $��23��6=   $��234,458,0,0q�6I   
 �� TextWrapping$

 Wrap=�6^   $	��Top=�6r   $	��120��6�   6�   �� 5!   
   -   5        $��harga��5!      
�������$
��Left=�64   $��23��6O   $��234,407,0,0q�6[    �� TextAlignment$ Right=�6p   $	��Top=�6�   $	��120��6�   �� 5#   
   $
��Left=�6   $��440.2,340,0,0q�6+   $	��Top=�6B   $��Microsoft Sans Serif)�6Z   $��3��6|   .��5$      �� $��Detail��6   $	��156��6'   $	��302��64   
�������6@   5%      �� 5&   
   $��Total��6   $
��Left=�6    $��481,380,0,0q�6;   $	��Top=�6P   $��Microsoft Sans Serif)�6h   
�������6�   �� 5'   
   $��Bayar��6   $
��Left=�6    $��476,423,0,0q�6;   $	��Top=�6P   $��Microsoft Sans Serif)�6h   
�������$ 	1.132,0.5&�6�   �� 5(   
   $��Kembali��6   $
��Left=�6"   $��476,472,0,0q�6=   $	��Top=�6R   $��Microsoft Sans Serif)�6j   
�������6�   �� 5)   
   -   5        $��total��5)      
�������$
��Left=�65   $��23��6P   $��595,373,0,0q�6\   $ Right=�6q   $	��Top=�6�   $	��120��6�   �� 5*   
   -   5        $	 bayar��5*      $
��Left=�6!   $��23��6<   $��595,423,0,0q�6H   $

 Wrap=�6]   $	��Top=�6q   $	��120��6�   #��� ��6�   6�   �� 5+   
   -   5        $��sosok��5+      
�������$
��Left=�64   $��23��6O   $��595,472,0,0q�6[   $ Right=�6p   $	��Top=�6�   $	��120��6�   �� 5-   
   -	   5         ��Name$ 	btnTambah��5-      $��Tambah��6<   $
��Left=�6M   $��522,571,0,0q�6h   $	��Top=�6}   $��79��6�   $��33��6�   $ 
0.63,0.436&�6�   �� 5.   
   -
   5        $ btnEdit��5.      $��Update��68   $
��Left=�6I   $��354,571,0,0q�6d   $	��Top=�6y   $��79��6�   $��33��6�   $ 0.5,0.5&�6�   �� 5/   
   -   5        $ btnHapus��5/      $��Hapus��6:   $
��Left=�6J   $��198,571,0,0q�6e   $	��Top=�6z   $��79��6�   $��33��6�   50      51      