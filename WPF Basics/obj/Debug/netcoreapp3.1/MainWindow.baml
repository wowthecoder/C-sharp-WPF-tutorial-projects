   M S B A M L   `   `   `  ����E  AWPF Basics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Basics
WPF_Basics  5   	       WPF_Basics.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Basics     5   	   -   5          � Title$  
WPF Basics��5	   	   $	��800��6   $	��400��6)   .��5
      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ ApplyButton��5      $��0 0 10 0q�6H   $��0��6Z   $��Apply��6j   �� 5      -   5        $ ResetButton��5      $��1��6H   $��Reset��6X   �� 5      $��10 0 0 0q�6   $��2��6+   $��Refresh��6;   5      �� 5      $��Pulse Properties��6   $
��Bold"�60   $
��0 10q�6B   �� 5      $��Description��6   �� 5      -   5         ��Name$ DescriptionText��5      $��2q�6/   � 5        5!      �� 5"      $��2* �6'   �� 5#      $��* �6'   .+�5&      �� $��0��6   $��0 0 10 0q�6-   .+�5'      �� $��Status��6    �� 5(       �� 
IsReadOnly$
 True��6   ���#ddd$��2q�6B   5)      �� 5+      $��1��6   .+�5,      �� $��Revision��6    �� 5-      $
 True��6   ���#ddd$��2q�6B   5.      5/      �� 52      $��Part Number��6   �� 53      $
 True��6   ���#ddd$��2q�6:   �� 56      $��Raw Materials��6   $
��Bold"�6-   $
��0 10q�6?   �� 59      $��Material��6   �� 5:      $��2q�6   �� 5=      $��Manufacturing Information��6   $
��Bold"�69   $
��0 10q�6K   �� 5@      $��Work Centres��6   $��0 0 0 10q�6,   � 5C       5D      �� 5E      $��* �6'   �� 5F      $��* �6'   .+�5I      �� $��0��6   .+�5J      �� -   5         ��Name$ WeldCheckBox��5J      $
��Weld��6m   �� 5K      -   5        $ AssemblyCheckBox��5K      $��Assembly��6q   �� 5L      -   5        $ PlasmaCheckBox��5L      $��Plasma��6o   �� 5M      -   5        $ LaserCheckBox��5M      $��Laser��6n   �� 5N      -	   5        $ PurchaseCheckBox��5N      $��Purchase��6q   5O      �� 5Q      $��1��6   .+�5R      �� -
   5        $ LatheCheckBox��5R      $��Lathe��6n   �� 5S      -   5        $ DrillCheckBox��5S      $��Drill��6n   �� 5T      -   5        $ FoldCheckBox��5T      $
��Fold��6m   �� 5U      -   5        $ RollCheckBox��5U      $
��Roll��6m   �� 5V      -   5        $ SawCheckBox��5V      $	��Saw��6l   5W      5X      �� 5[      $��Length��6   �� 5\      -   5        $ 
LengthText��5\      $��2q�6*   �� 5_      $
��Mass��6   �� 5`      -   5        $ MassText��5`      $
 True��6(   ���#ddd$��2q�6L   �� 5c      $��Finish��6   �� 5d      -   5         ��Name$ FinishDropdown��5d       �� SelectedIndex$ 0��6b   $��2q�6t   .@�5e      �� .��6   	Painted6(   �� 5f      .��6   Not Painted6,   5g      �� 5j      $��Purchase Information��6   �� 5k      $ 2��6   $��2q�6)   .@�5l      �� .��6   Rubber6'   �� 5m      .��6   	Plastic6(   �� 5n      .��6   Francium+Water=Kaboom66   5o      �� 5r      $��Supplier Name��6   �� 5s      -   5        $ SupplierNameText��5s      $��2q�6[   �� 5v      $��Supplier Code��6   �� 5w      $��2q�6   �� 5y      $��Additional Info��6   $
��Bold"�6/   $
��0 10q�6A   �� 5|      $
��Note��6   �� 5}      -   5        $ NoteText��5}      $��2q�6(   5~      5      5�      