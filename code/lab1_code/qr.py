import sys
import math


def get_coef(index, prompt):
    '''
    Читаем коэффициент из командной строки или вводим с клавиатуры

    Args:
        index (int): Номер параметра в командной строке
        prompt (str): Приглашение для ввода коэффицента

    Returns:
        float: Коэффициент квадратного уравнения
    '''

    isError = True
    try:
        # Пробуем прочитать коэффициент из командной строки
        coef_str = sys.argv[index]
    except:
        # Вводим с клавиатуры
        while isError:
            try:
                print(prompt)
                coef_str = input()
                # Переводим строку в действительное число
                coef = float(coef_str)
                isError = False
            except ValueError:
                print('Введите число!')

    return coef


def get_roots(a, b, c):
    '''
    Вычисление корней квадратного уравнения

    Args:
        a (float): коэффициент А
        b (float): коэффициент B
        c (float): коэффициент C

    Returns:
        list[float]: Список корней
    '''
    result = []
    D = b * b - 4 * a * c
    if D == 0.0:
        root = -b / (2.0 * a)
        result.append(root)
    elif D > 0.0:
        sqD = math.sqrt(D)
        root1 = (-b + sqD) / (2.0 * a)
        root2 = (-b - sqD) / (2.0 * a)
        result.append(root1)
        result.append(root2)
    return result


def get_roots_2qr(a, b, c):
    '''
      Вычисление корней биквадратного уравнения

      Args:
          a (float): коэффициент А
          b (float): коэффициент B
          c (float): коэффициент C

      Returns:
          list[float]: Список корней
      '''

    result = []
    D = b * b - 4 * a * c
    if D == 0.0:
        root = -b / (2.0 * a)
        if root > 0:
            result.extend([math.sqrt(root), math.sqrt(root) * (-1.0)])
        elif root == 0:
            result.append(root)
    elif D > 0.0:
        sqD = math.sqrt(D)
        root1 = (-b + sqD) / (2.0 * a)
        root2 = (-b - sqD) / (2.0 * a)
        if root1 > 0:
            result.extend([math.sqrt(root1), math.sqrt(root1) * (-1.0)])
        elif root1 == 0:
            result.append(root1)
        if root2 > 0:
            result.extend([math.sqrt(root2), math.sqrt(root2) * (-1.0)])
        elif root2 == 0:
            result.append(root2)

    return result


def print_roots(roots):
    '''
       Вывод в консоль корней уравнения

       Args:
           roots (list[float]): список корней
    '''

    roots_count = len(roots)
    if roots_count == 0:
        print('Нет корней')
    elif roots_count == 1:
        print('Один корень: {}'.format(roots[0]))
    elif roots_count == 2:
        print('Два корня: {} и {}'.format(roots[0], roots[1]))
    elif roots_count == 3:
        print('Три корня: {}, {} и {}'.format(roots[0], roots[1], roots[2]))
    elif roots_count == 4:
        print('Четыре корня: {}, {}, {} и {}'.format(roots[0], roots[1], roots[2], roots[3]))


def main():
    '''
    Основная функция
    '''
    a = get_coef(1, 'Введите коэффициент А:')
    b = get_coef(2, 'Введите коэффициент B:')
    c = get_coef(3, 'Введите коэффициент C:')
    # Вычисление корней
    roots = get_roots_2qr(a, b, c)
    # Вывод корней
    print_roots(roots)


# Если сценарий запущен из командной строки
if __name__ == "__main__":
    main()

# Пример запуска
# qr.py 1 0 -4
