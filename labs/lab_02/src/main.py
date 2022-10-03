from lab_python_oop.rectangle import Rectangle
from lab_python_oop.circle import Circle
from lab_python_oop.square import Square
import cowsay


def main():
    r = Rectangle("синего", 12, 12)
    c = Circle("зеленого", 12)
    s = Square("красного", 12)
    print(r)
    print(c)
    print(s)
    cowsay.cow(
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris nibh lacus, finibus sit amet enim quis, interdum lacinia libero. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aenean tempus sapien sit amet neque dapibus vehicula. Aenean nec tempus quam. Aliquam eget velit ac eros auctor suscipit in sed mauris. In pretium sodales mauris, nec tempor magna tristique at. Suspendisse pellentesque orci at metus vulputate vehicula. Nullam felis massa, ultricies ut dapibus sit amet, gravida molestie magna.')


if __name__ == "__main__":
    main()
