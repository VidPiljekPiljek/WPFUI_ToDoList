   M S B A M L   `   `   `  ����I  EWPFUI_ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPFUI_ToDoList.ViewsWPFUI_ToDoList.Views  5      -    'WPFUI_ToDoList.Views.CreateToDoTaskPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      A =Wpf.Ui, Version=3.0.4.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      .local"clr-namespace:WPFUI_ToDoList.Views  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5       N� 
Background# �   5        TextFillColorPrimaryBrush   
Foreground# �  5	       N� 
Foreground# �  5
       N� Title$ CreateToDoTaskPage��5      .��5      �  � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $	��100 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��* �6   �� 5      $��5 �6    � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      $��20 �6   �� 5       $	��200 �6   �� 5!      $��50 �6   �� 5"      $	��250 �6   �� 5#      $��50 �6   �� 5$      $��* �6   �� 5%      $��20 �6   �� 5&      $��5 �6   .+�5)   
   �� $��1��6   $��2��6!   $��Kreiraj zadatak��61   $��30(�6H   �� 5*   
   $��3��6   $��2��6   $��Zadatak (tekst):��6-   $��Bottom=�6H     Wpf.Ui.Controls.TextBox  5+   
   $��4��6   $��2��6"   �� 5,   
   $��Rok odrađivanja:��6   $��2��6+   $��6��6;   $��Bottom=�6H   (  "System.Windows.Controls.DatePicker  5-   
   $��7��6   $��2��6"   �� 5.   
   $��3��6   $��4��6   $��	Važnost:��6-   $��Bottom=�6@   �� 5/   
   $��4��6   $��4��6"   .+�50      	� $��Iznimno važno��6   	� 51      $��Obavezno��6   	� 52      $��
Neobavezan��6   53      �� 54   
   $��Note:��6   $��3��6    $��6��6-   $��Bottom=�6=     55   
   $��4��6   $��6��6"     Wpf.Ui.Controls.Button  57   
   $��Kreiraj zadatak��6   $��8��6.   $��4��6;   $��Center=�6K   $��Center=�6f   58      59      