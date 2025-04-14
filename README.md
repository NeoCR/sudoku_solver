# Sudoku Solver
Proyecto creado en ASP .Net 8 con el fin de crear una herramienta que pueda resolver cualquier sudoku con sólo digitar las pistas.

## Cómo se juega un sudoku
Sudoku se juega en una cuadrícula de 9 x 9 espacios. Dentro de las filas y columnas hay 9 "cuadrados" (compuestos de 3 x 3 espacios). Cada fila, columna y cuadrado (9 espacios cada uno) debe completarse con los números del 1 al 9, sin repetir ningún número dentro de la fila, columna o cuadrado (1). 

![Cuadrícula de sudoku](https://sudoku.com/img/post-images/1541158574-Sudoku-Rules-for-Complete-Beginners-1.jpg)

## Reglas del sudoku
Para poder hacer una herramienta que resuelva un sudoku, hay que conocer cuales son las reglas del juego:
- Se deben colocar números del 1 al 9
- No se debe repetir el mismo número en la misma fila
- No se debe repetir el mismo número en la misma columna
- No se debe repetir el mismo número en el mismo cuadrado de 3 x 3
- Solo puede tener 1 solución

## Creación del solucionario
La idea es crear una cuadrícula en blanco, donde el usuario puede digitar las pistas en su posición correspondiente y al presionar un botón se va a mostrar el sudoku lleno.

Se va a utilizar una función recursiva para encontrar la solución del sudoku.

Se van a crear funciones para verificar que el número no exista en la fila, en la columna y en el cuadrado.

## Referencias
1. https://sudoku.com/es/como-jugar/reglas-de-sudoku-para-principiantes/