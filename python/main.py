import sys
import numpy as geek

class Menu:
    data = [121, 432, 564, 23, 1, 45, 788]
    def __init__(self):
        print('')
    def display_menu(self):
       print("""Select a sort method\n1. Quick Sort\n2. Radix Sort""")
       
    def run(self):
        self.display_menu()
     
        choice = input()
     
        if choice == "1":
            self.quickSort(self.data)
        elif choice == "2":
            self.radixSort(self.data)
           
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

    # Main function to implement radix sort
    def radixSort(array):
        # Get maximum element
        max_element = max(array)

        # Apply counting sort to sort elements based on place value.
        place = 1
        while max_element // place > 0:
            countingSort(array, place)
            place *= 10
        
         # Using counting sort to sort the elements in the basis of significant places
        def countingSort(array, place):
            size = len(array)
            output = [0] * size
            count = [0] * 10

            # Calculate count of elements
            for i in range(0, size):
                index = array[i] // place
                count[index % 10] += 1

            # Calculate cumulative count
            for i in range(1, 10):
                count[i] += count[i - 1]

            # Place the elements in sorted order
            i = size - 1
            while i >= 0:
                index = array[i] // place
                output[count[index % 10] - 1] = array[i]
                count[index % 10] -= 1
                i -= 1

            for i in range(0, size):
                array[i] = output[i]
        
if __name__ == "__main__":
    Menu().run()