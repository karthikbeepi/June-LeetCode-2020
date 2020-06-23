def countingValleys(n, s):
    valley_levels = []
    valley_levels.append(0)
    previous_step = 0
    for c in s:
        valley_levels.append(valley_levels[previous_step]+1 if c is 'U' else valley_levels[previous_step]-1)
        previous_step += 1
    previous_step = 0
    valley_count = 0
    for i in range(1, len(valley_levels) + 1):
        if(valley_levels[i-1]==-1 and valley_levels[i]==0):
            valley_count += 1
    return valley_count

countingValleys(8 , "UDDDUDUU")
