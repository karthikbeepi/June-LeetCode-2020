from typing import List
def reconstructQueue(self, people: List[List[int]]) -> List[List[int]]:
    people.sort(key= lambda x: (-x[0], x[1]))
    list = []
    for i in people:
        list.insert(i[1], i)
    return list