   M S B A M L   `   `   `  ����J  FGuessTheAnimals, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GuessTheAnimals.ViewsGuessTheAnimals.Views  5      E'clr-namespace:GuessTheAnimals.ViewModelGuessTheAnimals.ViewModel  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      =#clr-namespace:GuessTheAnimals.ModelGuessTheAnimals.Model  5	      +    %GuessTheAnimals.Views.ChoosetheAnimal   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:GuessTheAnimals.Views     5      =	ViewModel'clr-namespace:GuessTheAnimals.ViewModel     5      9System&clr-namespace:System;assembly=mscorlib     5      5Model#clr-namespace:GuessTheAnimals.Model     5	        � DataContext  5      5   /GuessTheAnimals.ViewModel.ChooseAnimalViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��14(�6   $��Heavy"�6"   
���  ����6F   �� *state.ErrorState+ �� Mode$ TwoWay=��� 5   
   $��18(�6   $
��Bold"�6"   ��64   �� *animal.Name+$ TwoWay=��� 5   
   -   5         ��Name$ lblQ1��5      $��1��6   $)��#Select the color of chosen Animal ?��6-   $
��Left=�6[   $��	10,21,0,0q�6v   $	��Top=�6�   $
��Auto��6�   �� 5   
   -   5         ��Name$ 
colorPanel��5   "   $��2��6    �� Orientation$ 
Horizontal=�66   $��15,0,0,0q�6O   .+�5      �� -   5         ��Name$ 
colorCombo��5      $	��154��6+   ��67   �� *
colorPanel+$ TwoWay=� �� SelectedItem 6f   �� *state.SelectedColor+$ TwoWay=�5      �� 5    
   -   5        $ lblQ2��5       $��3��6   $.��(Select the Sound made by chosen Animal ?��6-   $
��Left=�6`   $��	10,21,0,0q�6{   $	��Top=�6�   $
��Auto��6�   �� 5!   
   -   5        $ 
soundPanel��5!   "   $��4��6   $ 
Horizontal=�66   $��15,0,0,0q�6O   .+�5"      �� -   5        $ 
soundCombo��5"      $	��155��6+   ��67   �� *
soundPanel+$ TwoWay=� 6f   �� *state.SelectedSound+$ TwoWay=�5#      �� 5$   
   -   5        $ lblQ3��5$      $��5��6   $.��(Select the uniqueness of chosen Animal ?��6-   $
��Left=�6`   $��	10,21,0,0q�6{   $	��Top=�6�   $
��Auto��6�   �� 5%   
   -   5        $ featurePanel��5%   "   $��6��6   $ 
Horizontal=�68   $��15,0,0,0q�6Q   .+�5&      �� -	   5        $ featureCombo��5&      $	��154��6-   $��0,0,0,99q�6�   ��69   �� *featurePanel+$ TwoWay=� 6j   �� *state.SelectedFeature+$ TwoWay=�6�   5'      �� 5(   
   $��	Guess it!��6   $��6��6%   $��50,50,257,50q�62   ��6H   �� *chooseAnimalCmd+5)      5*      5+      