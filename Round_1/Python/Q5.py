def nonConstructibleChange(coins):
    coins.sort()
    change_made = 0
    for coin in coins:
        if coin > change_made + 1:
            return change_made + 1
        else:
            change_made += coin
    return change_made + 1

print(f"{nonConstructibleChange([1,2,5]) == 4}")
print(f"{nonConstructibleChange([1,10]) == 2}")
print(f"{nonConstructibleChange([5,7,1,1,2,3,22]) == 20}")
print(f"{nonConstructibleChange([1,1, 1, 1, 1]) == 6}")