   M S B A M L   `   `   `  ���� O  KSteamAccountsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SteamAccountsManagerSteamAccountsManager  %    SteamAccountsManager.MainWindow   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SteamAccountsManager     -     �Name$  
mainWindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�   MaterialDesignDarkBackground#���    MaterialDesignFont#���   � Title$ Steam Accounts Manager��$	��400��$	��600�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
�������.���  � ColumnDefinitions �� $	��250 ���  � RowDefinitions �� $��25 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� .+�#  MaterialDesignThemes.Wpf.Card  -   $��2�����	#FF673AB7.��� .+��� $��5q�$
��Left=�$��Steam Accounts Manager��$��DemiBold"�
��������� -    ��Name$ CloseButton��$��Right=�$��5q�$	��✖��
��������� $��Nick:��$��Center=�$��16(�$��5q�$��1���� $��Login:��$��Center=�$��16(�$��5q�$��2���� $��	Password:��$��Center=�$��16(�$��5q�$��3���� -   $��Add Account��$��5q�$��4���� -   	 ��Name$	 NickText��
�������$��Right=�$��Center=�$	��200��$��1��$��5q��� -   $	 	LoginText��
�������$��Right=�$��Center=�$	��190��$��2��
 � Cursor$
 IBeam��$��5q�G� -    G�Name$ PasswordText��
�������$��Right=�$��Center=�$	��165��$��3��$
 IBeam��$��5q�  $��1��$��5��$��1��$��5q����	#FF515151.��� .+��� -    ��Name$ AccountsList��$��1��$��5��$��5q�
�������$��16(��� -	   $��Sign in��$��5q�$��5��$	��Top=��� -
   $��Delete��$��5,42,5,0q�$��5��$	��Top=��� -   $ ErorText��$��5��$�� ��$��14(�$��Bottom=�$��Center=�$��5q����	#FFD61B1B