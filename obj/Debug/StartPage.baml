   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.StartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	StartPage��5	       � 	Resources 5
         CorrectAnswerEnumValues S� 
MethodName��%-   &	        S� 5   
   $ 	GetValues��6=   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ QuestionTextBlock��5      $��0��6/   $��Bottom=�6<   $��Center=�6q   ��6W   �� *
Question+6�   �� 5   
   -   5        $ DescriptionTextBlock��5      $��1��62   $��Center=�6\   ��6?   �� *Description+6|   �� 5   
   -   5         ��Name$ Option1Button��5      $��2��6)   ��66   �� *	Option1+6i   �� 5   
   -   5        $ Option2Button��5      $��3��6(   ��65   �� *	Option2+6h   �� 5   
   -   5        $ Option3Button��5      $��4��6(   ��65   �� *	Option3+6h    � 5   
   -   5          �Name$ 	PageFrame��5      $��1��6#     � NavigationUIVisibility$ Hidden=�60   5      5      