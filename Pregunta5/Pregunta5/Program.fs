// For more information see https://aka.ms/fsharp-console-apps
// LEONEL ALVARO CHAMACA LIMA CI:6853618  PREGUNTA5
open System
let from whom =
    sprintf "from %s" whom
let sampleSum x y =  x + y
let sampleDif x y =  x - y
let samplePro x y =  x * y
let sampleDiv x y =  x / y

[<EntryPoint>]

let main argv =
    let message = from "F#" // Llamada de la funcion
    Console.WriteLine("introduzca 2 numeros : ")
    let a  = Convert.ToInt32(Console.ReadLine()) 
    let b  = Convert.ToInt32(Console.ReadLine())
    let sum  = sampleSum a b
    let dif = sampleDif a b 
    let pro = samplePro a b
    let div = sampleDiv a b

    printfn "result of sum     : %d" (sum)
    printfn "result of rest    : %d" (dif)
    printfn "result of product : %d" (pro)
    printfn "result of div     : %d" (div)
    
    let tecla = Console.ReadKey()
    0 
