   M S B A M L   `   `   `  ����M  IUBSCalendarControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:UBSCalendarControlUBSCalendarControl  5      %    UBSCalendarControl.UBSMonthView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:UBSCalendarControl     5        � 	Resources  5	      6   0UBSCalendarControl.DayNumberToVisibiltyConverter !  DayNumberToVisibiltyConverter3   -UBSCalendarControl.HolidayBackgroundConverter  HolidayBackgroundConverter��%:   &	        &	        5
   
   6.     5   
   6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   A� $��0��6    A� Columns$ 7��6#   .+�5      �� $��Mo��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��Tu��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��We��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��Th��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��Fr��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��Sa��6   $��Center=�6"   $
��Bold"�6?   �� 5      $��Su��6   $��Center=�6"   $
��Bold"�6?   5      �� 5   
   $��1��69   ��6   ��  �� Path$
 Days���5      �� 5      .R�5       A� $ 7��6"    A� Rows$ 6��6.   5!      ��5#      �� 5$      .R�5%      �� 
�������$��1q�65   $��1q�6I   y�6T   �� *	DayNumber+ �� 	Converter# [  ._�5&      �� $��Center=�5)      $��Center=�5*      $��2q�5+      ��5&       �� *	DayNumber+��5'      �� *	IsHoliday+# [  � ToolTip 5(      �� *HolidayReason+ ^� 	IsEnabled 6>   �� *	IsHoliday+5,      5-      5.      50      51      52      