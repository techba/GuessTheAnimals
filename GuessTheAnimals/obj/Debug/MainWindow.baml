   M S B A M L   `   `   `  ����J  FGuessTheAnimals, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GuessTheAnimalsGuessTheAnimals  5   	   =#clr-namespace:GuessTheAnimals.ViewsGuessTheAnimals.Views  5   	        GuessTheAnimals.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:GuessTheAnimals     5   	   5Views#clr-namespace:GuessTheAnimals.Views     5   	     � Title$  Guess the Animals��5	   	   $	��600��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� -   5        $��stkpnl1��5   &   $��1��6   $
��Auto��65   $	��Top=�6C   .+�5      �� -   5         ��Name$ btnHome��5      $��
Go to Home��6*   $��
53,5,609,5q�6U   �� 5      -   5        $ btnPlay��5      $��	Play Game��6*   $��
53,5,609,5q�6T   �� 5      -   5        $ btnReady��5      $��
I am Ready��6+   $��
53,5,609,5q�6W   �� 5      -   5        $ btnAdd��5      $��Add An Animal��6)   $��
53,5,609,5q�6V   5      '   !GuessTheAnimals.Views.ViewAnimals  5      -   5          Name$ ViewAnimalViewControl��5   -   '   !GuessTheAnimals.Views.ViewAnimals   Loaded$" ViewAnimalViewControl_Loaded��6L   $��2��6    6L   )   #GuessTheAnimals.Views.AddAnimalView  5      -   5          Name$ AddAnimalViewControl��5   /   )   #GuessTheAnimals.Views.AddAnimalView   Loaded$! AddAnimalViewControl_Loaded��6M   $��3��6"   6M   +   %GuessTheAnimals.Views.ChoosetheAnimal  5      -   5          Name$  ChoosetheANimalViewControl��5   1   +   %GuessTheAnimals.Views.ChoosetheAnimal	   Loaded$'	 !ChoosetheANimalViewControl_Loaded��6U   $��4��6$   6U   5      5      5      