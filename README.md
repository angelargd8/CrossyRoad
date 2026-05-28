# CrossyRoad

Proyecto realizado en Unity basado en el estilo de juego de Crossy Road.

El objetivo del juego es que el jugador avance por un mapa finito, evitando carros y obstaculos, hasta llegar a la meta. Durante el recorrido, el jugador gana puntos al avanzar y puede perder si entra en contacto con un carro.

### Enlace del video:
https://youtu.be/QaKtduPzNNQ

### Enlace de Itch.io:



---

## Objetivo

Llegar hasta el final del mapa sin ser atropellado por los carros.

El jugador debe avanzar por el escenario, esquivar obstaculos, evitar los carros generados por los spawners y alcanzar la zona final para activar la condicion de victoria.

---

## Controles

- W / Flecha arriba - Avanzar
- S / Flecha abajo - Retroceder
- A / Flecha izquierda - Moverse a la izquierda
- D / Flecha derecha - Moverse a la derecha

---

## Mecanicas implementadas

### Movimiento del jugador

Se implemento un sistema de movimiento por pasos.
El jugador se mueve en una direccion cada vez que se presiona una tecla.

Ademas, antes de moverse, se utiliza un Raycast para verificar si hay un obstaculo enfrente. Si hay un objeto bloqueando el camino, el jugador no puede avanzar en esa direccion.

Esto permite cumplir con:

- Movimiento del jugador
- Limites de movimiento
- Colisiones con obstaculos
- Bloqueo de zonas del mapa

---

## Mundo y escenario

El nivel se construyo en un espacio finito con una plataforma principal.
El mapa cuenta con diferentes zonas por las que el jugador debe avanzar hasta llegar a la meta.

Tambien se agregaron limites en los bordes del mundo para evitar que el jugador se salga o caiga de la plataforma.

Elementos incluidos en el escenario:

- Piso principal
- Limites invisibles
- Obstaculos
- Spawners de carros
- Carros
- Arboles y assets de carros
- Zona de victoria
- UI de puntos
- Panel de victoria
- Panel de derrota

---

## Obstaculos implementados

El jugador detecta estos obstaculos usando Raycast antes de moverse, evitando que pueda pasar encima o atravesarlos.

---

## Spawners y carros

Se implementaron spawners que generan carros durante la partida.

Los carros tienen su propio movimiento automatico y se desplazan constantemente en una direccion.

Cada carro:

- Se mueve de forma continua
- Se destruye al salir del mapa
- Puede colisionar con el jugador
- Activa la condicion de derrota al tocar al jugador

Esto permite que el nivel tenga peligro constante y que el jugador deba calcular cuando avanzar.

---

## Sistema de derrota

La derrota ocurre cuando un carro entra en contacto con el jugador.

Cuando esto sucede:

- Se muestra un mensaje en consola
- Se activa el panel de derrota
- El tiempo del juego se pausa usando Time.timeScale = 0
- El jugador puede reiniciar la escena usando el boton de Restart

Este sistema se maneja desde el GameManager.

---

## Sistema de victoria

La victoria ocurre cuando el jugador llega a la zona final del mapa.

La zona de victoria tiene un trigger que detecta al jugador.
Cuando el jugador entra en esta zona:

- Se muestra un mensaje en consola
- Se activa el panel de victoria
- El juego se pausa
- Se muestra la UI correspondiente


---

## Sistema de puntos

Se implemento un sistema de puntos que aumenta cuando el jugador avanza hacia una nueva fila del mapa.

El ScoreManager revisa la posicion del jugador en el eje Z.
Cuando el jugador avanza mas que su posicion anterior, se suman puntos.

Actualmente:

- Cada avance hacia adelante suma puntos
- El puntaje se muestra en pantalla
- La UI se actualiza durante la partida


---

## UI implementada

La interfaz del juego incluye:

- Texto de score
- Panel de derrota
- Panel de victoria
- Boton de reinicio
- Boton para cerrar el juego

---

## Audio

Se implemento un AudioManager para controlar la musica del juego.

El sistema permite:

- Reproducir musica por escena
- Mantener el audio entre escenas
- Controlar volumen maestro
- Controlar volumen de efectos
- Controlar volumen de ambiente
- Reproducir efectos de sonido


---

## Scripts principales

### PlayerMovement

Controla el movimiento del jugador por pasos y evita que atraviese obstaculos usando Raycast.

### CarMovement

Controla el movimiento de los carros, los destruye al salir del mapa y activa la derrota al tocar al jugador.

### GameManager

Controla la logica general del juego, incluyendo reiniciar la escena, cerrar el juego y activar la derrota.

### ScoreManager

Controla el sistema de puntos y actualiza el texto del score en la UI.

### WinCondition

Detecta cuando el jugador llega a la meta y activa el panel de victoria.

### AudioManager

Controla la musica, sonidos y volumen general del juego.

---

## Tecnologias utilizadas

- Unity
- C#
- TextMeshPro
- Unity UI
- Fisica y Colliders
- Triggers
- Raycast
- Scene Management

---

# Assets utilizados:
- https://assetstore.unity.com/packages/3d/props/environment-track-lowpoly-cartoon-props-mobile-free-211494
- https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-tree-pack-57866