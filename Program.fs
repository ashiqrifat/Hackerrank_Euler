//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below N.

//Input Format

//First line contains T that denotes the number of test cases. This is followed by T lines, each containing an integer, N.


//Output Format

//For each test case, print an integer that denotes the sum of all the multiples of 3 or 5 below N.

//Sample Input 0
//2
//10
//100

//Sample Output 0
//23
//2318
open System

open System

let three x =
    match x % 3 with
    | 0 -> x
    | _ -> 0
    
    
let five x =
    match x % 5 with
    | 0 -> x
    | _ -> three x



let sum x = [1..x]
            |> List.map (fun i -> five i)
            |> List.sum


let inputReader = 
    let input1 = Console.ReadLine() |> int
    input1


[<EntryPoint>]
let main = 

    let noOftestCases = Console.ReadLine() |> int

    let inputs = [1..noOftestCases]
                 |> List.map (fun i -> inputReader)
                 |> List.map (fun i -> sum i)

    printfn "%A" inputs

Console.ReadKey() |> ignore