# Читаем количество кустов N из входного файла
N = int(input())

# Читаем количество ягод на каждом кусте и сохраняем в список
berries = list(map(int, input().split()))

# Инициализируем переменную для максимального урожая
max_harvest = 0

# Перебираем каждый куст
for i in range(N):
    # Вычисляем количество собранных ягод перед текущим кустом
    current_harvest = berries[i] + (berries[i - 1] if i - 1 >= 0 else 0) + (berries[i + 1] if i + 1 < N else 0)
    
    # Обновляем максимальный урожай, если текущий урожай больше
    max_harvest = max(max_harvest, current_harvest)

# Выводим максимальный урожай
print(max_harvest)
