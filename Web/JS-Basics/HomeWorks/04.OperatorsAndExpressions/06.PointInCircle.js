function inCircle(pointX, pointY) {
	var hypotenuse = Math.pow(pointX, 2) + Math.pow(pointY, 2),
		output;
	
	Math.sqrt(hypotenuse) <= 5 ? output = true : output = false;
	
	return output;
}