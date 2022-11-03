from turtle import *
from random import randint

finish = 200#дистанция гонки

t1 = Turtle()#СОздает объект класса Turtle
t1.shape("turtle")# поменяли форму объекта
t1.color("red")# меняем цвет объекта
t1.penup()#Поднимаем черепашку чтобы не рисовала
t1.goto(-200,20)#Перемещаем черепашку по координатам
t1.pendown()#Опускаем черепашку чтобы потом рисовала

t2 = Turtle()#СОздает объект класса Turtle
t2.shape("turtle")# поменяли форму объекта
t2.color("blue")# меняем цвет объекта
t2.penup()#Поднимаем черепашку чтобы не рисовала
t2.goto(-200,-20)#Перемещаем черепашку по координатам
t2.pendown()#Опускаем черепашку чтобы потом рисовала

def razmetka():
    t = Turtle()
    t.speed(0)
    for i in range (1,21):
        t.penup()
        t.goto(-200+i*20, 50)
        t.pendown()
        t.goto(-200+i*20, 100)
    t.hideturtle()
    
razmetka()