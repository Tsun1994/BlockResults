Введите количество слов N
Введите несколько слов, колторые преобразуем в массив
Массив строк будет зарезервирован в a [N]
Теперь идем по нашему массиву от i = 0 до N
Смотрим длину текущего элемента a[i].lenght
Если a[i].lenght <= 3 мы записываем его значение в новый массив b[i], длина которого равна длине массива a.lenght
Вводим счетчик k = 0
Будет следующее выражение , если a[i].lenght <= 3, b[k] становится равным a[i] (b[k] = a[i])
Прибавляем к i 1 и k прибавляем 1 (i++, k++)
Повторяем до тех пор, пока i не станет равным N.
Выводим b[i], i = 0 до k, где все элементы имеют длину до трех символов