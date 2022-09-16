import os
import sys
import module_3

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {} \n'.format(a, b, module_3.sum1(a,b)))

print(sys.path)

'''
В консоль выводится следующее:

Importing module 3
Hello from import_3.py
Running sum1 from module 3
2 + 3 = 5

['C:\\ProgramData\\Anaconda3\\DLLs', 'C:\\ProgramData\\Anaconda3\\lib']
'''
