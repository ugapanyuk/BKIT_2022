import os
from module_2 import *

# import * рекомендуется только во вспомогательном коде
# при отладке, написании тестов и т.д.

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {}'.format(a, b, sum1(a,b)))
print('{} + {} = {}'.format(a, b, sum2(a,b)))

'''
В консоль выводится следующее:

Importing module 2
Hello from import_2_3.py
Running sum1 from module 2
2 + 3 = 5
Running sum2 from module 2
2 + 3 = 5
'''