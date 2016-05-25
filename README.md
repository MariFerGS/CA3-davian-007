![Octocat Logo](http://2.bp.blogspot.com/-z9YlNMIX5NE/Vdj07d3qPGI/AAAAAAAAAls/N8LFN6pPze0/s1600/github_128.png)
# CA3

## Programación 2
*Prof. Jorge Davián Aguilar Oviedo*

**Ejercicio 03**
>Ejemplo de markdown

## Propósito
Ejemplo de los siguientes temas
- **Variables compuestas**
- *Enumeraciones*
```C#
enum DayofWeek
{
    sunday,
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
};

enum BookPrice
{
    Low = 500,
    MediumLow = 2500,
    Medium = 5000,
    MediumHigh = 7500,
    High = 10000,
};
```
- *Estructuras*
```C#
struct Book
{
    int bookid;
    string bookname;
    string author;
    double bookprice;
};

struct Game
{
    int id;
    string name;
    int rating;
};
```
- *Arreglos*
```C#
//unidimencionales - vectores
int[] vector1 = new int[4];
int[] vector2 = new int[] { 1, 3, 9, 12, 15 };
int[] array1 = { 1, 2, 3, 4, 5, 6 };

//multidimencionales - matrices
int[,] matrix1 = new int[2, 3];
int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 } };
```
- **Ciclos**
- *For*
```C#
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(vector2[i]);
}
```
- **Uso de librerias - bibliotecas**
-*Namespaces*
```C#
//Comunes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
```


- **Sistemas numéricos**
- *Binario* 11010101
- *Octal*  325
- *Decimal*  213
- *Hexadecimal*  D5


- **Pendientes**
- [ ] Asignación en clase
- [ ] Tarea 03

Enlace a repositorio | Enlace a commit
------------ | -------------
davian-007/CA3 | 

Github - davian-007
[CA3](https://github.com/Programacion-II/CA3)

@davian-007 :thumbsup:
