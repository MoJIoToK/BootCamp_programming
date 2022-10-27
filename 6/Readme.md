# Быстрая сортировака (Quick Sort) - БС(QS)

У быстрой сортировки всегда три шага. QS основан на рекурсии.

## Шаги:
___
1. Получение массива - [1, 0, -6, 2, 5, 3, 2]. 
2. Выбор опорного элемента (пивота). Обычно первый либо последний. [1, 0, -6, 2, 5, 3, 2], array[6] = 2 = pivot.
Сортируем так, чтобы все числа меньше были слева, а больше справа. [1, 0, -6, 2, **2**, 5, 3]
3. Вызвать шаги 1-2 для подмассива слева от pivot и cправа от pivot

Подмассив слева:
1. [1, 0, -6, 2] 
2. pivot = 2. [1, 0, -6, 2]
3. [1, 0, -6]

    1. [1, 0, -6]
    2. pivot = -6. [-6, 1, 0]
    3. [1, 0]

        1. [1, 0]
        2. pivot = 0. [0, 1]
        3. [0, 1]

Подмассив справа - [5, 3]
1. [5, 3]
2. pivot = 3. [3, 5]
3. [3, 5]

### Reference

Массивы это ссылочные типы