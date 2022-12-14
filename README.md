# Итоговая проверочная работа

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм
Блок-схема алгоритма находится в файле "Algorithm.png"

0. СТАРТ
1. В программу вносятся заполненные различными данными массивы.
2. Создаётся новый массив, в который будут записываться строки, длина которых не более 3-х символов. Задается счетчик "i=0".
3. Выводится первый массив на экран пользователя.
4. Задаётся условие при котором второй массив не должен быть длиннее первого при помощи счётчика. В ином случае алгоритм переходит к пункту 5.  
  4а. Проверяется, длинне ли строка первого массива установленного значения "3". Если да, переходит к пункту 4в.  
  4б. Строка записывается во второй массив.  
  4в. К счетчику "i" добавляется 1.  
  4г. Переходит к пункту 4.
5. Проверяется есть ли во втором массиве строки.  
  5а. Если да, второй массив выводится на экран.  
  5в. Если нет, на экран выводится что строк, подходящих под условие, в первом массиве нет.
6. ФИНИШ

## Программа
Задача выполнена согласно алгоритму в Visual Studio Code. В репозиторий залита несколькими коммитами, в каждом из которых представлен шаг к решению поставленной задачи. Для наглядности использованы массивы из заданного примера. Результат идентичен.

# 03/10/2022
