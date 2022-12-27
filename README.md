#Описание программы

##Ввод данных и получение начального массива

Пользователь вводит количество элементов ***objects*** массива, затем создается массив ***array*** с количеством эелментов равным ***objects*** после чего запускается цикл for(int i = 0; i < objects; i++) и пользователь начинает вводить элементы массива по порядку.

##Метод PrintArray

В данный метод на вход поступает массив ***inputArray***, затем выводится "[" для эстетической красоты. После запускается цикл for(int i = 0; i < inputArray.GetLength(0); i++), в котором выводится каждый элемент массива ***inputArray*** и ";" по порядку. Затем для эстетики выводится "]".

##Метод CheckArray

В данный метод на вход поступает массив ***inputArray***, задается счетчик ***count=0***, запускается цикл for(int i = 0; i < inputArray.GetLength(0); i++), в котором каждый элемент массива ***inputArray*** проверяется через условие if(inputArray[i].Length <= 3). Если количество символов меньше, либо равно 3, то счетчик ***count*** увеличивается на 1. Если количество символов больше 3, то ничего не происходит.
Далее задается новый массив ***newArray*** с количеством элементов равным ***count*** полученным из предыдущего цикла. Задается переменная ***j=0***. Запускается цикл for(int i = 0; i < inputArray.GetLength(0); i++), в котором каждый элемент массива ***inputArray*** проверяется через условие if(inputArray[i].Length <= 3). Если количество символов меньше, либо равно 3, то данный элемент записывается в массив ***newArray*** под индексом ***j*** и индекс ***j*** увеличивается на 1. Если количество символов больше 3, то ничего не происходит.
Из данного метода возвращается массив ***newArray***.

##Вывод данных

Запускается метод PrintArray c массивом на входе ***array***. Происходит вывод массива на экран.
Затем выводится на экран "->" для эстетичности.
После этого запускается метод PrintArray, в котором лежит метод CheckArray, который имеет на входе массив ***array***

##Итог

В итоге на экране получаем первоначальный массив заданный пользователем и отсортированный массив по принципу количества символов в элементе массива.