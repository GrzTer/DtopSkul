   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Dodaj pracownika��5   	   $	��400��6"   $	��600��6/   
����İ�.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��45* �6   �� 5      $
��298* �6   �� 5      $
��114* �6   �� 5      $
��298* �6   �� 5      $	��45* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��132* �6   �� 5      $	��60* �6   .+�5   
   � $��1��6   �� 5   
   $��1��6   $��Dane pracownika��6#   $��1��6<   .��5      �� $��
10,10,10,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Imię��6   $	��100��6+   �� 5      -   5        $��ImieTextBox��5      $	��400��61   5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5      �� $��Nazwisko��6   $	��100��6/   �� 5      -   5        $��NazwiskoTextBox��5      $	��400��65   5       �� 5!      $ 
Horizontal=�6   $��0,10,0,0q�66   .+�5"      �� $��
Stanowisko��6   $	��100��61   �� 5#      -   5        $��StanowiskoComboBox��5#      $	��400��69   .@�5$      �� $��	Kierownik��6'   �� 5%      $��Starszy programista��6'   �� 5&      $��Młodszy programista��6'   �� 5'      $��Tester��6'   5(      5)      5*      5,      �� 5-   
   $��3��6   $��Generowanie hasła��6#   $��1��6>   .��5.      �� $��
10,10,10,0q�6   .+�5/      �� $ 
Horizontal=�6   .+�50      �� $��Ile znaków?��6   $	��100��62   �� 51      -   5        $��IleZnakowComboBox��51      $	��400��67   6E   52      �� 53      $ Vertical=�6   $��0,10,0,0q�64   .+�54      �� -   5        $��MaleDuzeCheckBox��54      $��Małe i wielkie litery��67    d� 	IsChecked$
 TrueY�6W   $	��200��6h   �� 55      -   5        $��CyfryCheckBox��55      $��Cyfry��64   $	��200��6D   �� 56      -   5        $��ZnakiSpecjalneCheckBox��56      $��Znaki specjalne��6=   $	��200��6W   57      58      5:      �� 5;   
   -   5         ��Name$ GenerujButton��5;      $��Generuj hasło��6(   $	��120��6@   
�����F�
�������$��3��6v   $��52,148,51,42q�6�   $��1��6�   �� 5<   
   -	   5        $ ZatwierdzButton��5<      $��
Zatwierdź��6*   
�����F�
�������$��1��6h   $��3��6x   $��206,43,206,43q�6�   $��2��6�   5>      5?      