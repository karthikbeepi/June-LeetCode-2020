def repeatedString(s, n):
    noOfAInString = 0
    noOfAinInfiniteString = n // len(s);
    remainder = n % len(s);
    countAInStringRem = 0
    for i in range(len(s)):
        if (s[i] == 'a' or s[i] == 'A'):
            noOfAInString += 1
            if i < remainder:
                countAInStringRem +=1
    return (noOfAinInfiniteString*noOfAInString) + countAInStringRem