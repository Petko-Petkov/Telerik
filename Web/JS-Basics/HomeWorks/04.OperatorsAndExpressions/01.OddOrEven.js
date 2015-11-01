function oddOrEven(num) {
	if(parseInt(num) % 2 === 0) {
		return false;
	}
	else {
		return true;
	}
}

console.log(OddOrEven(3));
console.log(OddOrEven(2));
console.log(OddOrEven(-2));
console.log(OddOrEven(-1));
console.log(OddOrEven(0));