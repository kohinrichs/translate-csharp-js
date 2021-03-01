// Put your code here
let places = ["Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

console.log("All Place Names")

places.forEach(p => console.log(p))

let placesWithThe = places.filter(p => p.startsWith("The"))

console.log("'The' Place Names")

for (let place of placesWithThe) {
    console.log(place)
}