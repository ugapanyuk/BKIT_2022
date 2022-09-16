import os
from module_2 import *
from module_1 import *

# import * рекомендуется только во вспомогательном коде
# при отладке, написании тестов и т.д.

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {}'.format(a, b, sum1(a,b)))

'''
В консоль выводится следующее:

Importing module 2
Importing module 1
Hello from import_2_4_2.py
Running sum1 from module 1
2 + 3 = 5
'''