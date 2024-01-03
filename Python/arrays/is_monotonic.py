def isMonotonic(array):
    is_increasing = True
    is_decreasing = True
    i = 0
    while i < len(array) - 1:
        is_increasing = is_increasing and array[i] <= array[i + 1]
        is_decreasing = is_decreasing and array[i] >= array[i + 1]
        i += 1
    return is_increasing or is_decreasing

# Test code
monotonics = [[], [1], [1, 2, 2, 3, 5], [7, 5, 4, 3, 1], [2, 4, 6, 8, 10], [9, 7, 5, 3, 1], [-1, -2, -2, -3, -5]]
print("Monotonics")
for data in monotonics:
    print(f"{data} => {isMonotonic(data)}")

non_monotonics = [[1, 2, 2, 1, 3, 5], [7, 5, 2, 4, 3, 1], [2, 4, 6, 3, 8, 10], [9, 7, 5, 3, 1, 10], [-1, -2, -2, -3, -5, 1]]
print("Non Monotonics")
for data in non_monotonics:
    print(f"{data} => {isMonotonic(data)}")