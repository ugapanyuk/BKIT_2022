// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".

//Для использования классов Math и Console
open System

// Алгебраический тип или "Discriminated Unions"
// Алгебраический тип - тип сумма из типов произведений 
// | - означает "или" и задает тип-сумму
// * - означает "и" и задает произведение (кортеж, который соединяет все элементы)

// В абстрактных алгебрах наиболее близкой алгеброй является полукольцо

///Тип решения квадратного уравнения
type SquareRootResult = 
    | NoRoots
    | OneRoot of double
    | TwoRoots of double * double //кортеж из двух double 

///Функция вычисления корней уравнения
let CalculateRoots(a:double, b:double, c:double):SquareRootResult = 
    let D = b*b - 4.0*a*c;
    if D < 0.0 then NoRoots
    else if D = 0.0 then 
        let rt = -b / (2.0 * a)
        OneRoot rt       
    else 
        let sqrtD = Math.Sqrt(D)
        let rt1 = (-b + sqrtD) / (2.0 * a);
        let rt2 = (-b - sqrtD) / (2.0 * a);
        TwoRoots (rt1,rt2)

///Вывод корней (тип unit - аналог void)
let PrintRoots(a:double, b:double, c:double):unit = 
    printf "Коэффициенты: a=%A, b=%A, c=%A. " a  b  c
    let root = CalculateRoots(a,b,c)
    //Оператор сопоставления с образцом
    let textResult = 
        match root with 
        | NoRoots -> "Корней нет"  
        | OneRoot(rt) -> "Один корень " + rt.ToString()
        | TwoRoots(rt1,rt2) -> "Два корня " + rt1.ToString() + " и " + rt2.ToString()
    printfn "%s" textResult


[<EntryPoint>]
let main argv = 
    //Тестовые данные
    //2 корня
    let a1 = 1.0;
    let b1 = 0.0;
    let c1 = -4.0;
    //1 корень
    let a2 = 1.0;
    let b2 = 0.0;
    let c2 = 0.0;
    //нет корней
    let a3 = 1.0;
    let b3 = 0.0;
    let c3 = 4.0;

    PrintRoots(a1,b1,c1)
    PrintRoots(a2,b2,c2)
    PrintRoots(a3,b3,c3)

    //|> ignore - перенаправление потока с игнорирование результата вычисления
    Console.ReadLine() |> ignore
    0 // возвращение целочисленного кода выхода
