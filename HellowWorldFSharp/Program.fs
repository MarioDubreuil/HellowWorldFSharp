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
addSeveralDays()

//

let mutable gas = 100.0
let drive distance =
    if distance = "far" then gas <- gas / 2.0
    elif distance = "medium" then gas <- gas - 10.0
    else gas <- gas - 1.0

drive "far"
drive "medium"
drive "short"
gas

//

let driveImmutable gas distance =
    if distance = "far" then gas / 2.0
    elif distance = "medium" then gas - 10.0
    else gas - 1.0
let gasImmutable = 100.0
let gasImmutableFirstState = driveImmutable gasImmutable "far"
let gasImmutableSecondState = driveImmutable gasImmutableFirstState "medium"
let gasImmutableFinalState = driveImmutable gasImmutableSecondState "short"
gasImmutableFinalState

// ex 4.3

let driveImmutableV2 gas distance =
    if distance > 50 then gas / 2.0
    elif distance > 25 then gas - 10.0
    elif distance > 0 then gas - 1.0
    else gas
driveImmutableV2 200 51
driveImmutableV2 200 50
driveImmutableV2 200 24
driveImmutableV2 200 1
driveImmutableV2 200 0

//

let nameTuple = "isaac", "abraham"
let firstNameTuple, lastNameTuple = nameTuple

//

let nameAndAge = "Jane", "Smith", 25
let firstName17, lastName17, _ = nameAndAge
let _, _, Age17 = nameAndAge

//

let makeDoctor name =
    let _, lastName = name
    "Dr", lastName
makeDoctor ("Steve", "Smith")
makeDoctor ("Steve", 17)
makeDoctor (24.3, 17)

//

let makeDoctor2 (name: string * string) =
    let _, lastName = name
    "Dr", lastName
makeDoctor2 ("Steve", "Smith")

//

let makeDoctor3 (_, lastName) =
    "Dr", lastName
makeDoctor3 ("Steve", "Smith")
makeDoctor3 (0, "Smith")
makeDoctor3 (24, 1.2)

//

let makeDoctor4 (_, lastName : string) =
    "Dr", lastName
makeDoctor4 ("Steve", "Smith")
makeDoctor4 (0, "Smith")

//

let makeDoctor5 (_ : string, lastName : string) =
    "Dr", lastName
makeDoctor5 ("Steve", "Smith")
