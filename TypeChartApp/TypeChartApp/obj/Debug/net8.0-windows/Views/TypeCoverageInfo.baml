   M S B A M L   `   `   `  ����G  CTypeChartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TypeChartApp.ViewsTypeChartApp.Views  5      A%clr-namespace:TypeChartApp.ConvertersTypeChartApp.Converters  5      A%clr-namespace:TypeChartApp.ViewModelsTypeChartApp.ViewModels  5      )    #TypeChartApp.Views.TypeCoverageInfo   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TypeChartApp.Views     5      <
converters%clr-namespace:TypeChartApp.Converters     5      4vm%clr-namespace:TypeChartApp.ViewModels     5        � 	Resources  5      9   3TypeChartApp.Converters.PokemonTypeToColorConverter   PokemonTypeToColorConverter  ListBoxItemTemplate  CommonListBoxStyle �� 
TargetType �� Property �� Value  CommonTextBlockStyle��%&  &	        &	      &	 I     7  &	 �       5   
   61   �� 5   
   .R�5      �� ��6   �� 5      �� 5   
   " ��6+   .�5      ��  � ��8   6-   5      �� 5   
   " ��6-   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 5q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5"   
   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   .+�5)   
   �� $��0��5*      $��0��5+       �� DisplayMemberPath$ PokemonTypeName��5.      $��10q�5/      ��5,      �� *AvailableTypes+ �� SelectedItem 5-      �� *SelectedType1+��50      �� 51      " ��6   .�52      ��  � ��$
 Bold"�63   �� 53       � �� 63   ��  �� 	Converter# [  54      56      �� 58   
   $��0��59      $��1��5:      $ PokemonTypeName��5=      $��10q�5>      ��5;      �� *AvailableTypes+ 5<      �� *SelectedType2+��5?      �� 5@      " ��6   .�5A      ��  � ��$
 Bold"�63   �� 5B       � �� 63   �� # [  5C      5E      �� 5G   
   $��0��5H      $��2��5I      $ PokemonTypeName��5L      $��10q�5M      ��5J      �� *AvailableTypes+ 5K      �� *SelectedType3+��5N      �� 5O      " ��6   .�5P      ��  � ��$
 Bold"�63   �� 5Q       � �� 63   �� # [  5R      5T      �� 5V   
   $��0��5W      $��3��5X      $ PokemonTypeName��5[      $��10q�5\      ��5Y      �� *AvailableTypes+ 5Z      �� *SelectedType4+��5]      �� 5^      " ��6   .�5_      ��  � ��$
 Bold"�63   �� 5`       � �� 63   �� # [  5a      5c      � 5e   
   $��1��6   $��0��6   $��4��6,    5f      �� 5g      $��* �6#   �� 5h      $��* �6#   �� 5i      $��* �6#   �� 5j      $��* �6#   .+�5m      �� $��0��6   .+�5n      �� $��	No Effect��6   #��[ 6-   �� 5o      #��[ 6   
���   �
���������6l   �� *
NoEffect+5p      �� 5r      $��1��6   .+�5s      �� $��Not Effective��6   #��[ 61   �� 5t      #��[ 6   
���  ����6W   �� *NotEffective+5u      �� 5w      $��2��6   .+�5x      �� $��Normal��6   #��[ 6*   �� 5y      #��[ 6   
��� �����6Z   �� *StandardEffective+5z      �� 5|      $��3��6   .+�5}      �� $��Super Effective��6   #��[ 63   �� 5~      #��[ 6   
��������6^   �� *SuperEffective+5      5�      5�      5�      