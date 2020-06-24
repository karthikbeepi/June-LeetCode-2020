def jumpingOnClouds(c):
    no_of_jumps = 0
    cur = 0
    while cur < len(c)-2:
        if c[cur] == 0:
            cur += 2
        else:
            cur += 1
        no_of_jumps += 1
    if cur != len(c) - 1:
        no_of_jumps += 1
    return no_of_jumps