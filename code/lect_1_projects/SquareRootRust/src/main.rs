use std::io;

#[derive(Debug, Copy, Clone)]
///Тип решения квадратного уравнения
enum SquareRootResult {
    /// Unit-тип
    NoRoots,
    /// Один корень - кортежная структура
    OneRoot(f64),
    /// С-подобная структура
    TwoRoots { root1: f64, root2: f64 },
}

#[derive(Debug, Copy, Clone)]
/// Структура, соответствующая уравнению
struct Equation {
    /// Коэффициент A
    c_a: f64,
    /// Коэффициент B
    c_b: f64,
    /// Коэффициент C
    c_c: f64,
    /// Дискриминант
    diskr: f64,
    /// Корни
    res: SquareRootResult,
}

impl Equation {
    /// Функция вычисления корней
    fn calculate_roots(&mut self) {
        self.diskr = self.c_b.powi(2) - 4.0 * self.c_a * self.c_c;
        self.res = {
            if self.diskr < 0.0 {
                SquareRootResult::NoRoots
            } else if self.diskr == 0.0 {
                let rt = -self.c_b / (2.0 * self.c_a);
                SquareRootResult::OneRoot(rt)
            } else {
                let rt1 = (-self.c_b - self.diskr.sqrt()) / (2.0 * self.c_a);
                let rt2 = (-self.c_b + self.diskr.sqrt()) / (2.0 * self.c_a);
                SquareRootResult::TwoRoots {
                    root1: rt1,
                    root2: rt2,
                }
            }
        };
    }

    /// Ввод одного коэффициента
    fn get_coef(message: &str) -> f64 {
        return loop {
            let mut input = String::new();
            println!("{}", message);
            io::stdin()
                .read_line(&mut input)
                .expect("Неверно введена строка");
            match input.trim().parse() {
                Ok(val) => {
                    break val;
                }
                Err(_) => {
                    continue;
                }
            }
        };
    }

    fn get_coefs(&mut self) -> () {
        self.c_a = Equation::get_coef("Введите коэффициент A: ");
        self.c_b = Equation::get_coef("Введите коэффициент B: ");
        self.c_c = Equation::get_coef("Введите коэффициент C: ");
    }
}

fn main() {
    use SquareRootResult::*;
    let mut eq = Equation {
        c_a: 0.0,
        c_b: 0.0,
        c_c: 0.0,
        diskr: 0.0,
        res: SquareRootResult::NoRoots,
    };
    eq.get_coefs();
    eq.calculate_roots();
    let text_res = match eq.res {
        NoRoots => format!("Корней нет"),
        OneRoot(rt) => format!("Один корень => {}", rt),
        TwoRoots { root1, root2 } => format!("Два корня => {} и {}", root1, root2),
    };
    println!("{}", text_res);
}
