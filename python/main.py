import sys

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
           
    def quickSort(arg):
        print('[]')
    
    def radixSort(arg):
        print('[]')
        
if __name__ == "__main__":
    Menu().run()