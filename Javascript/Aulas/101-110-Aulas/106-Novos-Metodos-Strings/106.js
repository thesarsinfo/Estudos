
let curso = "Curso de Javascript moderno ";
let p = "Curso"
// startsWith retorna true caso a PRIMEIRA CADEIA DE STRING SEJA IGUAL com valor informado e é sense sensitive
//nesse caso somente a palavra Curso
console.log("Metodo startsWith");

console.log(curso.startsWith("Curso"));
console.log(curso.startsWith("curso"));
console.log(curso.startsWith(p) ? "Verdadeiro" : "Realmente Falso");

//endsWith retorna true caso a ULTIMA CADEIA DE STRING SEJA IGUAL com valor informado e é sense sensitive
// Nesse caso somente a palavra  moderno , oderno, derno , erno, rno, no ,o retorna true
console.log("Metodo endsWith");

console.log(curso.endsWith("moderno") ? "Verdadeiro" : "Realmente Falso");

//includes procura na string o valor indicado
console.log("Metodo includes");
console.log(curso.includes("de") ? "Verdadeiro" : "Realmente Falso");
console.log(curso.includes("do") ? "Verdadeiro" : "Realmente Falso");
console.log(curso.includes("mo") ? "Verdadeiro" : "Realmente Falso");
//repeat
//repete a string uma determinada n vezes
console.log("Metodo repeat");
let r2 = curso.repeat(3)
console.log(r2);

