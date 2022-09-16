import os
import module_2 as short_name

print('Hello from {}'.format(os.path.basename(__file__)))

a=2
b=3
print('{} + {} = {}'.format(a, b, short_name.sum1(a,b)))
print('{} + {} = {}'.format(a, b, short_name.sum2(a,b)))


# приведет к ошибке, так как имя module_2 не определено
# print('{} + {} = {}'.format(a, b, module_2.sum1(a,b)))


'''
В консоль выводится следующее:

Importing module 2
Hello from import_2_2.py  
Running sum1 from module 2
2 + 3 = 5
Running sum2 from module 2
2 + 3 = 5
'''