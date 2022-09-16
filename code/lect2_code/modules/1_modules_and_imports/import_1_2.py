import os
from module_1 import sum1

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {}'.format(a, b, sum1(a,b)))

'''
В консоль выводится следующее:

Importing module 1
Hello from import_1_2.py
Running sum1 from module 1
2 + 3 = 5
'''