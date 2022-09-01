// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".

open System

///Интерфейс
type SquareRootEmpty = interface end
//Наследуемые классы с вариантами решения
type NoRoots()=
    interface SquareRootEmpty
//Клсс содержит параметры, которые присваиваются свойству
type OneRoot(p:double)=
    interface SquareRootEmpty
    // Объявление свойства
    member val root = p : double with get, set

type TwoRoots(p1:double,p2:double)=
    interface SquareRootEmpty
    // Объявление свойства
    member val root1 = p1 : double with get, set
    member val root2 = p2 : double with get, set

///Функция вычисления корней уравнения
let CalculateRoots(a:double, b:double, c:double):SquareRootEmpty = 
    let D = b*b - 4.0*a*c;
    if D < 0.0 then (new NoRoots() :> SquareRootEmpty)
    else if D = 0.0 then 
        let rt = -b / (2.0 * a)
        //Требуется явное приведение к интерфейсному типу
        (OneRoot(rt) :> SquareRootEmpty)
    else 
        let sqrtD = Math.Sqrt(D)
        let rt1 = (-b + sqrtD) / (2.0 * a);
        let rt2 = (-b - sqrtD) / (2.0 * a);
        (TwoRoots(rt1,rt2) :> SquareRootEmpty)

///Вывод корней (тип unit - аналог void)
let PrintRoots(a:double, b:double, c:double):unit = 
    printf "Коэффициенты: a=%A, b=%A, c=%A. " a  b  c
    let root = CalculateRoots(a,b,c)
    //Оператор сопоставления с образцом по типу - :?
    let textResult = 
        match root with 
        | :? NoRoots -> "Корней нет"  
        | :? OneRoot as r -> "Один корень " + r.root.ToString()
        | :? TwoRoots as r -> "Два корня " + r.root1.ToString() + " и " + r.root2.ToString()
        | _ -> "" // Если не выполняется ни один из предыдущих шаблонов
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
