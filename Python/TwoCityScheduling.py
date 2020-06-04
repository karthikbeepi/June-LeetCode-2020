from typing import List
def twoCitySchedCost(costs: List[List[int]]) -> int:
    costs.sort(key = lambda x: abs(x[0]-x[1]))
    sum = 0
    lenA = 0 
    lenB = 0
    for i in range(len(costs)) :
        if lenA < len(costs)/2 and costs[i][0]<=costs[i][1]:
            sum = sum + costs[i][0]
            lenA += 1
        elif lenB < len(costs)/2 and costs[i][1]<= costs[i][0]:
            sum = sum + costs[i][1]
            lenB += 1
        else:
            if(lenA < lenB):
                sum += costs[i][0]
                lenA += 1
            else:
                sum += costs[i][1]
                lenB += 1
    return sum

print(twoCitySchedCost([[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]))
        

