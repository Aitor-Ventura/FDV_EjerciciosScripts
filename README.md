# 🎮 Ejercicios sobre Scripts
## Ejercicio 1
#### ¿Cómo modificarías el script para que el objeto despegue del suelo y vuele como un avión?
Se hace uso de la función de los vectores Vector3.MoveTowards(). 
![gif ejercicio 1](/Gifs/Ejercicio1.gif)

## Ejercicio 2
#### ¿Es consistente el movimiento, duplicando los valores XYZ del objetivo?
No es consistente el movimiento puesto que se ha hecho de forma que el objeto vaya a un punto específico, no a una dirección.

Sin embargo, para este ejercicio se consigue hacerlo para una dirección, utilizando la función Translate de los objetos de tipo Transform. 
![gif ejercicio 2](/Gifs/Ejercicio2.gif)

## Ejercicio 3
#### ¡Vamos a movernos hacia una posición objetivo!
Ahora nos movemos hasta la posición objetivo. 
![gif ejercicio 3](/Gifs/Ejercicio3.gif)

## Ejercicio 4
#### El personjae calcula la dirección hacia el objetivo y se mueve hacia él, pero puede dejar de moverse y se produce jittering. 
Se le añade un umbral para evitar el efecto de jittering. 
![gif ejercicio 4](/Gifs/Ejercicio4.gif)

## Ejercicio 5
#### ¡Girar hacia el objetivo!
Se utiliza el método LookAt.
![gif ejercicio 5](/Gifs/Ejercicio5.gif)

## Ejercicio 6
#### ¡Añadir un rayo para depurar!
Se le añade un rayo para depurar y comprobar que la dirección está correctamente calculada.
![gif ejercicio 6](/Gifs/Ejercicio6.gif)

## Ejercicio 7
#### Haz una script para hacer que la esfera siga al cubo. El cubo debe ser movido usando las flechas WASD.
Las esferas siguen al cubo utilizando la función Vector3.MoveTowards().
![gif ejercicio 7](/Gifs/Ejercicio7.gif)

## Ejercicio 8
### Ejercicio 8a
Ninguno de los objetos es físico.
![gif ejercicio 8](/Gifs/Ejercicio8a.png)

### Ejercicio 8b
La esfera tiene físicas, el cubo no, pero se puede mover.
![gif ejercicio 8](/Gifs/Ejercicio8b.gif)

### Ejercicio 8c
Las esferas y el cubo tienen físicas.
![gif ejercicio 8](/Gifs/Ejercicio8c.gif)

### Ejercicio 8d
La esfera superior tiene diez veces más la masa del cubo.
![gif ejercicio 8](/Gifs/Ejercicio8d.gif)

### Ejercicio 8e
Las esferas tienen físicas y el cubo es de tipo IsTrigger estático.
![gif ejercicio 8](/Gifs/Ejercicio8e.gif)

### Ejercicio 8f
Las esferas tienen físicas y el cubo es de tipo IsTrigger y cinemático.
![gif ejercicio 8](/Gifs/Ejercicio8f.gif)

### Ejercicio 8g
Las esferas tienen físicas y el cubo es de tipo IsTrigger y mecánico.
![gif ejercicio 8](/Gifs/Ejercicio8g.gif)

### Ejercicio 8h
La esfera superior es física, tiene diez veces la masa del cubo, el cubo tiene físicas, y se impide la rotación del mismo sobre el plano XZ.
![gif ejercicio 8](/Gifs/Ejercicio8h.gif)

## Ejercicio 9
#### Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Cuando el jugador pulse las teclas WASD el jugador se moverá en la dirección que estos ejes indican. Sin usar simulación física. Implementado un campo público que permita graduar la velocidad del desplazamiento en tiempo de juego. Estar a la escucha de si el usuario ha usado los ejes virtuales. Y elegir los otros ejes virtuales para el giro, y girar al jugador sobre el eje OY (up). 
El jugador se mueve con WASD y rota con las flechas. Con la barra espaciadora se multiplica la velocidad a la que se mueve.
![gif ejercicio 9](/Gifs/Ejercicio9.gif)
![gif ejercicio 9](/Gifs/Ejercicio9b_Speed.gif)

## Ejercicio 10
#### Porgrama las scripts necesarias para que cada vez que el jugador colisione con un cilindro, se deba mostrar en la consola un mensaje indicando el nombre del cilindro con el que colisiona, cambiar el color a rojo, y aumentar la puntuación del jugador.
![gif ejercicio 10](/Gifs/Ejercicio10.gif)
