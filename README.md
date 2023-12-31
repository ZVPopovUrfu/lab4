# Анализ данных в разработке игр
Отчет по лабораторной работе #4 выполнил(а):
- Попов Захар Владимирович
- РИ220943
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

## Цель работы
Реализовать перцептрон в Unity и визуализировать их работу.

## Задание 1
### в проекте Unity реализовать перцептрон, который умеет производить вычисления. Дать комментарии о корректности работы.
Все, кроме XOR, работает корректно.

![Screnshot](https://github.com/ZVPopovUrfu/lab4/blob/main/Screenshot%202023-11-28%20205301.png)

## Задание 2
### Построить графики зависимости количества эпох от ошибки  обучения. Указать от чего зависит необходимое количество эпох обучения.
Графики - https://docs.google.com/spreadsheets/d/1pQfy60mtvw1AvubAtWu4F7oZkMqm71-mp0R6F-1hRfc/edit#gid=0
Необходимое количество эпох зависит от количества ошибок. Если на текущей эпохе количество ошибок = 0, то это и есть необходимое количество эпох обучения.

## Задание 3
### Построить визуальную модель работы перцептрона на сцене Unity.
Создал 4 сцены: AND, NAND, OR, XOR. В каждой из них есть по 4 куба. Каждый куб это определенный тест, слева направо: тест00, тест01, тест10, тест11 (в названии куба указан какой тест). При запуске сцены куб перекрашивается в цвет в зависимости от результата: если результат = 1 то цвет белый, иначе цвет черный.
Проект - https://github.com/ZVPopovUrfu/lab4/tree/main/perceptron-WorkShop%234.

## Выводы
В ходе выполнения лабораторной работы я научился работать с перцептронами в Unity, построил графики зависимости эпох от количества ошибок в таблице. Визуализировал работу перцептрона в Unity.

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
