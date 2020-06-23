def xorOperation(n: int, start: int) -> int:
        sumVar = start
        i = start+2
        while (i<start+(2*n)):
            sumVar ^= i
            i+=2
        return sumVar

print(xorOperation(4, 3))