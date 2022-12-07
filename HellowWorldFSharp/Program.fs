// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let name = "Mario"
let time = System.DateTime.Now
printfn $"Hello from F#! My name is {name}, the time is {time}"

let greetPerson firstName age = $"Hello {firstName}, you are {age} years old"
let text = greetPerson "Mario" 56
printfn $"{text}"

let myFunction x y z =
    let inProgress = x + y
    let answer = inProgress * z
    $"The answer is {answer}"

let myAnswer = myFunction 10 20 30
printfn $"{myAnswer}"
