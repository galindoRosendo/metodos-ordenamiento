import sys
import numpy as geek

class Menu:
    def __init__(self):
        print('')
    def display_menu(self):
       print("""Select a sort method\n1. Quick Sort\n2. Radix Sort""")
       
    def run(self):
        self.display_menu()
     
        choice = input()
     
        if choice == "1":
            self.quickSort()
        elif choice == "2":
            self.radixSort()
           
    def quickSort(array):
        
        if array.length < 1:
            return []
        
        left = []
        right = []
        pivot = array[0]
        control = 0
        
        for x in array:
            if array[control] < pivot:
                left.append(array[control])
            else:
                right.append(array[i])
            control+=1
        return geek.concatenate(self.quickSort(left), pivot, self.quickSort(right))
    
    def radixSort(arg):
        print('[]')
        
if __name__ == "__main__":
    Menu().run()