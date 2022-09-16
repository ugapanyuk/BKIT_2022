import os
import module_1

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {}'.format(a, b, module_1.sum1(a,b)))

'''
В консоль выводится следующее:

Importing module 1
Hello from import_1_1.py
Running sum1 from module 1
2 + 3 = 5
'''