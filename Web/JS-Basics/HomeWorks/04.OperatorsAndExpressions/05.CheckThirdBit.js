function checkThirdBit(num) {
	var shifted = num >> 3,
		output;
	
	shifted % 2 === 0 ? output = 0 :  output = 1;
	return output;
}