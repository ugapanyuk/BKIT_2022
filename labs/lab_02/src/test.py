import unittest

from lab_python_oop.rectangle import Rectangle
from lab_python_oop.circle import Circle
from lab_python_oop.square import Square
import math


class TestRectangle(unittest.TestCase):
    def test_rect_init(self):
        r = Rectangle("синего", 12, 12)
        self.assertEqual(r.get_figure_type(), 'Прямоугольник')
        self.assertEqual(r.fc.colorproperty, 'синего')
        self.assertEqual(r.width, 12)
        self.assertEqual(r.height, 12)
        self.assertEqual(r.square(), r.height * r.width)

    def test_rect_repr(self):
        r = Rectangle("синего", 12, 12)
        self.assertEqual(r.__repr__(), 'Прямоугольник синего цвета шириной 12 и высотой 12 площадью 144.')


class TestCircle(unittest.TestCase):
    def test_circ_init(self):
        c = Circle("зеленого", 12)
        self.assertEqual(c.get_figure_type(), 'Круг')
        self.assertEqual(c.fc.colorproperty, 'зеленого')
        self.assertEqual(c.r, 12)
        self.assertEqual(c.square(), math.pi * (c.r ** 2))

    def test_circ_repr(self):
        c = Circle("зеленого", 12)
        self.assertEqual(c.__repr__(), 'Круг зеленого цвета радиусом 12 площадью 452.3893421169302.')


class TestSquare(unittest.TestCase):
    def test_sq_init(self):
        s = Square("красного", 12)
        self.assertEqual(s.get_figure_type(), 'Квадрат')
        self.assertEqual(s.fc.colorproperty, 'красного')
        self.assertEqual(s.width, 12)
        self.assertEqual(s.height, 12)
        self.assertEqual(s.square(), s.height * s.width)

    def test_sq_repr(self):
        s = Square("красного", 12)
        self.assertEqual(s.__repr__(), 'Квадрат красного цвета со стороной 12 площадью 144.')



if __name__ == '__main__':
    unittest.main()
