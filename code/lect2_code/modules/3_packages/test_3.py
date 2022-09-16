from package1.sums import sum_module

a,b=2,3
print('{} + {} = {}'.format(a, b, sum_module.sum1(a,b)))

'''
В консоль выводится следующее:

Init package 1
Init subpackage sums
Running sum1 from sum_module
2 + 3 = 5
'''