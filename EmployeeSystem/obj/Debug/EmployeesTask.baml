   M S B A M L   `   `   `  ����I  EEmployeeSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EmployeeSystemEmployeeSystem  5   	   "    EmployeeSystem.EmployeesTask   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EmployeeSystem     5   	     � Title$  EmployeesTask��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��DataInfo��5
      $��
0,300,0,10q�6#   6f   �� 5   
   -   5         ��Name$ 	LabelTask��5      $��TaskID:��6#   $��22(�65   $��Segoe UI Black)�6C   $
��Left=�6_   $	��Top=�6z   $��
44,178,0,0q�6�   6�   �� 5   
   -   5         ��Name$ IDtask��5      $
��Left=�6"   $	��Top=�6=   $��22(�6U   $��Segoe UI Black)�6c   $��162,186,0,0q�6   $��82��6�   6�   �� 5   
   -   5        $ 	LabelStat��5      $��Status:��6#   $��22(�65   $��Segoe UI Black)�6C   $
��Left=�6_   $	��Top=�6z   $��305,178,0,0q�6�   �� 5   
   -   5        $ 	StatusTxt��5      $
��Left=�6%   $	��Top=�6@   $��22(�6X   $��Segoe UI Black)�6f   $��400,178,0,0q�6�   $	��134��6�   $��39��6�   6�   �� 5   
   -   5         ��Name$ 
ButtonSave��5      $
��Save��6%   $��22(�64   $��Segoe UI Black)�6B   $
��Left=�6^   $	��Top=�6y   $��564,181,0,0q�6�   6�   �� 5   
   -   5        $ LabelMis��5      $��pendig / on progress��6"   $��22(�6A   $��Segoe UI Black)�6O   $
��Left=�6k   $	��Top=�6�   $��
44,222,0,0q�6�   �� 5   
   -   5        $ 	LabelDone��5      $��	Completed��6#   $��22(�67   $��Segoe UI Black)�6E   $
��Left=�6a   $	��Top=�6|   $��	44,10,0,0q�6�     5   
   -	   5          Name$ DataInfoDone��5      $��
0,51,0,279q�6)   6=   �� 5   
   -
   5         ��Name$ StatDrag��5      $
��Left=�6%   $	��Top=�6@   $��22(�6X   $��Segoe UI Black)�6f   $��506,178,0,0q�6�   $��39��6�   6�   5      5      