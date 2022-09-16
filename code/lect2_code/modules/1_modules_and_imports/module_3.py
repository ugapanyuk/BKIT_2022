import sys

print("Importing module 3")

def sum1(a, b):
    print("Running sum1 from module 3")
    return a + b

if __name__ == "__main__":
    print("This code is not running when importing module. " + \
        "Only when executing as script.")
    # Command line params
    
    print("Param 0 = {} \n\n".format(sys.argv[0]))
    
    if len(sys.argv) > 1:
        
        for i, p in enumerate(sys.argv):
            print("Param {} = {}".format(i, p))

        try:
            a = float(sys.argv[1])
            b = float(sys.argv[2])
            print('{} + {} = {}'.format(a, b, sum1(a,b)))
        except:
            pass

    else:
        print("No command line params")


'''
Запуск скрипта:
module_3.py 100 23

В консоль выводится следующее:

Importing module 3
This code is not running when importing module. Only when executing as script.
Param 0 = .../1_modules_and_imports/module_3.py

Param 0 = .../1_modules_and_imports/module_3.py
Param 1 = 100
Param 2 = 23
Running sum1 from module 3
100.0 + 23.0 = 123.0
'''