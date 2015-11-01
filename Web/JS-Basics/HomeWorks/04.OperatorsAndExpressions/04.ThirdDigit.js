function checkThirdDigit(num) {
	if (num < 700) {
		return false;
	}
	
	var currentNumber = parseInt(num / 100),
		thirdDigit = currentNumber > 10 ? currentNumber % 10 : currentNumber;
	
	if (thirdDigit === 7) {
		return true;
	} 
	
	return false;
}