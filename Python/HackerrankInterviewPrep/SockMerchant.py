def sockMerchant(n, ar):
    noOfPairs = 0
    sockCountDictionary = {}
    for i in ar:
        if i in sockCountDictionary:
            sockCountDictionary[i] += 1
        else:
            sockCountDictionary[i] = 1
    for i in sockCountDictionary.keys():
        noOfPairs += sockCountDictionary[i] // 2
    return noOfPairs