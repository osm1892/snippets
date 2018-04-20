factorial 0 = 1
factorial n = n * (factorial (n-1))

doublefactorial 1 = 1
doublefactorial 2 = 2
doublefactorial n = n * (doublefactorial (n-2))

mult x 0 = 0
mult 0 y = 0
mult x 1 = x
mult 1 y = y
mult x y = (mult x (y - 1)) + x

power x 0 = 1
power x 1 = x
power x 2 = (mult x x)
power x y = (mult x (power x (y-1)))

