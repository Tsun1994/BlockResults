Введите количество слов N
Введите несколько слов, колторые преобразуем в массив
Массив строк будет зарезервирован в a [N]
Теперь идем по нашему массиву от i = 0 до N
Смотрим длину текущего элемента a[i].lenght
Если a[i].lenght <= 3 мы записываем его значение в новый массив b[i], длина которого равна k = 0
Будет следующее выражение , если a[i].lenght <= 3, то к k прибавляем 1 (k++), b[i] становится равным a[i] (b[i] = a[i])
Прибавляем к i 1 (i++)
Повторяем до тех пор, пока i не станет равным N.
Выводим b[k], i = 0 до k, где все элементы имеют длину до трех символов