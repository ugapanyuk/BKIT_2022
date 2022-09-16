# Error
# from package1 import muls.mul_module

from package1.sums import sum_module as sum1

a,b=2,3
print('{} + {} = {}'.format(a, b, sum1.sum1(a,b)))

'''
В консоль выводится следующее:

Init package 1
Init subpackage sums
Running sum1 from sum_module
2 + 3 = 5
'''