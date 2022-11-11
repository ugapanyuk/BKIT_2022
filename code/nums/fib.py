def fib():
    '''
    Генераторная функция для чисел Фибоначчи
    '''
    prev, cur = 0, 1
    while True:
        yield cur
        prev, cur = cur, prev+cur

if __name__ == '__main__':
    fib_gen = fib()
    res = [next(fib_gen) for i in range(20)]
    print(res)
