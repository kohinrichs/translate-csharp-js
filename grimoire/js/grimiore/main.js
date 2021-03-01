// Put your code here

let spellList = [
    {
        name: "Turn enemy into a newt",
        isEvil: true,
        energyReqired: 5.1
    },
    {
        name: "Conjure some gold for a local charity",
        isEvil: false,
        energyReqired: 2.99
    },
    {
        name: "Give a deaf person the ability to heal",
        isEvil: false,
        energyReqired: 12.2
    },
    {
        name: "Make yourself emperor of the universe",
        isEvil: true,
        energyReqired: 100.0
    },
    {
        name: "Convince your relatives your political views are correct",
        isEvil: false,
        energyReqired: 2921.5
    }
]

console.log("Do you believe in magic?");
console.log("------------------------");

let spellBookGood = [];
let spellBookEvil = [];

spellList.map(spell => {
    if (spell.isEvil === false) {
        spellBookGood.push(spell)
    } else {
        spellBookEvil.push(spell)
    }
})


console.log("Good Book")
let spellBookGoodTitles = spellBookGood.map(s => console.log(s.name))
console.log("Evil Book")
let spellBookEvilTitles = spellBookEvil.map(s => console.log(s.name))