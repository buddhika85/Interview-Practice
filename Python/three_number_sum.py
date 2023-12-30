def threeNumberSum(array, targetSum):
    triplets = []
    array.sort()
    i = 0
    while i < len(array):   
        left = i + 1
        right = len(array) - 1
        while left < right:
            sum = array[i] + array[left] + array[right]
            if sum == targetSum:
                triplets.append([array[i], array[left], array[right]])
                left += 1
                right -= 1
            elif sum < targetSum:
                left += 1                        # move left to right
            elif sum > targetSum:
                right -= 1                        # move right to left
        i += 1
    return triplets


# [12, 3, 1, 2, -6, 5, -8, 6]
# target Sum = 0
# [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
array = [12, 3, 1, 2, -6, 5, -8, 6]
target_sum = 0
print(f"Array => {array}\nTarget Sum => {target_sum}\ntriplets => {threeNumberSum(array, target_sum)}")