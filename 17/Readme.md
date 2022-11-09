# Visual Basic и макросы в MS Excel

## Полезные ссылки
[Microsoft](https://learn.microsoft.com/ru-ru/office/vba/library-reference/concepts/getting-started-with-vba-in-office "Официальный сайт Microsoft")

[Как включить редактор VBA в Excel](http://pivot-table.ru/kak-vklyuchit-redaktor-vba-v-excel-2010.html)

## VBA

VBA (Visual Basic for Application)- это объектно-ориентированный язык программирования.

Sub - процедура. Аналог void в С#. Без вывода.

Объявление переменных
Dim <имяПеременной> [As<типДанных>]

Пример:
Dim i As Integer, j As Integer
Dim x As Double

## Типы данных

- Array - массив переменных;
- Boolean - логическая переменная;
- Currency - денежные вычисления с фиксированным количеством щнаков после десятичной запятой;
- Date - хранение дат;
- Double - числа с плавающей запятой;
- Integer - короткие целые числа;
- Long - длинные целые числа;
- Object - только хранение ссылок на объекты;
- Single - числовые значения с плавающей точкой обычной точности;
- String - хранение строковых данных;
- Variant - различные типы данных.

## Синтаксис объвления процедур и функций

### Процедура
Sub SplitStr(str1 As String, str2 As String)

### Функций
Function FindSplitSpace (strl As String) As Integer

Dim MyStringVariable As String
    MyStringVariable = "Hello world!"
    Worksheets(1).Range("A1").Value = MyStringVariable