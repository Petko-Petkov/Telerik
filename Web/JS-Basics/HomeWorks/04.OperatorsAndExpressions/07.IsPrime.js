function isPrime(num) {
	var i,
		len = Math.ceil(Math.sqrt(num)),
		prime = true;
		
	for (i = 2; i <= len; i += 1) {
		if (num % i === 0) {
			prime = false;
		}
	}
	
	return prime;
}