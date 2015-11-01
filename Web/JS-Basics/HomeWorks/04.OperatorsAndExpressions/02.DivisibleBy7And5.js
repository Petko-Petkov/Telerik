function divisible(num){
	var currentNumber = parseInt(num);
	if(currentNumber % 7 === 0 && currentNumber % 5 === 0) {
		return true;
	}
	else {
		return false;
	}
}

console.log(divisible(3));
console.log(divisible(0));
console.log(divisible(5));
console.log(divisible(7));
console.log(divisible(35));
console.log(divisible(140));