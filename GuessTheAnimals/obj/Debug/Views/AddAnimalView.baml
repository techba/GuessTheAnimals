   M S B A M L   `   `   `  ����J  FGuessTheAnimals, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GuessTheAnimals.ViewsGuessTheAnimals.Views  5      E'clr-namespace:GuessTheAnimals.ViewModelGuessTheAnimals.ViewModel  5      ?$clr-namespace:GuessTheAnimals.CommonGuessTheAnimals.Common  5      )    #GuessTheAnimals.Views.AddAnimalView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:GuessTheAnimals.Views     5      6vm'clr-namespace:GuessTheAnimals.ViewModel     5      2c$clr-namespace:GuessTheAnimals.Common     5      $��335.543��5	   3     � DataContext  5
      3   -GuessTheAnimals.ViewModel.AddAnimalsViewModel  5   
    � 	Resources 5         validationTemplate �� Orientation �� TextAlignment � ToolTip �� ElementName �� Path ��Name��%�  &	        �� 5   
   .R�5      ]� .+�5      �� $ 
Horizontal=�6   $	��Top=�66   .+�5      � $��12��6   $��12��6&   .+�5      A� $��12��6"   $��12��6-   
���  ��$��Center=�6D   $��Center=�6a   6   �� 5      
�������$��Heavy"�67   $��8(�6J   $��Center=�6W   $��Center=�6t   $ Center=�6�    5      �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�X6�   5      �� 5      
���  ��$��12(�61   $��2,0,0,0q�6?   ��6Q   �� $ ErrorAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�6�   5      �� 5      $ ErrorAdorner��6,   6E   5      5      5      .��5      �� $
��Left=�6   $��	10,0,0,18q�6,   $	��280��6?   .+�5   
   �� $��14(�6   $��Heavy"�6#   ��67   �� *state.InsertState+ �� Mode$ TwoWay=��� 5   
   $��14(�6   $��Heavy"�6"   
���  ����6F   �� *state.ErrorState+$ TwoWay=��� 5    
   -   5        	 ��Name$	 label��5       $��Add an Animal��6   �� 5!   
   $ 
Horizontal=�6   $��5,20,0,0q�6.   .+�5"      �� -   5        $	 label1��5"      $��Name:��6$   $	��109��64   $��5,1,3,5q�6@   �� 5#      -   5        
 ��Name$
 txtName��5#      $��22��6'   $��5,1,3,5q�63    �� TextWrapping$
 Wrap=�6E   $	��142��6Y    =� ErrorTemplate# [  5$      .��6V   ��5%      �� 5&      $ animal.Name�6   $ TwoWay=�61    �� UpdateSourceTrigger$ PropertyChanged=�6?    �� ValidationRules 5'      3   -GuessTheAnimals.Common.RequiredFieldValidator  5(      69   5*      .��5+       5,      5-      �� 5.   
   $ 
Horizontal=�6   $��5,0,0,0q�6.   .+�5/      �� -   5        $	 label2��5/      $��Color:��6$   $	��109��65   $��5,1,3,5q�6A   �� 50      -   5        $
 txtColor��50      $��22��6(   $��5,1,3,5q�64   $
 Wrap=�6F   $	��142��6Z   # [  51      .��6U   ��52      �� 53      $ animal.Color�6   $ TwoWay=�62   $ PropertyChanged=�6A    54        55      69   57      .��58       59      5:      �� 5;   
   $ 
Horizontal=�6   $��5,0,0,0q�6.   .+�5<      �� -   5        $	 label3��5<      $��Sound:��6$   $	��109��65   $��5,1,3,5q�6A   �� 5=      -   5        $
 txtSound��5=      $��22��6(   $��5,1,3,5q�64   $
 Wrap=�6F   $	��142��6Z   # [  5>      .��6U   ��5?      �� 5@      $ animal.Sound�6   $ TwoWay=�62   $ PropertyChanged=�6A    5A        5B      69   5D      .��5E       5F      5G      �� 5H   
   $ 
Horizontal=�6   $��5,0,0,0q�6.   .+�5I      �� -   5        $	 label4��5I      $��Feature:��6$   $	��109��67   $��5,1,3,5q�6C   �� 5J      -	   5        $
 
txtFeature��5J      $��22��6*   $��5,1,3,5q�66   $
 Wrap=�6H   $	��142��6\   # [  5K      .��6U   ��5L      �� 5M      $ animal.Feature�6   $ TwoWay=�64   $ PropertyChanged=�6C    5N        5O      69   5Q      .��5R       5S      5T      �� 5U   
   $ 
Horizontal=�6   $��5,0,0,0q�6.   .+�5V      �� -
   5        $	 label5��5V      $��Image Location:��6$   $	��109��6>   $��5,1,3,5q�6J   �� 5W      -   5        $
 	txtImgLoc��5W      $��22��6)   $��5,1,3,5q�65   $
 Wrap=�6G   $��89��6[   # [  5X      {�.  .��6g   ��5Y      �� 5Z      $ animal.ImageLoc�6   $ TwoWay=�65   $ PropertyChanged=�6C    5[        5\      69   5^      .��5_       5`      �� 5a      -   5         ��Name$ btnLoad��5a   2   $��23��6   $��5,1,3,5q�6!   $��Bottom=�6C   $��45��5b   	   $��_Load��6*   5c      �� 5d   
   -   5        $ btnAddAnimal��5d      $��
Add Animal��6'   $��
45,20,76,0q�6<   $��23��6P   ��6\   �� *addAnimalCmd+5e      5f      