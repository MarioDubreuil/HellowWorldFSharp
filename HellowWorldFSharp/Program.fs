// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let name = "Mario"
let time = System.DateTime.Now
printfn $"Hello from F#! My name is {name}, the time is {time}"

let greetPerson firstName age = $"Hello {firstName}, you are {age} years old"
let text = greetPerson "Mario" 56
printfn $"{text}"

// exercise 3.1

let myFunction x y z =
    let inProgress = x + y
    let answer = inProgress * z
    $"The answer is {answer}"

let myAnswer = myFunction 10 20 30
printfn $"{myAnswer}"

//

let firstName = "Frank"
let lastName = "Schmidt"
let fullName = $"{firstName} {lastName}"
let greetingText = $"Greetings, {fullName}"
printfn $"{greetingText}"

//

let greetingText2 =
    let fullName =
        let firstName = "Frank"
        let lastName = "Schmidt"
        $"{firstName} {lastName}"
    $"Greetings, {fullName}"
printfn $"{greetingText2}"

//

let greetingTextWithFunction person =
    let makeFullName firstName lastName =
        $"{firstName} {lastName}"
    let fullName = makeFullName "Frank" "Schmidt"
    $"Greetings, {fullName} from {person}"
let msg = greetingTextWithFunction "Mario"
printfn $"{msg}"

let add a b =
    let answer = a + b
    answer

let addResult = add 3 5
printfn $"{addResult}"

//

let explicit = ResizeArray<int>()
let typeHole = ResizeArray<_>()
let omitted = ResizeArray()

omitted.Add "a"
typeHole.Add 12.5

//

let combineElements<'T> (a : 'T) (b : 'T) (c : 'T) =
    let output = ResizeArray<'T>()
    output.Add a
    output.Add b
    output.Add c
    output

combineElements<int> 1 2 3
combineElements<char> '1' '2' '3'
combineElements<string> "1" "2" "3"

let combineElementsV2 a b c =
    let output = ResizeArray()
    output.Add a
    output.Add b
    output.Add c
    output
    
combineElementsV2 1 2 3
combineElementsV2 '1' '2' '3'
combineElementsV2 "1" "2" "3"

//

let calculateGroup age =
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "Pensioner"
 
let sayHello someValue =
    let group =
        if someValue < 10.0 then calculateGroup 15
        else calculateGroup 35
    "Hello " + group
 
let result = sayHello 10.5

//

let describeAge age =
    let ageDescription =
        if age < 18 then "Child"
        elif age < 65 then "Adult"
        else "OAP"
    let greeting = "Hello"
    $"{greeting}! You are a {ageDescription}"

describeAge 65

//

let ageDescriptionV2 age =
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAgeV2 age =
    let ageDescription = ageDescriptionV2 age
    let greeting = "Hello"
    $"{greeting}! You are a {ageDescription}"

describeAgeV2 17 |> ignore
let myDescribedAgeV2 = describeAgeV2 17

//

let printAddition a b =
    let answer = a + b
    printfn $"{a} + {b} = {answer}"

printAddition 2 3

//

let getTheCurrentTime = System.DateTime.Now
let x = getTheCurrentTime
let y = getTheCurrentTime

//

let getTheCurrentTimeV2 () = System.DateTime.Now
let xV2 = getTheCurrentTimeV2 ()
let yV2 = getTheCurrentTimeV2 ()

//

let addDays days =
    let newDays = System.DateTime.Today.AddDays days
    printfn $"You game me {days} days and I gave you {newDays}"
    newDays

let resultAddDays = addDays 3

let addSeveralDays() =
    ignore (addDays 3)
    ignore (addDays 5)
    addDays 7
addSeveralDays

