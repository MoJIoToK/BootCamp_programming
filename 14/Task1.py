from turtle import *
from random import randint

finish = 200  # дистанция гонки

t1 = Turtle()  # СОздает объект класса Turtle
t1.shape("turtle")  # поменяли форму объекта
t1.color("red")  # меняем цвет объекта
t1.penup()  # Поднимаем черепашку чтобы не рисовала
t1.goto(-200, 20)  # Перемещаем черепашку по координатам
t1.pendown()  # Опускаем черепашку чтобы потом рисовала

t2 = Turtle()  # СОздает объект класса Turtle
t2.shape("turtle")  # поменяли форму объекта
t2.color("blue")  # меняем цвет объекта
t2.penup()  # Поднимаем черепашку чтобы не рисовала
t2.goto(-200, -20)  # Перемещаем черепашку по координатам
t2.pendown()  # Опускаем черепашку чтобы потом рисовала


def razmetka():
    t = Turtle()
    t.speed(0)
    for i in range(1, 21):
        t.penup()
        t.goto(-200+i*20, 50)
        t.pendown()
        t.goto(-200+i*20, 100)
    t.hideturtle()

razmetka()

def catch1(x,y):
    t1.write('Ouch!', font=('Arial', 14, 'normal')) # Пишем на экране АУч
    t1.fd(randint(10,15)) # Черепашка делает случайный шаг от 10 до 15

t1.onclick(catch1) #Прикрепили обработчик к событию - нажатие на 1 черепашку

while t1.xcor() < finish and t2.xcor() < finish:
    t1.forward(randint(2, 7)) #Черепаха двигается вперед и рисует линию на случайное число в диапазоне от 2 до 7
    t2.forward(randint(2, 7))


