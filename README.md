// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


1. Создаем "массив"
2. Создаем пустой второй "новый массив" с таким же размером как "массив"
3. Перебираем все элементы "массива"
4. Условие: если длина элемента "массива"(строка) <= 3, то записываем его в "новый массив" и продолжаем перебирать дальше "массив"
5. Выводим "новый массив"