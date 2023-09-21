# Введите сумму и произведение чисел S и P
S = int(input("Введите сумму S: "))
P = int(input("Введите произведение P: "))

# Инициализируем переменные для хранения чисел X и Y
X = 1
Y = S - 1

# Перебираем возможные значения X и Y
while X <= Y:
    if X * Y == P:
        break
    X += 1
    Y -= 1

# Выводим результат
if X <= Y:
    print(f"Числа X и Y равны {X} и {Y} соответственно.")
else:
    print("Нет таких натуральных чисел X и Y, удовлетворяющих заданным условиям.")
