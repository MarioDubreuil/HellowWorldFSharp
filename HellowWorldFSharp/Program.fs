// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let name = "Mario"
let time = System.DateTime.Now
printfn $"Hello from F#! My name is {name}, the time is {time}"

let greetPerson firstName age = $"Hello {firstName}, you are {age} years old"
let text = greetPerson "Mario" 56
printfn $"{text}"
