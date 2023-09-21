# Введите число N
N = int(input("Введите число N: "))

# Инициализируем степень двойки
power_of_two = 1

# Пока текущая степень двойки не превосходит N
while power_of_two <= N:
    print(power_of_two)
    power_of_two *= 2
