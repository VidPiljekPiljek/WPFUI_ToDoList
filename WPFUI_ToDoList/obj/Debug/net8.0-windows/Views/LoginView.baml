   M S B A M L   `   `   `  ����I  EWPFUI_ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPFUI_ToDoList.ViewsWPFUI_ToDoList.Views  5      $    WPFUI_ToDoList.Views.LoginView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      A =Wpf.Ui, Version=3.0.4.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5      .local"clr-namespace:WPFUI_ToDoList.Views  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	      #���   5
        TextFillColorPrimaryBrush   
Foreground# �  5      #���  5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��35 �6   �� 5      �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��Korisničko ime:��6   $��4��6*   $��0��67   $��Center=�6G   $��Right=�6b   $��5q�6~   �� 5!   
   $��Lozinka:��6   $��6��6#   $��0��60   $��Center=�6@   $��Right=�6[   $��5q�6w   �� 5"   
   $��Vid Piljek, 2024.��6   $��7��6,   $��2��69   $��Bottom=�6I   $��Right=�6d   $��5q�6�     Wpf.Ui.Controls.TextBox  5#   
   $��4��6   $��1��6"   !  Wpf.Ui.Controls.PasswordBox  5$   
   $��6��6   $��1��6&     Wpf.Ui.Controls.Button  5%   
   $��1��6(   $��Login��68   $��7��6H   $��Center=�6U   $��Center=�6p   $	��100��6�   ��6   �� 6�   %  Wpf.Ui.Controls.HyperlinkButton  5&   
   $&�� Klikni ovdje da kreiraš račun.��61   $��5��6Z   $��2��6g   ��6   �� 6g   �� 5(   
   $��1��6   $��0��6%   .+�5)      �� $��Center=�6   $
��Wrap=�65   $��To Do List App��6I   $��Center=�6_   $��40(�6z   �� 5*      $!��Molimo vas da se prijavite.��6   $��Center=�6:   $��Center=�6W   5+      5-      5.      