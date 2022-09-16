from package1.muls.mul_module import mul1
from package1.sums.sum_module import sum1

a,b=2,3
print('{} + {} = {}'.format(a, b, sum1(a,b)))
print('{} * {} = {}'.format(a, b, mul1(a,b)))

'''
В консоль выводится следующее:

Init package 1
Init subpackage muls
Init subpackage sums
Running sum1 from sum_module
2 + 3 = 5
Running mul1 from mul_module
2 * 3 = 6
'''